using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;

using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.Documents.Queries.GetDocumentByTherapistId
{
    public class GetDocumentByTherapistIdQueryHandler : IRequestHandler<GetDocumentByTherapistIdQuery, Response<List<Document>>>
    {
        private readonly IDocumentRepository _documentRepository;
        public GetDocumentByTherapistIdQueryHandler(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }
        public async Task<Response<List<Document>>> Handle(GetDocumentByTherapistIdQuery request, CancellationToken cancellationToken)
        {
           List<Document> data = await _documentRepository.GetDocumentByTherapistId(request.TherapistId);
            return new Response<List<Document>>(data);
        }
    }
}
