using MediatR;
using Reactivities.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Activities
{
    public class Delete
    {
        public class Command: IRequest
        {
            public int Id { get; set; }
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
                var model = await context.Activities.FindAsync(request.Id);
                if(model != null)
                {
                    context.Activities.Remove(model);
                    await context.SaveChangesAsync();
                }
                return Unit.Value;
            }
        }
    }
}
