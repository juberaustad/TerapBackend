using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Terap.Application.Features.TherapistCharge.Queries.GetAllTherapistCharges;
using Terap.Application.Features.TherapistCharge.Queries.GetTherepistById;
using Terap.Application.Features.TherepistBankDetail.Queries.GetAllTherepistBankDetails;
using Terap.Application.Features.TherepistBankDetail.Queries.GetTherepistBankDetailsById;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class TherepistBankDetailsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TherepistBankDetailsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [Route("GetAllTherapistBankDetails")]
        public async Task<IActionResult> GetAllTherapistBankDetails()
        {
            var respons = await _mediator.Send(new TherepistBankDetailsQuery());
            return Ok(respons);
        }


        [HttpGet]
        public async Task<ActionResult> GetTherapistBankDetailsById(Guid id)
        {
            Response<TherapistBankDetails> data = await _mediator.Send(new GetTherepistBankDetailsByIdQuery() { ID = id });
            return Ok(data);
        }
    }
}
