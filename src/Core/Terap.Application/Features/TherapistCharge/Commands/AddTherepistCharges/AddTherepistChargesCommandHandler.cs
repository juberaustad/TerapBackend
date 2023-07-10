using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Contracts.Infrastructure;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Features.Events.Commands.CreateEvent;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.TherapistCharge.Commands.AddTherepistCharges
{
    public class AddTherepistChargesCommandHandler : IRequestHandler<AddTherepistChargesCommand, Response<Guid>>
    {
        private readonly ITherapistChargesRepository _therapistChargesRepository;
        private readonly IMapper _mapper;
        //private readonly IEmailService _emailService;
        private readonly ILogger<AddTherepistChargesCommandHandler> _logger;
        private readonly IMessageRepository _messageRepository;
        public AddTherepistChargesCommandHandler(IMapper mapper, ITherapistChargesRepository therapistChargesRepository,/* IEmailService emailService,*/ ILogger<AddTherepistChargesCommandHandler> logger, IMessageRepository messageRepository)
        {
            _mapper = mapper;
            _therapistChargesRepository = therapistChargesRepository;
            //_emailService = emailService;
            _logger = logger;
            _messageRepository = messageRepository;
        }
        public async Task<Response<Guid>> Handle(AddTherepistChargesCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handle Initiated");

            var validator = new AddTherepistChargesCommandValidator(_therapistChargesRepository, _messageRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new Exceptions.ValidationException(validationResult);

            var @Charges = _mapper.Map<TherapistCharges>(request);

            @Charges = await _therapistChargesRepository.AddAsync(@Charges);

            var response = new Response<Guid>(@Charges.ID, "Inserted successfully ");

            _logger.LogInformation("Handle Completed");

            return response;

        }
    }
}
