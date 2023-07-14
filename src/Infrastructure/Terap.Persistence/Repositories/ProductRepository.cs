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
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly ILogger _logger;

        public ProductRepository(ApplicationDbContext dbContext, ILogger<Product> logger) : base(dbContext, logger)
        {
           
        }
        public async Task<Product> GetProductById(Guid Id)
        {
            Product? data = await _dbContext.Products.FirstOrDefaultAsync(i => i.ID == Id);
            return data;
        } 
        public async Task<List<Product>> GetProductByBrandId(Guid BrandId)
        {
            List<Product> data = await _dbContext.Products.Where(z=>z.BrandId == BrandId).Include(z=>z.Brand).ToListAsync();
            return data;
        }

        public async Task<List<Product>> GetProductByTherapistId(Guid TherapistId)
        {
            List<Product> data = await _dbContext.Products.Where(z => z.TherapistId == TherapistId).Include(z => z.Brand).ToListAsync();
            return data;
        }

    }
}
