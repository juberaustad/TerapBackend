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

namespace Terap.Application.Features.Cities.Queries.GetCityById
{
    public class GetCityByIdQueryHandler : IRequestHandler<GetCityByIdQuery, Response<City>>
    {
        private readonly ICityRepository _cityRepository;
        public GetCityByIdQueryHandler(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public async Task<Response<City>> Handle(GetCityByIdQuery request, CancellationToken cancellationToken)
        {
            City data = await _cityRepository.GetByIdAsync(request.ID);
            return new Response<City>(data);
        }
    }

}
