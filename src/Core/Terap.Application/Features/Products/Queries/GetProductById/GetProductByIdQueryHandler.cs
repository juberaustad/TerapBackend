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

namespace Terap.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Response<Product>>
    {
        private readonly IProductRepository _productRepository;

        public GetProductByIdQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<Response<Product>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            Product data = await _productRepository.GetByIdAsync(request.ID);
            return new Response<Product>(data);
        }
    }
}
