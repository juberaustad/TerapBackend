using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Features.DocumentTypes.Queries.GetDocumentTypeById;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.Brands.Queries.GetBrandById
{
    public class GetBrandByIdQueryHandler : IRequestHandler<GetBrandByIdQuery, Response<Brand>>
    {
        private readonly IBrandRepository _brandRepository;
        public GetBrandByIdQueryHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<Response<Brand>> Handle(GetBrandByIdQuery request, CancellationToken cancellationToken)
        {
            Brand data = await _brandRepository.GetByIdAsync(request.ID);
            return new Response<Brand>(data);
        }
    }
}
