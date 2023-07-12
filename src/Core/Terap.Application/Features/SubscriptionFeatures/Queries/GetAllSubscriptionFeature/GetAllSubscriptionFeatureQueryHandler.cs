using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Features.SubscriptionTypes.Queries.GetAllSubscriptionType;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.SubscriptionFeatures.Queries.GetAllSubscriptionFeature
{
    public class GetAllSubscriptionFeatureQueryHandler : IRequestHandler<GetAllSubscriptionFeatureQuery, Response<List<SubscriptionFeature>>>
    {
        private readonly ISubscriptionFeatureRepository _subscriptionFeatureRepository;

        public GetAllSubscriptionFeatureQueryHandler(ISubscriptionFeatureRepository subscriptionFeatureRepository)
        {
            _subscriptionFeatureRepository = subscriptionFeatureRepository;
        }
        public async Task<Response<List<SubscriptionFeature>>> Handle(GetAllSubscriptionFeatureQuery request, CancellationToken cancellationToken)
        {
            List<SubscriptionFeature> subscriptionFeature = (List<SubscriptionFeature>)await _subscriptionFeatureRepository.ListAllAsync();
            if (subscriptionFeature != null)
            {
                return new Response<List<SubscriptionFeature>> { Succeeded = true, Data = subscriptionFeature, Errors = null };
            }
            return new Response<List<SubscriptionFeature>> { Succeeded = false, Data = null, Errors = null };
        }
    }
}
