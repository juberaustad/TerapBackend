﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Domain.Entities;

namespace Terap.Application.Contracts.Persistence
{
    public interface IDocumentTypeRepository : IAsyncRepository<DocumentType>
    {
        public Task<List<DocumentType>> GetAllDocumentTypes();
        public Task<DocumentType> GetDocumentTypeById(Guid Id);
    }
}
