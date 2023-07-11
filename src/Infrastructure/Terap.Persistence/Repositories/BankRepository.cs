using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Domain.Entities;

namespace Terap.Persistence.Repositories
{
    public class BankRepository : BaseRepository<Bank>, IBankRepository
    {
        private readonly ILogger _logger;

        public BankRepository(ApplicationDbContext dbContext, ILogger<Bank> logger) : base(dbContext, logger)
        {
            
        }
        public async Task<Bank> GetAllBankList(Guid Id)
        {
            Bank? data = await _dbContext.Bank.FirstOrDefaultAsync(i => i.ID == Id);
            return data;
        }
    }
}
