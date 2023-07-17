using MediatR;
using Microsoft.AspNetCore.Mvc;
using Terap.Application.Features.Cities.Queries.GetAllCities;
using Terap.Application.Features.Cities.Queries.GetCityById;
using Terap.Application.Features.DocumentTypes.Queries.GetAllDocumentTypes;
using Terap.Application.Features.DocumentTypes.Queries.GetDocumentTypeById;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class CityController : Controller
    {
        private readonly IMediator _mediator;
        public CityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllCities")]
        public async Task<IActionResult> GetAllCities()
        {
            var respons = await _mediator.Send(new GetAllCitiesQuery());
            return Ok(respons);
        }

        [HttpGet]
        [Route("GetCityById")]
        public async Task<ActionResult> GetCityById(Guid id)
        {
            Response<City> data = await _mediator.Send(new GetCityByIdQuery() { ID = id });
            return Ok(data);
        }
    }
}
