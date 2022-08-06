using MediatR;
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
        public class Query : IRequest<Activity> 
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Activity>
        {
            private readonly ReactivitiesDataContext context;

            public Handler(ReactivitiesDataContext context)
            {
                this.context = context;
            }
            public async Task<Activity> Handle(Query request, CancellationToken cancellationToken)
            {
                return await context.Activities.FindAsync(request.Id);
            }
        }
    }
}
