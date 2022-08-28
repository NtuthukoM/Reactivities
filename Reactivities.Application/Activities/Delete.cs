using MediatR;
using Reactivities.Application.Core;
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
        public class Command: IRequest<Result<Unit>>
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly ReactivitiesDataContext context;

            public Handler(ReactivitiesDataContext context)
            {
                this.context = context;
            }
            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var model = await context.Activities.FindAsync(request.Id);
                if(model != null)
                {
                    context.Activities.Remove(model);
                    var result = await context.SaveChangesAsync() > 0;
                    if (!result) return Result<Unit>.Failure("Failed to delete activity");
                    return Result<Unit>.Success(Unit.Value);
                }
                return null;
            }
        }
    }
}
