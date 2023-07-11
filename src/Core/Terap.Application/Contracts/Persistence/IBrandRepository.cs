using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Domain.Entities;

namespace Terap.Application.Contracts.Persistence
{
    public interface IBrandRepository : IAsyncRepository<Brand>
    {
        public Task<List<Brand>> GetAllBrands();
        public Task<Brand> GetBrandById(Guid Id);
    }
}
