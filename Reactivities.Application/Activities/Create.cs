using FluentValidation;
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
    public class Create
    {
        public class Command : IRequest<Result<Unit>>
        {
            public Activity Activity { get; set; }
        }

        public class CommondValidator:AbstractValidator<Command>
        {
            public CommondValidator()
            {
                RuleFor(x => x.Activity).SetValidator(new ActivityValidator());
            }
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
                await context.Activities.AddAsync(request.Activity);
               var result = await context.SaveChangesAsync() > 0;
                if (!result)
                    return Result<Unit>.Failure("Faile to create activity.");
                return Result<Unit>.Success(Unit.Value); //returns nothing but lets the API controller know that execution is finished.
            }
        }
    }
}
