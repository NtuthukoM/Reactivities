﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Reactivities.API.Extensions;
using Reactivities.Application.Core;

namespace Reactivities.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController: ControllerBase
    {
        private IMediator _mediator;

        protected IMediator mediator => _mediator ??= HttpContext.RequestServices
            .GetService<IMediator>();

        protected ActionResult HandleResult<T>(Result<T> result)
        {
            if (result == null)
                return NotFound();

            if (result.IsSuccess)
            {
                return result.Value == null ? NotFound()
                    : Ok(result.Value);
            }
            return BadRequest();
        }

        protected ActionResult HandlePagedResult<T>(Result<PagedList<T>> result)
        {
            if (result == null)
                return NotFound();

            if (result.IsSuccess && result.Value != null)
            {
                Response.AddPaginationHeader(result.Value.CurrentPage, 
                    result.Value.PageSize, result.Value.TotalCount, result.Value.TotalPages);
                return Ok(result.Value);
            } 
            else if (result.IsSuccess && result.Value == null)
            {
                return NotFound();
            }
            return BadRequest();
        }
    }
}
