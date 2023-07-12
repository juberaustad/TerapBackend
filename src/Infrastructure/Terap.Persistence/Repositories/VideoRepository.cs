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
    public class VideoRepository : BaseRepository<Video>, IVideoRepository
    {
        private readonly ILogger _logger;

        public VideoRepository(ApplicationDbContext dbContext, ILogger<Video> logger) : base(dbContext, logger)
        {
            _logger = logger;
        }

        public async Task<List<Video>> GetAllVideos()
        {
            List<Video> video = await _dbContext.Video.ToListAsync();
            return video;
        }

        public async Task<List<Video>> GetVideoByTherapistId(Guid TherapistId)
        {

            List<Video> data = await _dbContext.Video.Where(z => z.TherapistId == TherapistId).Include(z => z.Therapist).ToListAsync();
            return data;
        }
    }
}
