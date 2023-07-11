using MediatR;
using Microsoft.AspNetCore.Mvc;
using Terap.Application.Features.Brands.Queries.GetAllBrands;
using Terap.Application.Features.Brands.Queries.GetBrandById;
using Terap.Application.Features.Videos.Queries.GetAllVideos;
using Terap.Application.Features.Videos.Queries.GetVideoByTherapistId;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class BrandController : Controller
    {
        private readonly IMediator _mediator;
        public BrandController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllBrands")]
        public async Task<IActionResult> GetAllBrands()
        {
            var respons = await _mediator.Send(new GetAllBrandQuery());
            return Ok(respons);
        }

        [HttpGet]
        [Route("GetBrandById")]
        public async Task<ActionResult> GetBrandById(Guid id)
        {
            Response<Brand> data = await _mediator.Send(new GetBrandByIdQuery() { ID = id });
            return Ok(data);
        }
    }
}
