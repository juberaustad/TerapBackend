using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Features.DocumentTypes.Queries.GetAllDocumentTypes;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.States.Queries.GetAllStates
{
    public class GetAllStatesQueryHandler : IRequestHandler<GetAllStatesQuery, Response<List<State>>>

    {
        private readonly IStateRepository _stateRepository;
        public GetAllStatesQueryHandler(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }

        public async Task<Response<List<State>>> Handle(GetAllStatesQuery request, CancellationToken cancellationToken)
        {
            List<State> states = await _stateRepository.GetAllStates();
            if (states != null)
            {
                return new Response<List<State>> { Succeeded = true, Data = states, Errors = null };
            }
            return new Response<List<State>> { Succeeded = false, Data = null, Errors = null };
        }

    }

}
