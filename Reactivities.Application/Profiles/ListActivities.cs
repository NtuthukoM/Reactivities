using AutoMapper;
using MediatR;
using Reactivities.Application.Activities;
using Reactivities.Application.Core;
using Reactivities.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Profiles
{
    public class ListActivities
    {
        public class Query: IRequest<Result<List<UserActivityDto>>>
        {
            public ActivityParams Params { get; set; }
            public string Username { get; set; }
        }

        public class Handler: IRequestHandler<Query, Result<List<UserActivityDto>>>
        {
            private readonly ReactivitiesDataContext dataContext;
            private readonly IMapper mapper;

            public Handler(ReactivitiesDataContext dataContext, IMapper mapper)
            {
                this.dataContext = dataContext;
                this.mapper = mapper;
            }

            public Task<Result<List<UserActivityDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
