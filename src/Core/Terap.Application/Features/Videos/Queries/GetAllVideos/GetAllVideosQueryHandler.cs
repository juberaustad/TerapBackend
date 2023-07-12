using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Features.Therapists.Queries.GetAllTherapists;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.Videos.Queries.GetAllVideos
{
    public class GetAllVideosQueryHandler : IRequestHandler<GetAllVideosQuery, Response<List<Video>>>

    {
        private readonly IVideoRepository _videoRepository;
        public GetAllVideosQueryHandler(IVideoRepository videoRepository)
        {
            _videoRepository = videoRepository;
        }

        public async Task<Response<List<Video>>> Handle(GetAllVideosQuery request, CancellationToken cancellationToken)
        {
            List<Video> video = await _videoRepository.GetAllVideos();
            if (video != null)
            {
                return new Response<List<Video>> { Succeeded = true, Data = video, Errors = null };
            }
            return new Response<List<Video>> { Succeeded = false, Data = null, Errors = null };
        }

    }
}
