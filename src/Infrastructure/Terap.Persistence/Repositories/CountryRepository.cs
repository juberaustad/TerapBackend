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
    public class CountryRepository /*: BaseRepository<Country>, ICountryRepository*/
    {
        //ILogger _logger;
        //public CountryRepository(ApplicationDbContext dbContext, ILogger<Country> logger) : base(dbContext, logger)
        //{
        //}

        //public async Task<Country> GetCountryById(Guid Id)
        //{
        //    Country? country = await _dbContext.Country.FirstOrDefaultAsync(i => i.ID == Id);
        //    return country;
        //}
    }
}
