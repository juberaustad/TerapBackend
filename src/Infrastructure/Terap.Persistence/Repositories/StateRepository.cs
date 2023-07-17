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
    public class StateRepository : BaseRepository<State>, IStateRepository
    {
        private readonly ILogger _logger;

        public StateRepository(ApplicationDbContext dbContext, ILogger<State> logger) : base(dbContext, logger)
        {
            _logger = logger;
        }

        public async Task<List<State>> GetAllStates()
        {
            List<State> states = await _dbContext.State.ToListAsync();
            return states;
        }

        public async Task<State> GetStateById(Guid Id)
        {
            State? state = await _dbContext.State.FirstOrDefaultAsync(i => i.ID == Id);
            return state;
        }
    }
}
