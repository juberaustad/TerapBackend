using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Domain.Entities;

namespace Terap.Application.Contracts.Persistence
{
    public interface ITherapistRepository : IAsyncRepository<Therapist>
    {
        public Task<List<Therapist>> GetAllTherapists();
        public Task<Therapist> GetTherepistById(Guid Id);

    }
}
