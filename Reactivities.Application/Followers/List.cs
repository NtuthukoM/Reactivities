using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Core;
using Reactivities.Application.Interfaces;
using Reactivities.Application.Profiles;
using Reactivities.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Profile = Reactivities.Application.Profiles.Profile;

namespace Reactivities.Application.Followers
{
    public class List
    {
        public class Query : IRequest<Result<List<Profile>>>
        {
            public string Predicate { get; set; }
            public string Username { get; set; }

        }

        public class Handler : IRequestHandler<Query, Result<List<Profile>>>
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

            public async Task<Result<List<Profile>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var profiles = new List<Profile>();
                string currentUsername = userAccessor.GetUsername();
                switch (request.Predicate)
                {
                    case "following":
                        profiles = await context.UserFollowings.Where(x => x.Target.UserName == request.Username)
                            .Select(x => x.Observer)
                            .ProjectTo<Profile>(mapper.ConfigurationProvider, new { currentUsername })
                            .ToListAsync();
                        break;
                    case "followers":
                        profiles = await context.UserFollowings.Where(x => x.Observer.UserName == request.Username)
                            .Select(x => x.Target)
                            .ProjectTo<Profile>(mapper.ConfigurationProvider, new { currentUsername })
                            .ToListAsync();
                        break;
                }
                return Result<List<Profile>>.Success(profiles);

            }
        }
    }
}
