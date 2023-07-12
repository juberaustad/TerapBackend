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
    public class SubscriptionFeaturesRepository : BaseRepository<SubscriptionFeature>, ISubscriptionFeatureRepository
    {
        public SubscriptionFeaturesRepository(ApplicationDbContext dbContext, ILogger<SubscriptionFeature> logger) : base(dbContext, logger)
        {
        }

        public async Task<SubscriptionFeature> GetSubscriptionFeatureById(Guid Id)
        {
            SubscriptionFeature? data = await _dbContext.SubscriptionFeature.FirstOrDefaultAsync(i => i.ID == Id);
            return data;
        }
    }
}
