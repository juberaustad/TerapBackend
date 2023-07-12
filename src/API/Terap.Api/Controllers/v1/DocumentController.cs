using MediatR;
using Microsoft.AspNetCore.Mvc;
using Terap.Application.Features.Documents.Queries.GetAllDocuments;
using Terap.Application.Features.Documents.Queries.GetDocumentByTherapistId;

using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class DocumentController : Controller
    {
        private readonly IMediator _mediator;
        public DocumentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllDocuments")]
        public async Task<IActionResult> GetAllDocuments()
        {
            var respons = await _mediator.Send(new GetAllDocumentsQuery());
            return Ok(respons);
        }

        [HttpGet]
        [Route("GetDocumentByTherapistId")]
        public async Task<ActionResult> GetDocumentByTherapistId(Guid TherapistId)
        {
            Response<List<Document>> data = await _mediator.Send(new GetDocumentByTherapistIdQuery() { TherapistId= TherapistId });
            return Ok(data);
        }
    }
}
