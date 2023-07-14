using MediatR;
using Microsoft.AspNetCore.Mvc;
using Terap.Application.Features.Images.Queries.GetAllImages;
using Terap.Application.Features.Images.Queries.GetImageByTherapistId;
using Terap.Application.Features.Videos.Queries.GetAllVideos;
using Terap.Application.Features.Videos.Queries.GetVideoByTherapistId;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ImageController : Controller
    {
        private readonly IMediator _mediator;
        public ImageController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllImages")]
        public async Task<IActionResult> GetAllImages()
        {
            var respons = await _mediator.Send(new GetAllImagesQuery());
            return Ok(respons);
        }

        [HttpGet]
        [Route("GetImageByTherapistId")]
        public async Task<ActionResult> GetImageByTherapistId(Guid TherapistId)
        {
            Response<List<Image>> data = await _mediator.Send(new GetImageByTherapistIdQuery() { TherapistId = TherapistId });
            return Ok(data);
        }
    }

}
