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
    public class DocumentRepository : BaseRepository<Document>, IDocumentRepository
    {
        private readonly ILogger _logger;   
        public DocumentRepository(ApplicationDbContext dbContext, ILogger<Document> logger) : base(dbContext, logger)
        {
            _logger = logger;
        }

        public async Task<List<Document>> GetAllDocuments()
        {
            List<Document> doc = await _dbContext.Document.ToListAsync();
            return doc;
        }

        public async Task<Document> GetDocumentByTherapistId(Guid Id)
        {
            Document? doc = await _dbContext.Document.FirstOrDefaultAsync(i => i.ID == Id);
            return doc;
        }
    }
}
