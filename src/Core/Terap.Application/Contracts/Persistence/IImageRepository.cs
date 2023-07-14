using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Domain.Entities;

namespace Terap.Application.Contracts.Persistence
{
    public interface IImageRepository : IAsyncRepository<Image>
    {
        public Task<List<Image>> GetAllImages();
        public Task<List<Image>> GetImageByTherapistId(Guid TherapistId);
    }
}
