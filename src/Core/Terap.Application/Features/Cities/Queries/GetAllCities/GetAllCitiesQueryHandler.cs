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

namespace Terap.Application.Features.Cities.Queries.GetAllCities
{
    public class GetAllCitiesQueryHandler : IRequestHandler<GetAllCitiesQuery, Response<List<City>>>

    {
        private readonly ICityRepository _cityRepository;
        public GetAllCitiesQueryHandler(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public async Task<Response<List<City>>> Handle(GetAllCitiesQuery request, CancellationToken cancellationToken)
        {
            List<City> cities = await _cityRepository.GetAllCities();
            if (cities != null)
            {
                return new Response<List<City>> { Succeeded = true, Data = cities, Errors = null };
            }
            return new Response<List<City>> { Succeeded = false, Data = null, Errors = null };
        }

    }

}
