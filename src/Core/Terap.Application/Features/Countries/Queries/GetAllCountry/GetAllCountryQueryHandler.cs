using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Features.Durations.Queries.GetAllDuration;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.Countries.Queries.GetAllCountry
{
    public class GetAllCountryQueryHandler /*: IRequestHandler<GetAllCountryQuery, Response<List<Country>>>*/
    {
        private readonly ICountryRepository _countryRepository;

        public GetAllCountryQueryHandler(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        //public async Task<Response<List<Country>>> Handle(GetAllCountryQuery request, CancellationToken cancellationToken)
        //{
        //    //List<Country> countries = (List<Country>)await _countryRepository.ListAllAsync();
            
            
        //    //if (countries != null)
        //    //{
        //    //    return new Response<List<Country>> { Succeeded = true, Data = countries, Errors = null };
        //    //}
        //    //return new Response<List<Country>> { Succeeded = false, Data = null, Errors = null };
        //}
    }
}
