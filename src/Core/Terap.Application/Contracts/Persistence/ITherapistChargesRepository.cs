using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Domain.Entities;

namespace Terap.Application.Contracts.Persistence
{
    public interface ITherapistChargesRepository : IAsyncRepository<TherapistCharges>
    {
        public Task<List<TherapistCharges>> GetAllTherapistCharges();

        Task<TherapistCharges> AddTherepistCharges(TherapistCharges @Charges);

        public Task<TherapistCharges> GetTherepistChargesById(Guid Id);
    }
}
