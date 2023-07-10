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
    public class TherapistRepository  : BaseRepository<Therapist>, ITherapistRepository
    {
        private readonly ILogger _logger;
        public TherapistRepository(ApplicationDbContext dbContext, ILogger<Therapist> logger) : base(dbContext, logger)
        {
            _logger = logger;
        }

        public async Task<List<Therapist>> GetAllTherapists()
        {
            List<Therapist> therapist = await _dbContext.Therapist.ToListAsync();
            return therapist;
        }

        public async Task<Therapist> GetTherepistById(Guid Id)
        {
            Therapist? therapist = await _dbContext.Therapist.FirstOrDefaultAsync(i => i.ID == Id);
            return therapist;
        }
    }
}
