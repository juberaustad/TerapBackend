using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Terap.Application.Features.Events.Queries.GetEventsList;
using Terap.Application.Features.Products.Queries.GetAllProducts;
using Terap.Application.Features.Products.Queries.GetProductByBrandId;
using Terap.Application.Features.Products.Queries.GetProductById;
using Terap.Application.Features.TherepistBankDetail.Queries.GetTherepistBankDetailsById;
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
        public async Task<IActionResult> GetProductById(Guid id)
        {
            Response<Product> data = await _mediator.Send(new GetProductByIdQuery() { ID = id });
            return Ok(data);
        }

        [HttpGet]
        [Route("GetProductByBrandId")]
        public async Task<IActionResult> GetProductByBrandId(Guid brandId)
        {
            Response<Product> data = await _mediator.Send(new GetProductByBrandIdQuery() { BrandId = brandId });
            return Ok(data);
        }
    }
}
