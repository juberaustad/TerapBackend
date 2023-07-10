using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Responses;

namespace Terap.Application.Features.TherapistCharge.Commands.AddTherepistCharges
{
    public class AddTherepistChargesCommand : IRequest<Response<Guid>>
    {
        public Guid DurationID { get; set; }
        public int Amount { get; set; }
        public Guid TherapistID { get; set; }
    }
}
