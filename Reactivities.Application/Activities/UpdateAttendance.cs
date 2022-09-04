using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Core;
using Reactivities.Application.Interfaces;
using Reactivities.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Activities
{
    public class UpdateAttendance
    {
        public class Command : IRequest<Result<Unit>>
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly ReactivitiesDataContext context;
            private readonly IUserAccessor accessor;

            public Handler(ReactivitiesDataContext context, IUserAccessor accessor)
            {
                this.context = context;
                this.accessor = accessor;
            }

            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var activity = await context.Activities.Include(x => x.Attendees)
                    .ThenInclude(x => x.AppUser).FirstAsync(x => x.Id == request.Id);

                if(activity == null)
                {
                    return null;
                }

                string username = accessor.GetUsername();
                var user = await context.Users.FirstAsync(x => x.UserName == username);

                if (user == null)
                    return null;

                var hostUsername = activity.Attendees.FirstOrDefault(x =>
                        x.IsHost)?.AppUser?.UserName;

                var attendance = activity.Attendees.FirstOrDefault(x =>
                    x.AppUser.UserName == username);

                if(attendance != null && hostUsername == username)
                {
                    activity.IsCancelled = !activity.IsCancelled;
                }

                if(attendance != null && hostUsername != username)
                {
                    activity.Attendees.Remove(attendance);
                }

                if(attendance == null)
                {
                    attendance = new Domain.ActivityAttendee
                    {
                        AppUser = user,
                        Activity = activity,
                        IsHost = false
                    };
                    activity.Attendees.Add(attendance);
                }

                var result = await context.SaveChangesAsync() > 0;
                return result ? Result<Unit>.Success(Unit.Value)
                    : Result<Unit>.Failure("Failed to update attendance");
            }
        }
    }
}
