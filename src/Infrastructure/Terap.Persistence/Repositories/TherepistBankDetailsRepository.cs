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
    public class TherepistBankDetailsRepository : BaseRepository<TherapistBankDetails>, ITherepistBankDetailsRepository
    {
        private readonly ILogger _logger;
        public TherepistBankDetailsRepository(ApplicationDbContext dbContext, ILogger<TherapistBankDetails> logger) : base(dbContext, logger)
        {

        }
        public async Task<TherapistBankDetails> GetTherepistBankDetailsById(Guid Id)
        {
            TherapistBankDetails? data = await _dbContext.TherapistBankDetails.FirstOrDefaultAsync(i => i.ID == Id);
            return data;
        }
    }
}
