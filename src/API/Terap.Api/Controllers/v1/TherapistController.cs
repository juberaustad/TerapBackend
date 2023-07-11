using MediatR;
using Microsoft.AspNetCore.Mvc;
using Terap.Application.Features.Therapists.Queries;
using Terap.Application.Features.Therapists.Queries.GetAllTherapists;
using Terap.Application.Features.Therapists.Queries.GetTherapistById;
using Terap.Application.Features.TherepistBankDetail.Queries.GetTherepistBankDetailsById;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class TherapistController : Controller
    {
        private readonly IMediator _mediator;
        public TherapistController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllTherapists")]
        public async Task<IActionResult> GetAllTherapists()
        {
            var respons = await _mediator.Send(new GetAllTherapistQuery());
            return Ok(respons);
        }

        [HttpGet]
        [Route("GetTherapistById")]
        public async Task<ActionResult> GetTherapistById(Guid id)
        {
            Response<Therapist> data = await _mediator.Send(new GetTherapistByIdQuery() { ID = id });
            return Ok(data);
        }
    }
}
