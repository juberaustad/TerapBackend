using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Features.TherepistBankDetail.Queries.GetTherepistBankDetailsById;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.Therapists.Queries.GetTherapistById
{
    public class GetTherapistByIdQueryHandler : IRequestHandler<GetTherapistByIdQuery, Response<Therapist>>
    {
        private readonly ITherapistRepository _therapistRepository;
        public GetTherapistByIdQueryHandler(ITherapistRepository therapistRepository)
        {
            _therapistRepository = therapistRepository;
        }

        public async Task<Response<Therapist>> Handle(GetTherapistByIdQuery request, CancellationToken cancellationToken)
        {
            Therapist data = await _therapistRepository.GetByIdAsync(request.ID);
            return new Response<Therapist>(data);
        }
    }
}
