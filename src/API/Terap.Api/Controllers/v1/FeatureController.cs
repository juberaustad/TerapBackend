using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Terap.Application.Features.Features.Queries.GetFeatureById;
using Terap.Application.Features.SubscriptionTypes.Queries.GetAllSubscriptionType;
using Terap.Application.Features.SubscriptionTypes.Queries.GetSubscriptionById;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FeatureController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllFeature")]
        public async Task<IActionResult> GetAllFeature()
        {
            var data = await _mediator.Send(new GetFeatureByIdQuery());
            return Ok(data);
        }

        [HttpGet]
        [Route("GetFeatureById")]
        public async Task<IActionResult> GetFeatureById(Guid id)
        {
            Response<Feature> data = await _mediator.Send(new GetFeatureByIdQuery() { ID = id });
            return Ok(data);
        }
    }
}
