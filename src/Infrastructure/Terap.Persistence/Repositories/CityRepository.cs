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
    public class CityRepository : BaseRepository<City>, ICityRepository
    {
        private readonly ILogger _logger;

        public CityRepository(ApplicationDbContext dbContext, ILogger<City> logger) : base(dbContext, logger)
        {
            _logger = logger;
        }

        public async Task<List<City>> GetAllCities()
        {
            List<City> cities = await _dbContext.City.ToListAsync();
            return cities;
        }

        public async Task<City> GetCityById(Guid Id)
        {
            City? city = await _dbContext.City.FirstOrDefaultAsync(i => i.ID == Id);
            return city;
        }
    }
}
