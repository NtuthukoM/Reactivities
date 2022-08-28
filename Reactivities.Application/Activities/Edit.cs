using AutoMapper;
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
    public class Edit
    {
        public class Command : IRequest<Result<Unit>>
        {
            public Activity Activity { get; set; }
        }

        public class CommondValidator : AbstractValidator<Command>
        {
            public CommondValidator()
            {
                RuleFor(x => x.Activity).SetValidator(new ActivityValidator());
            }
        }

        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly ReactivitiesDataContext context;
            private readonly IMapper mapper;

            public Handler(ReactivitiesDataContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }
            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var model = await context.Activities.FindAsync(request.Activity.Id);
                var activity = request.Activity;
                if(model != null)
                {
                    mapper.Map(activity, model);
                    model.Title = activity.Title ?? model.Title;
                   var result =  await context.SaveChangesAsync() > 0;
                    if (!result) return Result<Unit>.Failure("Failed to edit activity.");
                    return Result<Unit>.Success(Unit.Value);
                }

                return  null;
            }
        }
    }
}
