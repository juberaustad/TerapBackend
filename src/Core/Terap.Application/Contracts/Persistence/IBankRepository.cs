using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Domain.Entities;

namespace Terap.Application.Contracts.Persistence
{
    public interface IBankRepository: IAsyncRepository<Bank>
    {
        public Task<Bank> GetAllBankList(Guid Id);
    }
}
