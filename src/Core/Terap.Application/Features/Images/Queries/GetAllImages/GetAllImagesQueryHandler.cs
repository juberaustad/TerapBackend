using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Features.Videos.Queries.GetAllVideos;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.Images.Queries.GetAllImages
{
    public class GetAllImagesQueryHandler : IRequestHandler<GetAllImagesQuery, Response<List<Image>>>

    {
        private readonly IImageRepository _imageRepository;
        public GetAllImagesQueryHandler(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public async Task<Response<List<Image>>> Handle(GetAllImagesQuery request, CancellationToken cancellationToken)
        {
            List<Image> image = await _imageRepository.GetAllImages();
            if (image != null)
            {
                return new Response<List<Image>> { Succeeded = true, Data = image, Errors = null };
            }
            return new Response<List<Image>> { Succeeded = false, Data = null, Errors = null };
        }

    }

}
