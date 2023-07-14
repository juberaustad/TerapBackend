using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Terap.Application.Features.Durations.Queries.GetAllDuration;
using Terap.Application.Features.Durations.Queries.GetDurationById;
using Terap.Application.Features.Features.Queries.GetFeatureById;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class DurationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DurationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllDuration")]
        public async Task<IActionResult> GetAllDuration()
        {
            var data = await _mediator.Send(new GetAllDurationQuery());
            return Ok(data);
        }

        [HttpGet]
        [Route("GetDurationById")]
        public async Task<IActionResult> GetFeatureById(Guid id)
        {
            Response<Duration> data = await _mediator.Send(new GetDurationByIdQuery() { ID = id });
            return Ok(data);
        }
    }
}
