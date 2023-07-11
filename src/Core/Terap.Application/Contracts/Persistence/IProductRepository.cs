using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Domain.Entities;

namespace Terap.Application.Contracts.Persistence
{
    public interface IProductRepository : IAsyncRepository<Product>
    {
        public Task<Product> GetProductById(Guid Id);
        public Task<Product> GetProductByBrandId(Guid BrandId);


    }
}
