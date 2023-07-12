using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Terap.Application.Features.SubscriptionFeatures.Queries.GetAllSubscriptionFeature;
using Terap.Application.Features.SubscriptionFeatures.Queries.GetSubscriptionFeatureById;
using Terap.Application.Features.SubscriptionTypes.Queries.GetAllSubscriptionType;
using Terap.Application.Features.SubscriptionTypes.Queries.GetSubscriptionById;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class SubscriptionFeatureController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SubscriptionFeatureController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllSubscriptionFeature")]
        public async Task<IActionResult> GetAllSubscriptionFeature()
        {
            var data = await _mediator.Send(new GetAllSubscriptionFeatureQuery());
            return Ok(data);
        }

        [HttpGet]
        [Route("GetSubscriptionFeatureById")]
        public async Task<IActionResult> GetSubscriptionFeatureById(Guid id)
        {
            Response<SubscriptionFeature> data = await _mediator.Send(new GetSubscriptionFeatureByIdQuery() { ID = id });
            return Ok(data);
        }
    }
}
