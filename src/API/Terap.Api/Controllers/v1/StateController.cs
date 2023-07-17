using MediatR;
using Microsoft.AspNetCore.Mvc;
using Terap.Application.Features.Cities.Queries.GetAllCities;
using Terap.Application.Features.Cities.Queries.GetCityById;
using Terap.Application.Features.States.Queries.GetAllStates;
using Terap.Application.Features.States.Queries.GetStateById;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class StateController : Controller
    {
        private readonly IMediator _mediator;
        public StateController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllStates")]
        public async Task<IActionResult> GetAllStates()
        {
            var respons = await _mediator.Send(new GetAllStatesQuery());
            return Ok(respons);
        }

        [HttpGet]
        [Route("GetStateById")]
        public async Task<ActionResult> GetStateById(Guid id)
        {
            Response<State> data = await _mediator.Send(new GetStateByIdQuery() { ID = id });
            return Ok(data);
        }
    }
}
