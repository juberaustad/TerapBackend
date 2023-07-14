using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.Images.Queries.GetImageByTherapistId
{
    public class GetImageByTherapistIdQuery : IRequest<Response<List<Image>>>
    {
        public Guid TherapistId { get; set; }
    }
}
