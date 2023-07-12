using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Domain.Entities;

namespace Terap.Application.Contracts.Persistence
{
    public interface IVideoRepository : IAsyncRepository<Video>
    {
        public Task<List<Video>> GetAllVideos();
        public Task<List<Video>> GetVideoByTherapistId(Guid TherapistId);
    }
}
