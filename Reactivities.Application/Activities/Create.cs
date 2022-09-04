using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Core;
using Reactivities.Application.Interfaces;
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
            private readonly IUserAccessor userAccessor;

            public Handler(ReactivitiesDataContext context, IUserAccessor userAccessor)
            {
                this.context = context;
                this.userAccessor = userAccessor;
            }

            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var username = userAccessor.GetUsername();
                var user = await context.Users.FirstOrDefaultAsync(x => x.UserName == username);
                var activityAttendee = new ActivityAttendee
                {
                    AppUser = user,
                    Activity = request.Activity
                };
                request.Activity.Attendees.Add(activityAttendee);

                await context.Activities.AddAsync(request.Activity);
               var result = await context.SaveChangesAsync() > 0;
                if (!result)
                    return Result<Unit>.Failure("Faile to create activity.");
                return Result<Unit>.Success(Unit.Value); //returns nothing but lets the API controller know that execution is finished.
            }
        }
    }
}
