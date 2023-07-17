using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.States.Queries.GetStateById
{
    public class GetStateByIdQuery : IRequest<Response<State>>
    {
        public Guid ID { get; set; }
    }
}
