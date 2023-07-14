using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Terap.Application.Features.Events.Commands.CreateEvent;
using Terap.Application.Features.TherapistCharge.Commands.AddTherepistCharges;
using Terap.Application.Features.TherapistCharge.Queries.GetAllTherapistCharges;
using Terap.Application.Features.TherapistCharge.Queries.GetTherepistById;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class TherapistChargesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TherapistChargesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("AllTherapistCharges")]
        public async Task<IActionResult> GetAllTherapistCharges()
        {
            var respons = await _mediator.Send(new GetAllTherapistChargesQuery());
            return Ok(respons);
        }
        //[HttpPost(Name = "AddTherepistCharges")]
        //public async Task<ActionResult> Create([FromBody] AddTherepistChargesCommand addTherepistChargesCommand)
        //{
        //    var id = await _mediator.Send(addTherepistChargesCommand);
        //    return Ok(id);
        //}

        [HttpGet]
        [Route("GetTherapistChargesById")]
        public async Task<ActionResult> GetChargesById(Guid id)
        {
            Response<TherapistCharges> data = await _mediator.Send(new GetTherepistChargesByIdQuery() { ID = id});
            return Ok(data);
        }
    }
}
