using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.TherepistBankDetail.Queries.GetAllTherepistBankDetails
{
    public class TherepistBankDetailsQueryHandler : IRequestHandler<TherepistBankDetailsQuery, Response<List<TherapistBankDetails
>>>
    {
        private readonly ITherepistBankDetailsRepository _therepistBankDetailsRepository;
        public TherepistBankDetailsQueryHandler(ITherepistBankDetailsRepository therapistChargesRepository)
        {
            _therepistBankDetailsRepository = therapistChargesRepository;
        }
        public async Task<Response<List<TherapistBankDetails>>> Handle(TherepistBankDetailsQuery request, CancellationToken cancellationToken)
        {
            List<TherapistBankDetails> charges = (List<TherapistBankDetails>)await _therepistBankDetailsRepository.ListAllAsync();
            if (charges != null)
            {
                return new Response<List<TherapistBankDetails>> { Succeeded = true, Data = charges, Errors = null };
            }
            return new Response<List<TherapistBankDetails>> { Succeeded = false, Data = null, Errors = null };
        }
    }
}
