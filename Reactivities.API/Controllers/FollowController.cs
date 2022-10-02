using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reactivities.Application.Followers;

namespace Reactivities.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FollowController : BaseApiController
    {
        [HttpPost("{username}")]
        public async Task<IActionResult> Follow(string username)
        {
            var request = new FollowToggle.Command
            {
                TargetUsername = username
            };
            var result = await mediator.Send(request);
            return HandleResult(result);
        }

        [HttpGet("{username}")]
        public async Task<IActionResult> GetFollowings(string username, string predicate)
        {
            var request = new List.Query
            {
                Username = username,
                Predicate = predicate
            };
            var result = await mediator.Send(request);
            return HandleResult(result);
        }
    }
}
