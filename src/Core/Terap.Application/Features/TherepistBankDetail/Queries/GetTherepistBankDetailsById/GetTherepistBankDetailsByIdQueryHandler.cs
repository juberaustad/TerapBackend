using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Features.TherapistCharge.Queries.GetTherepistById;
using Terap.Application.Responses;
using Terap.Domain.Entities;


namespace Terap.Application.Features.TherepistBankDetail.Queries.GetTherepistBankDetailsById
{
    public class GetTherepistBankDetailsByIdQueryHandler : IRequestHandler<GetTherepistBankDetailsByIdQuery, Response<TherapistBankDetails>>
    {
        private readonly ITherepistBankDetailsRepository _therapistBankDetailsRepository;

        public GetTherepistBankDetailsByIdQueryHandler(ITherepistBankDetailsRepository therapistBankDetailsRepository)
        {
            _therapistBankDetailsRepository = therapistBankDetailsRepository;
        }

        public async Task<Response<TherapistBankDetails>> Handle(GetTherepistBankDetailsByIdQuery request, CancellationToken cancellationToken)
        {
            TherapistBankDetails data = await _therapistBankDetailsRepository.GetByIdAsync(request.ID);
            return new Response<TherapistBankDetails>(data);
        }
    }
}
