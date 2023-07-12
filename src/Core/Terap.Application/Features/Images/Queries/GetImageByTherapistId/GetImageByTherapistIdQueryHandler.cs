using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Features.Videos.Queries.GetVideoByTherapistId;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.Images.Queries.GetImageByTherapistId
{
    public class GetImageByTherapistIdQueryHandler : IRequestHandler<GetImageByTherapistIdQuery, Response<Image>>
    {
        private readonly IImageRepository _imageRepository;

        public GetImageByTherapistIdQueryHandler(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public async Task<Response<Image>> Handle(GetImageByTherapistIdQuery request, CancellationToken cancellationToken)
        {
            Image data = await _imageRepository.GetByIdAsync(request.ID);
          
            return new Response<Image>(data);
        }
    }
}
