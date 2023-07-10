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

namespace Terap.Application.Features.TherapistCharge.Queries.GetTherepistById
{
    public class GetTherepistChargesByIdQueryHandler : IRequestHandler<GetTherepistChargesByIdQuery, Response<TherapistCharges>>
    {
        private readonly ITherapistChargesRepository _chargesRepository;

        public GetTherepistChargesByIdQueryHandler(ITherapistChargesRepository chargesRepository)
        {
            _chargesRepository = chargesRepository;
        }

        public async Task<Response<TherapistCharges>> Handle(GetTherepistChargesByIdQuery request, CancellationToken cancellationToken)
        {
            TherapistCharges data = await _chargesRepository.GetTherepistChargesById(request.ID);
            return new Response<TherapistCharges>(data);
        }
    }
}
