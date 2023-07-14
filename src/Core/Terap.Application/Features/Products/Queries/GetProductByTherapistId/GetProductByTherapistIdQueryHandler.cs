using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Features.Products.Queries.GetProductByBrandId;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.Products.Queries.GetProductByTherapistId
{
    public class GetProductByTherapistIdQueryHandler : IRequestHandler<GetProductByTherapistIdQuery, Response<List<Product>>>
    {
        private readonly IProductRepository _productRepository;

        public GetProductByTherapistIdQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<Response<List<Product>>> Handle(GetProductByTherapistIdQuery request, CancellationToken cancellationToken)
        {
            List<Product> data = await _productRepository.GetProductByTherapistId(request.TherapistId);
            return new Response<List<Product>>(data);
        }
    }
}
