using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reactivities.Application.Photos;

namespace Reactivities.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotosController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromForm]Add.Command command)
        {
            var result = await mediator.Send(command);
            return HandleResult(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await mediator.Send(new Delete.Command() { Id = id });
            return HandleResult(result);
        }

        [HttpPost("{id}/setMain")]
        public async Task<IActionResult> SetMain(string id)
        {
            var result = await mediator.Send(new SetMain.Command() { Id = id });
            return HandleResult(result);
        }
    }
}
