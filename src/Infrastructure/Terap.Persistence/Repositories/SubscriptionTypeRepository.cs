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
    public class SubscriptionTypeRepository : BaseRepository<SubscriptionType>, ISubscriptionTypeRepository
    {
        public SubscriptionTypeRepository(ApplicationDbContext dbContext, ILogger<SubscriptionType> logger) : base(dbContext, logger)
        {
        }
        public async Task<SubscriptionType> GetSubscriptionTypeById(Guid Id)
        {
            SubscriptionType? data = await _dbContext.SubscriptionType.FirstOrDefaultAsync(i => i.ID == Id);
            return data;
        }
    }
}
