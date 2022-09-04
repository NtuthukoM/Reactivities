using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Activities;
using Reactivities.Domain;
using Reactivities.Persistance;

namespace Reactivities.API.Controllers
{
    [AllowAnonymous]
    public class ActivitiesController:BaseApiController
    {

        [HttpGet]
        public async Task<IActionResult> GetActivities()
        {
            var result = await mediator.Send(new List.Query());
            return HandleResult(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetActivity(int id)
        {
            var result = await mediator.Send(new Details.Query() { Id = id });
            return HandleResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Activity activity)
        {
            var result = await mediator.Send(new Create.Command() { Activity = activity });
            return HandleResult(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Activity activity)
        {
            activity.Id = id;
            var result = await mediator.Send(new Edit.Command() { Activity = activity });
            return HandleResult(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await mediator.Send(new Delete.Command() { Id = id });
            return HandleResult(result);
        }
    }
}
