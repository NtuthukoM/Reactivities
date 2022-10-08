using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Core;
using Reactivities.Application.Interfaces;
using Reactivities.Persistance;

namespace Reactivities.Application.Activities
{
    public class List
    {
        public class Query : IRequest<Result<PagedList<ActivityDto>>>
        {
            public ActivityParams Params { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<PagedList<ActivityDto>>>
        {
            private readonly ReactivitiesDataContext context;
            private readonly IMapper mapper;
            private readonly IUserAccessor userAccessor;

            public Handler(ReactivitiesDataContext context, IMapper mapper,
                IUserAccessor userAccessor)
            {
                this.context = context;
                this.mapper = mapper;
                this.userAccessor = userAccessor;
            }

            public async Task<Result<PagedList<ActivityDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                string currentUsername = userAccessor.GetUsername();
                var query = context.Activities
                    .Where(x => x.Date >= request.Params.StartDate)
                    .OrderBy(x => x.Date)
                    .ProjectTo<ActivityDto>(mapper.ConfigurationProvider, new { currentUsername })
                    .AsQueryable();

                if(request.Params.IsGoing && !request.Params.IsHost)
                {
                    query = query.Where(x => x.Attendees.Any(a => a.Username == userAccessor.GetUsername()));
                }

                if(request.Params.IsHost && !request.Params.IsGoing)
                {
                    query = query.Where(x => x.HostUsername == userAccessor.GetUsername()); 
                }

                var result = await PagedList<ActivityDto>.CreateAsync(query, request.Params.PageNumber,
                    request.Params.PageSize);
                                        
                return Result<PagedList<ActivityDto>>.Success(result);
            }
        }
    }
}
