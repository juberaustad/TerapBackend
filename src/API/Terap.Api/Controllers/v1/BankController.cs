using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Terap.Application.Features.AllBank.Queries.GetAllBankQueries;
using Terap.Application.Features.AllBank.Queries.GetBankUsingId;
using Terap.Application.Features.TherepistBankDetail.Queries.GetAllTherepistBankDetails;
using Terap.Application.Features.TherepistBankDetail.Queries.GetTherepistBankDetailsById;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BankController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [Route("GetAllBank")]
        public async Task<IActionResult> GetAllBank()
        {
            var respons = await _mediator.Send(new AllBankQuery());
            return Ok(respons);
        }

        [HttpGet]
        
        public async Task<ActionResult> GetBankById(Guid id)
        {
            Response<Bank> data = await _mediator.Send(new GetBankByIdQuery() { ID = id });
            return Ok(data);
        }
    }
}
