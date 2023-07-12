using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Features.Therapists.Queries.GetTherapistById;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.Videos.Queries.GetVideoByTherapistId
{
    public class GetVideoByTherapistIdQueryHandler : IRequestHandler<GetVideoByTherapistIdQuery, Response<List<Video>>>
    {
        private readonly IVideoRepository _videoRepository;
        public GetVideoByTherapistIdQueryHandler(IVideoRepository videoRepository)
        {
            _videoRepository = videoRepository;
        }

        public async Task<Response<List<Video>>> Handle(GetVideoByTherapistIdQuery request, CancellationToken cancellationToken)
        {
           List<Video> data = await _videoRepository.GetVideoByTherapistId(request.TherapistId);
            return new Response<List<Video>>(data);
        }
    }
}
