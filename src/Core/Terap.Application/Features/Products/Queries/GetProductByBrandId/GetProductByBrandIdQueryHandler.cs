using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Features.TherepistBankDetail.Queries.GetTherepistBankDetailsById;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.Products.Queries.GetProductByBrandId
{
    public class GetProductByBrandIdQueryHandler : IRequestHandler<GetProductByBrandIdQuery, Response<List<Product>>>
    {
        private readonly IProductRepository _productRepository;

        public GetProductByBrandIdQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<Response<List<Product>>> Handle(GetProductByBrandIdQuery request, CancellationToken cancellationToken)
        {
            List<Product> data = await _productRepository.GetProductByBrandId(request.BrandId);
            return new Response<List<Product>>(data);
        }
    }
}
