using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Features.Videos.Queries.GetVideoByTherapistId;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.DocumentTypes.Queries.GetDocumentTypeById
{
    public class GetDocumentTypeByIdQueryHandler : IRequestHandler<GetDocumentTypeByIdQuery, Response<DocumentType>>
    {
        private readonly IDocumentTypeRepository _documentTypeRepository;
        public GetDocumentTypeByIdQueryHandler(IDocumentTypeRepository documentTypeRepository)
        {
            _documentTypeRepository = documentTypeRepository;
        }

        public async Task<Response<DocumentType>> Handle(GetDocumentTypeByIdQuery request, CancellationToken cancellationToken)
        {
            DocumentType data = await _documentTypeRepository.GetByIdAsync(request.ID);
            return new Response<DocumentType>(data);
        }
    }
}
