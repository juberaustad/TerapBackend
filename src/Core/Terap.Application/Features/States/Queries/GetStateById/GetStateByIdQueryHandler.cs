using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Features.DocumentTypes.Queries.GetDocumentTypeById;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.States.Queries.GetStateById
{
    public class GetStateByIdQueryHandler : IRequestHandler<GetStateByIdQuery, Response<State>>
    {
        private readonly IStateRepository _stateRepository;
        public GetStateByIdQueryHandler(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }

        public async Task<Response<State>> Handle(GetStateByIdQuery request, CancellationToken cancellationToken)
        {
            State data = await _stateRepository.GetByIdAsync(request.ID);
            return new Response<State>(data);
        }
    }

}
