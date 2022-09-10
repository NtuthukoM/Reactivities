using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reactivities.Application.Profiles;

namespace Reactivities.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilesController : BaseApiController
    {
        [HttpGet("{username}")]
        public async Task<IActionResult> GetProfile(string username)
        {
            var result = await mediator.Send(new Details.Query() { Username = username });
            return HandleResult(result);
        }
    }
}
