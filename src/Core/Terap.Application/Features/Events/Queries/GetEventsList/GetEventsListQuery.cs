using Terap.Application.Responses;
using MediatR;
using System.Collections.Generic;

namespace Terap.Application.Features.Events.Queries.GetEventsList
{
    public class GetEventsListQuery: IRequest<Response<IEnumerable<EventListVm>>>
    {

    }
}
