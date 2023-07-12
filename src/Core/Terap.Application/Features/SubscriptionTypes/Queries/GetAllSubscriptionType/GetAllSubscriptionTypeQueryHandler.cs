using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Features.TherepistBankDetail.Queries.GetAllTherepistBankDetails;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.SubscriptionTypes.Queries.GetAllSubscriptionType
{
    public class GetAllSubscriptionTypeQueryHandler : IRequestHandler<GetAllSubscriptionTypeQuery, Response<List<SubscriptionType>>>
    {
        private readonly ISubscriptionTypeRepository _subscriptionTypeRepository;

        public GetAllSubscriptionTypeQueryHandler(ISubscriptionTypeRepository subscriptionTypeRepository)
        {
            _subscriptionTypeRepository = subscriptionTypeRepository;
        }
        public async Task<Response<List<SubscriptionType>>> Handle(GetAllSubscriptionTypeQuery request, CancellationToken cancellationToken)
        {
            List<SubscriptionType> subscription = (List<SubscriptionType>)await _subscriptionTypeRepository.ListAllAsync();
            if (subscription != null)
            {
                return new Response<List<SubscriptionType>> { Succeeded = true, Data = subscription, Errors = null };
            }
            return new Response<List<SubscriptionType>> { Succeeded = false, Data = null, Errors = null };
        }
    }
}
