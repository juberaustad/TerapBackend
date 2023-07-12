using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Features.DocumentTypes.Queries.GetAllDocumentTypes;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.Brands.Queries.GetAllBrands
{
    public class GetAllBrandQueryHandler : IRequestHandler<GetAllBrandQuery, Response<List<Brand>>>

    {
        private readonly IBrandRepository _brandRepository;
        public GetAllBrandQueryHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<Response<List<Brand>>> Handle(GetAllBrandQuery request, CancellationToken cancellationToken)
        {
            List<Brand> brand = await _brandRepository.GetAllBrands();
            if (brand != null)
            {
                return new Response<List<Brand>> { Succeeded = true, Data = brand, Errors = null };
            }
            return new Response<List<Brand>> { Succeeded = false, Data = null, Errors = null };
        }

    }
}
