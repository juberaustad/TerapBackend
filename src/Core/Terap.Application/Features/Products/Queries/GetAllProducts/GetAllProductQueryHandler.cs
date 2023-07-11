using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Features.TherapistCharge.Queries.GetAllTherapistCharges;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, Response<List<Product>>>
    {
        private readonly IProductRepository _productRepository;
        public GetAllProductQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<Response<List<Product>>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            List<Product> product = (List<Product>) await _productRepository.ListAllAsync();
            if (product != null)
            {
                return new Response<List<Product>> { Succeeded = true, Data = product, Errors = null };
            }
            return new Response<List<Product>> { Succeeded = false, Data = null, Errors = null };
        }
    }
}
