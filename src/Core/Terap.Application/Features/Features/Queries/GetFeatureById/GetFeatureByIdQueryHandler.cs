using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Features.SubscriptionTypes.Queries.GetSubscriptionById;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.Features.Queries.GetFeatureById
{
    public class GetFeatureByIdQueryHandler : IRequestHandler<GetFeatureByIdQuery, Response<Feature>>
    {
        private readonly IFeatureRepository _featureRepository;

        public GetFeatureByIdQueryHandler(IFeatureRepository featureRepository)
        {
            _featureRepository = featureRepository;   
        }
        public async Task<Response<Feature>> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            Feature data = await _featureRepository.GetByIdAsync(request.ID);
            return new Response<Feature>(data);
        }
    }
}
