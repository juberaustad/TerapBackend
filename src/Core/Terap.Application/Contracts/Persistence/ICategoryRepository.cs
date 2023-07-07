
using System.Collections.Generic;
using System.Threading.Tasks;

using Terap.Domain.Entities;

namespace Terap.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
        Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents);
        Task<Category> AddCategory(Category category);
    }
}
