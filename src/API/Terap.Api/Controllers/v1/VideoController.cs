using MediatR;
using Microsoft.AspNetCore.Mvc;
using Terap.Application.Features.Therapists.Queries.GetAllTherapists;
using Terap.Application.Features.Therapists.Queries.GetTherapistById;
using Terap.Application.Features.Videos.Queries.GetAllVideos;
using Terap.Application.Features.Videos.Queries.GetVideoByTherapistId;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class VideoController : Controller
    {
        private readonly IMediator _mediator;
        public VideoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllVideos")]
        public async Task<IActionResult> GetAllVideos()
        {
            var respons = await _mediator.Send(new GetAllVideosQuery());
            return Ok(respons);
        }

        [HttpGet]
        [Route("GetVideoByTherapistId")]
        public async Task<IActionResult> GetVideoByTherapistId(Guid TherapistId)
        {
            Response<List<Video>> data = await _mediator.Send(new GetVideoByTherapistIdQuery() { TherapistId = TherapistId });


            if (data != null)
            {
                return Ok(data);
            }

            return NotFound();
        }
    }
}
