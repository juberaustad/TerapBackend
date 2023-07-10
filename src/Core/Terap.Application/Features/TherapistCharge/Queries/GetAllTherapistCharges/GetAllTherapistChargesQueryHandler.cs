using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.TherapistCharge.Queries.GetAllTherapistCharges
{
    public class GetAllTherapistChargesQueryHandler : IRequestHandler<GetAllTherapistChargesQuery, Response<List<TherapistCharges>>>
    {

        private readonly ITherapistChargesRepository _chargesRepository;
        public GetAllTherapistChargesQueryHandler(ITherapistChargesRepository chargesRepository)
        {
            _chargesRepository = chargesRepository;
        }

        public async Task<Response<List<TherapistCharges>>> Handle(GetAllTherapistChargesQuery request, CancellationToken cancellationToken)
        {
            List<TherapistCharges> charges = await _chargesRepository.GetAllTherapistCharges();
            if(charges != null)
            {
                return new Response<List<TherapistCharges>> { Succeeded = true, Data = charges, Errors = null };
            }
            return new Response<List<TherapistCharges>> { Succeeded = false, Data = null, Errors = null };
        }
    }
}
