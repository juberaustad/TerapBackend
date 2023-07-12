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

namespace Terap.Application.Features.SubscriptionTypes.Queries.GetSubscriptionById
{
    public class GetSubscriptionByIdQueryHandler : IRequestHandler<GetSubscriptionByIdQuery, Response<SubscriptionType>>
    {
        private readonly ISubscriptionTypeRepository   _subscriptionTypeRepository;

        public GetSubscriptionByIdQueryHandler(ISubscriptionTypeRepository subscriptionTypeRepository)
        {
            _subscriptionTypeRepository = subscriptionTypeRepository;
        }
        public async Task<Response<SubscriptionType>> Handle(GetSubscriptionByIdQuery request, CancellationToken cancellationToken)
        {
            SubscriptionType data = await _subscriptionTypeRepository.GetByIdAsync(request.ID);
            return new Response<SubscriptionType>(data);
        }
    }
}
