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
    public class BrandRepository : BaseRepository<Brand>, IBrandRepository
    {
        private readonly ILogger _logger;

        public BrandRepository(ApplicationDbContext dbContext, ILogger<Brand> logger) : base(dbContext, logger)
        {
            _logger = logger;
        }

        public async Task<List<Brand>> GetAllBrands()
        {
            List<Brand> brands = await _dbContext.Brand.ToListAsync();
            return brands;
        }

        public async Task<Brand> GetBrandById(Guid Id)
        {
            Brand? brand = await _dbContext.Brand.FirstOrDefaultAsync(i => i.ID == Id);
            return brand;
        }
    }
}
