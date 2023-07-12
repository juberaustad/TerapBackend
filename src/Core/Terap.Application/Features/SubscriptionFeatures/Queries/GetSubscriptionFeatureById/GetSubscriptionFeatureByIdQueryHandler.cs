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

namespace Terap.Application.Features.SubscriptionFeatures.Queries.GetSubscriptionFeatureById
{
    public class GetSubscriptionFeatureByIdQueryHandler : IRequestHandler<GetSubscriptionFeatureByIdQuery, Response<SubscriptionFeature>>
    {
        private readonly ISubscriptionFeatureRepository _subscriptionFeatureRepository;

        public GetSubscriptionFeatureByIdQueryHandler(ISubscriptionFeatureRepository subscriptionFeatureRepository)
        {
            _subscriptionFeatureRepository = subscriptionFeatureRepository;
        }
        public async Task<Response<SubscriptionFeature>> Handle(GetSubscriptionFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            SubscriptionFeature data = await _subscriptionFeatureRepository.GetByIdAsync(request.ID);
            return new Response<SubscriptionFeature>(data);
        }
    }
}
