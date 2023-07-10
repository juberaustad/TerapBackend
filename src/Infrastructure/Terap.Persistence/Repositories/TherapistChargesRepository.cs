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
    public class TherapistChargesRepository : BaseRepository<TherapistCharges>, ITherapistChargesRepository
    {
        private readonly ILogger _logger;
        public TherapistChargesRepository(ApplicationDbContext dbContext, ILogger<TherapistCharges> logger) : base(dbContext, logger)
        {
        }

        public async Task<List<TherapistCharges>> GetAllTherapistCharges()
        {
            List<TherapistCharges> data = await _dbContext.TherapistCharges.ToListAsync();
            return data;
        }
        public async Task<TherapistCharges> AddTherepistCharges(TherapistCharges @Charges)
        {
            _dbContext.BeginTransaction();
            await _dbContext.Set<TherapistCharges>().AddAsync(@Charges);
            await _dbContext.SaveChangesAsync();
            _dbContext.Commit();
            return @Charges;
        }

        public async Task<TherapistCharges> GetTherepistChargesById(Guid Id)
        {
            TherapistCharges? data =await _dbContext.TherapistCharges.FirstOrDefaultAsync(i=>i.ID == Id);
            return data;
        }
    }
}
