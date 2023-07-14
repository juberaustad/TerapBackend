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
    public class DurationRepository : BaseRepository<Duration>, IDurationRepository
    {
        ILogger _logger;
        public DurationRepository(ApplicationDbContext dbContext, ILogger<Duration> logger) : base(dbContext, logger)
        {
        }

        public async Task<Duration> GetDurationById(Guid Id)
        {
            Duration? duration = await _dbContext.Duration.FirstOrDefaultAsync(i => i.ID == Id);
            return duration;
        }
    }
}
