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

namespace Terap.Application.Features.AllBank.Queries.GetBankUsingId
{
    
    public class GetBankByIdQueryHandler : IRequestHandler<GetBankByIdQuery, Response<Bank>>
    {
        private readonly IBankRepository _bankRepository;

        public GetBankByIdQueryHandler(IBankRepository bankRepository)
        {
            _bankRepository = bankRepository;
        }
        public async Task<Response<Bank>> Handle(GetBankByIdQuery request, CancellationToken cancellationToken)
        {
            Bank data = await _bankRepository.GetByIdAsync(request.ID);
            return new Response<Bank>(data);
        }
    }
}
