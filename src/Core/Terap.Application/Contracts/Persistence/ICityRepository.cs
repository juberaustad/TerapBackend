using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Domain.Entities;

namespace Terap.Application.Contracts.Persistence
{
    public interface ICityRepository :IAsyncRepository<City>
    {
        public Task<List<City>> GetAllCities();
        public Task<City> GetCityById(Guid Id);
    }
}
