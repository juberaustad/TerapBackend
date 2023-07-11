using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.Therapists.Queries.GetAllTherapists
{
    public class GetAllTherapistQueryHandler : IRequestHandler<GetAllTherapistQuery, Response<List<Therapist>>>
    {
        private readonly ITherapistRepository _therapistRepository;
        public GetAllTherapistQueryHandler(ITherapistRepository therapistRepository)
        {
            _therapistRepository = therapistRepository;
        }

        public async Task<Response<List<Therapist>>> Handle(GetAllTherapistQuery request, CancellationToken cancellationToken)
        {
            List<Therapist> therapist = await _therapistRepository.GetAllTherapists();
            if (therapist != null)
            {
                return new Response<List<Therapist>> { Succeeded = true, Data = therapist, Errors = null };
            }
            return new Response<List<Therapist>> { Succeeded = false, Data = null, Errors = null };
        }

    }

}
