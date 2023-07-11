using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;

using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.Documents.Queries.GetAllDocuments
{
    public class GetAllDocumentsQueryHandler : IRequestHandler<GetAllDocumentsQuery, Response<List<Document>>>
    {
        private readonly IDocumentRepository _documentRepository;
         public GetAllDocumentsQueryHandler(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }

        public async Task<Response<List<Document>>> Handle(GetAllDocumentsQuery request, CancellationToken cancellationToken)
        {
            List<Document> document = await _documentRepository.GetAllDocuments();
            if (document != null)
            {
                return new Response<List<Document>> { Succeeded = true, Data = document, Errors = null };
            }
            return new Response<List<Document>> { Succeeded = false, Data = null, Errors = null };
        }
    }
    
}
