using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Activities;
using Reactivities.Domain;
using Reactivities.Persistance;

namespace Reactivities.API.Controllers
{
    public class ActivitiesController:BaseApiController
    {

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await mediator.Send(new List.Query());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(int id)
        {
            return await mediator.Send(new Details.Query() { Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> Create(Activity activity)
        {
            var result = await mediator.Send(new Create.Command() { Activity = activity });
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Activity activity)
        {
            activity.Id = id;
            var result = await mediator.Send(new Edit.Command() { Activity = activity });
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await mediator.Send(new Delete.Command() { Id = id });
            return Ok(result);
        }
    }
}
