using MediatR;
using Reactivities.Application.Core;
using Reactivities.Domain;
using Reactivities.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Activities
{
    public class Details
    {
        public class Query : IRequest<Result<Activity> >
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<Activity>>
        {
            private readonly ReactivitiesDataContext context;

            public Handler(ReactivitiesDataContext context)
            {
                this.context = context;
            }
            public async Task<Result<Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
                var model = await context.Activities.FindAsync(request.Id);
                return Result<Activity>.Success(model);
            }
        }
    }
}
