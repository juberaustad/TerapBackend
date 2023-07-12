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
    public class ImageRepository : BaseRepository<Image>, IImageRepository
    {
        private readonly ILogger _logger;

        public ImageRepository(ApplicationDbContext dbContext, ILogger<Image> logger) : base(dbContext, logger)
        {
            _logger = logger;
        }

        public async Task<List<Image>> GetAllImages()
        {
            List<Image> image = await _dbContext.Image.ToListAsync();
            return image;
        }

        public async Task<List<Image>> GetImageByTherapistId(Guid TherapistId)
        {
            List<Image> data = await _dbContext.Image.Where(z => z.TherapistId == TherapistId).Include(z => z.Therapist).ToListAsync();
            return data;
        }
    }
}
