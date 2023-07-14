using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Terap.Application.Features.Countries.Queries.GetAllCountry;
using Terap.Application.Features.Durations.Queries.GetAllDuration;

namespace Terap.Api.Controllers.v1
{
    //[ApiVersion("1")]
    //[Route("api/v{version:apiVersion}/[controller]")]
    //[ApiController]
    //public class CountryController : ControllerBase
    //{
    //    private readonly IMediator _mediator;

    //    public CountryController(IMediator mediator)
    //    {
    //        _mediator = mediator;
    //    }

    //    [HttpGet]
    //    [Route("GetAllCountry")]
    //    public async Task<IActionResult> GetAllCountry()
    //    {
    //        var data = await _mediator.Send(new GetAllCountryQuery());
    //        return Ok(data);
    //    }
    //}
}
