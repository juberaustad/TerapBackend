using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Features.Features.Queries.GetAllFeature;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.Durations.Queries.GetAllDuration
{
    public class GetAllDurationQueryHandler : IRequestHandler<GetAllDurationQuery, Response<List<Duration>>>
    {
        private readonly IDurationRepository _durationRepository;

        public GetAllDurationQueryHandler(IDurationRepository durationRepository)
        {
            _durationRepository = durationRepository;
        }
        public async Task<Response<List<Duration>>> Handle(GetAllDurationQuery request, CancellationToken cancellationToken)
        {
            List<Duration> duration = (List<Duration>)await _durationRepository.ListAllAsync();
            if (duration != null)
            {
                return new Response<List<Duration>> { Succeeded = true, Data = duration, Errors = null };
            }
            return new Response<List<Duration>> { Succeeded = false, Data = null, Errors = null };
        }
    }
}
