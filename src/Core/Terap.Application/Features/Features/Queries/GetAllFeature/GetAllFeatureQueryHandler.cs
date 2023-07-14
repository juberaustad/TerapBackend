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

namespace Terap.Application.Features.Features.Queries.GetAllFeature
{
    internal class GetAllFeatureQueryHandler : IRequestHandler<GetAllFeatureQuery, Response<List<Feature>>>
    {
        private readonly IFeatureRepository _featureRepository;

        public GetAllFeatureQueryHandler(IFeatureRepository featureRepository)
        {
            _featureRepository = featureRepository;
        }
        public async Task<Response<List<Feature>>> Handle(GetAllFeatureQuery request, CancellationToken cancellationToken)
        {
            List<Feature> feature = (List<Feature>)await _featureRepository.ListAllAsync();
            if (feature != null)
            {
                return new Response<List<Feature>> { Succeeded = true, Data = feature, Errors = null };
            }
            return new Response<List<Feature>> { Succeeded = false, Data = null, Errors = null };
        }
    }
}
