using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.Durations.Queries.GetDurationById
{
    public class GetDurationByIdQuery : IRequest<Response<Duration>>
    {
        public Guid ID { get; set; }
    }
}
