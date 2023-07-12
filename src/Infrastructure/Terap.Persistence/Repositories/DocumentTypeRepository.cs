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
    public class DocumentTypeRepository : BaseRepository<DocumentType>, IDocumentTypeRepository
    {
        private readonly ILogger _logger;

        public DocumentTypeRepository(ApplicationDbContext dbContext, ILogger<DocumentType> logger) : base(dbContext, logger)
        {
            _logger = logger;
        }

        public async Task<List<DocumentType>> GetAllDocumentTypes()
        {
            List<DocumentType> documents = await _dbContext.DocumentType.ToListAsync();
            return documents;
        }

        public async Task<DocumentType> GetDocumentTypeById(Guid Id)
        {
            DocumentType? document = await _dbContext.DocumentType.FirstOrDefaultAsync(i => i.ID == Id);
            return document;
        }
    }
}
