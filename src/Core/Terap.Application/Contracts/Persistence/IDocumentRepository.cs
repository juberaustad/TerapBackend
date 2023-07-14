using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Terap.Domain.Entities;
using Document = Terap.Domain.Entities.Document;

namespace Terap.Application.Contracts.Persistence
{
    public interface IDocumentRepository : IAsyncRepository<Document>
    {
        public Task<List<Document>> GetAllDocuments();
        public Task<List<Document>> GetDocumentByTherapistId(Guid TherapistId);
    }
}
