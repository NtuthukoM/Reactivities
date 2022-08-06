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
    public class Create
    {
        public class Command : IRequest
        {
            public Activity Activity { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly ReactivitiesDataContext context;

            public Handler(ReactivitiesDataContext context)
            {
                this.context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                await context.Activities.AddAsync(request.Activity);
                await context.SaveChangesAsync();
                return Unit.Value; //returns nothing but lets the API controller know that execution is finished.
            }
        }
    }
}
