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

namespace Terap.Application.Features.AllBank.Queries.GetAllBankQueries
{
    public class GetAllBankQueryHandler : IRequestHandler<AllBankQuery, Response<List<Bank>>>
    {
        public readonly IBankRepository _bankRepository;
        public GetAllBankQueryHandler(IBankRepository bankRepository)
        {
            _bankRepository = bankRepository;
        }
        public async Task<Response<List<Bank>>> Handle(AllBankQuery request, CancellationToken cancellationToken)
        {
            List<Bank> bank = (List<Bank>)await _bankRepository.ListAllAsync();
            if (bank != null)
            {
                return new Response<List<Bank>> { Succeeded = true, Data = bank, Errors = null };
            }
            return new Response<List<Bank>> { Succeeded = false, Data = null, Errors = null };
        }
    }
}
