using Terap.Application.Responses;
using MediatR;

namespace Terap.Application.Features.Categories.Commands.StoredProcedure
{
    public class StoredProcedureCommand: IRequest<Response<StoredProcedureDto>>
    {
        public string Name { get; set; }
    }
}
