using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Features.Features.Queries.GetFeatureById;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.Durations.Queries.GetDurationById
{
    public class GetDurationByIdQueryHandler : IRequestHandler<GetDurationByIdQuery, Response<Duration>>
    {
        private readonly IDurationRepository _durationRepository;

        public GetDurationByIdQueryHandler(IDurationRepository durationRepository)
        {
            _durationRepository = durationRepository;
        }
        public async Task<Response<Duration>> Handle(GetDurationByIdQuery request, CancellationToken cancellationToken)
        {
            Duration data = await _durationRepository.GetByIdAsync(request.ID);
            return new Response<Duration>(data);
        }
    }
}
