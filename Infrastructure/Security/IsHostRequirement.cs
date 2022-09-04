using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Reactivities.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Security
{
    public class IsHostRequirement : IAuthorizationRequirement
    {

    }

    public class IsHostRequirementHandler : AuthorizationHandler<IsHostRequirement>
    {
        private readonly ReactivitiesDataContext dbContext;
        private readonly IHttpContextAccessor contextAccessor;

        public IsHostRequirementHandler(ReactivitiesDataContext dbContext, 
            IHttpContextAccessor contextAccessor)
        {
            this.dbContext = dbContext;
            this.contextAccessor = contextAccessor;
        }
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, 
            IsHostRequirement requirement)
        {
            var userId = context.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if(userId == null)
            {
                return Task.CompletedTask;
            }
            var requestValue = contextAccessor.HttpContext?.Request?.RouteValues?.SingleOrDefault(x => x.Key == "id");
            if(requestValue == null)
            {
                return Task.CompletedTask;
            }
            var activityId = int.Parse(requestValue.ToString());

            var attendee = dbContext.ActivityAttendees
                .AsNoTracking() //don't keep in memory when saving later on
                .SingleOrDefault(x => x.AppUserId == userId && x.ActivityId == activityId);                


            if(attendee == null)
            {
                return Task.CompletedTask;
            }

            if (attendee.IsHost)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
