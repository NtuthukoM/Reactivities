using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Core;
using Reactivities.Application.Interfaces;
using Reactivities.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Profiles
{
    public class Details
    {
        public class Query : IRequest<Result<Profile>>
        {
            public string Username { get; set; }
        }

        public class Handler: IRequestHandler<Query, Result<Profile>>
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

            public async Task<Result<Profile>> Handle(Query request, CancellationToken cancellationToken)
            {
                string currentUsername = userAccessor.GetUsername();
                var user = await context.Users
                    .ProjectTo<Profile>(mapper.ConfigurationProvider, new {currentUsername})
                    .FirstOrDefaultAsync(x => x.Username == request.Username);

                if (user == null) return null;
                return Result<Profile>.Success(user);
            }
        }
    }
}
