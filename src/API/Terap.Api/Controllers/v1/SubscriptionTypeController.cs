using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Terap.Application.Features.Products.Queries.GetAllProducts;
using Terap.Application.Features.SubscriptionTypes.Queries.GetAllSubscriptionType;
using Terap.Application.Features.SubscriptionTypes.Queries.GetSubscriptionById;
using Terap.Application.Features.TherepistBankDetail.Queries.GetTherepistBankDetailsById;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class SubscriptionTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SubscriptionTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllSubscriptionType")]
        public async Task<IActionResult> GetAllSubscriptionType()
        {
            var data = await _mediator.Send(new GetAllSubscriptionTypeQuery());
            return Ok(data);
        }

        [HttpGet]
        [Route("GetSubscriptionTypeById")]
        public async Task<IActionResult> GetSubscriptionById(Guid id)
        {
            Response<SubscriptionType> data = await _mediator.Send(new GetSubscriptionByIdQuery() { ID = id });
            return Ok(data);
        }
    }
}
