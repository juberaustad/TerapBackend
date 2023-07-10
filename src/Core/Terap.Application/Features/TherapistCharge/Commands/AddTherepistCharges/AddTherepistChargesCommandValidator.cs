using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Persistence;

namespace Terap.Application.Features.TherapistCharge.Commands.AddTherepistCharges
{
    
    public class AddTherepistChargesCommandValidator:AbstractValidator<AddTherepistChargesCommand>
    {
        private readonly ITherapistChargesRepository _therapistChargesRepository;
        private readonly IMessageRepository _messageRepository;

        public AddTherepistChargesCommandValidator(ITherapistChargesRepository therapistChargesRepository, IMessageRepository messageRepository)
        {
            _therapistChargesRepository = therapistChargesRepository;
            _messageRepository = messageRepository;

        }
    }
}
