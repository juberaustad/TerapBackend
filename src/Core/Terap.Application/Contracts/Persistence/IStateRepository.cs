using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Domain.Entities;

namespace Terap.Application.Contracts.Persistence
{
    public interface IStateRepository : IAsyncRepository<State>
    {
        public Task<List<State>> GetAllStates();
        public Task<State> GetStateById(Guid Id);
    }
}
