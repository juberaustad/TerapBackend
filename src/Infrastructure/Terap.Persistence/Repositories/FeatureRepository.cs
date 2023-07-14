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
    public class FeatureRepository : BaseRepository<Feature>, IFeatureRepository
    {
        public FeatureRepository(ApplicationDbContext dbContext, ILogger<Feature> logger) : base(dbContext, logger)
        {
        }

        public async Task<Feature> GetFeaturesById(Guid Id)
        {
            Feature? data = await _dbContext.Feature.FirstOrDefaultAsync(i => i.ID == Id);
            return data;
        }
    }
}
