using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Features.Videos.Queries.GetAllVideos;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.DocumentTypes.Queries.GetAllDocumentTypes
{
    public class GetAllDocumentTypeQueryHandler : IRequestHandler<GetAllDocumentTypeQuery, Response<List<DocumentType>>>

    {
        private readonly IDocumentTypeRepository _documentTypeRepository;
        public GetAllDocumentTypeQueryHandler(IDocumentTypeRepository documentTypeRepository)
        {
            _documentTypeRepository = documentTypeRepository;
        }

        public async Task<Response<List<DocumentType>>> Handle(GetAllDocumentTypeQuery request, CancellationToken cancellationToken)
        {
            List<DocumentType> documentTypes = await _documentTypeRepository.GetAllDocumentTypes();
            if (documentTypes != null)
            {
                return new Response<List<DocumentType>> { Succeeded = true, Data = documentTypes, Errors = null };
            }
            return new Response<List<DocumentType>> { Succeeded = false, Data = null, Errors = null };
        }

    }

}
