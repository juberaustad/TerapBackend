using MediatR;
using Microsoft.AspNetCore.Mvc;
using Terap.Application.Features.DocumentTypes.Queries.GetAllDocumentTypes;
using Terap.Application.Features.DocumentTypes.Queries.GetDocumentTypeById;
using Terap.Application.Features.Videos.Queries.GetAllVideos;
using Terap.Application.Features.Videos.Queries.GetVideoByTherapistId;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class DocumentTypeController : Controller
    {
        private readonly IMediator _mediator;
        public DocumentTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllDocumentType")]
        public async Task<IActionResult> GetAllDocumentType()
        {
            var respons = await _mediator.Send(new GetAllDocumentTypeQuery());
            return Ok(respons);
        }

        [HttpGet]
        [Route("GetDocumentTypeById")]
        public async Task<ActionResult> GetDocumentTypeById(Guid id)
        {
            Response<DocumentType> data = await _mediator.Send(new GetDocumentTypeByIdQuery() { ID = id });
            return Ok(data);
        }
    }

}
