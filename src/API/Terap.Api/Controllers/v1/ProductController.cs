using MediatR;

using Microsoft.AspNetCore.Mvc;
using Terap.Application.Features.Products.Queries.GetAllProducts;
using Terap.Application.Features.Products.Queries.GetProductByBrandId;
using Terap.Application.Features.Products.Queries.GetProductById;
using Terap.Application.Features.Products.Queries.GetProductByTherapistId;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [Route("GetAllProduct")]
        public async Task<IActionResult> GetAllProducts()
        {
            var data = await _mediator.Send(new GetAllProductQuery());
            return Ok(data);
        }

        [HttpGet]
        [Route("GetProductById")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            Response<Product> data = await _mediator.Send(new GetProductByIdQuery() { ID = id });
            return Ok(data);
        }

        [HttpGet]
        [Route("GetProductByBrandId")]
        public async Task<IActionResult> GetProductByBrandId(Guid brandId)
        {
            Response<List<Product>> data = await _mediator.Send(new GetProductByBrandIdQuery() { BrandId = brandId });
            return Ok(data);
        }

        [HttpGet]
        [Route("GetProductByTherapistId")]
        public async Task<IActionResult> GetProductByTherapistId(Guid therapistId)
        {
            Response<List<Product>> data = await _mediator.Send(new GetProductByTherapistIdQuery() { TherapistId = therapistId });
            return Ok(data);
        }
    }
}
