﻿using AutoMapper;
using Terap.Application.Contracts.Persistence;
using Terap.Application.Features.Orders/*.GetOrdersForMonth*/;
using Terap.Application.Profiles;
using Terap.Application.Responses;
using Terap.Application.UnitTests.Mocks;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Terap.Application.Features.Orders.Queries.GetOrdersForMonth;

namespace Terap.Application.UnitTests.Orders.Queries
{
    public class GetOrdersForMonthQueryHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IOrderRepository> _mockOrderRepository;

        public GetOrdersForMonthQueryHandlerTests()
        {
            _mockOrderRepository = OrderRepositoryMocks.GetOrderRepositoryAsync();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task Get_Orders_For_Month_Test()
        {
            var handler = new GetOrdersForMonthQueryHandler(_mockOrderRepository.Object, _mapper);

            var result = await handler.Handle(new GetOrdersForMonthQuery(){ Date = Convert.ToDateTime("2021-08-26 10:44:09.5406918"), Page = 1, Size = 2}, CancellationToken.None);

            result.ShouldBeOfType<PagedResponse<IEnumerable<OrdersForMonthDto>>>();
            result.Data.ShouldBeOfType<List<OrdersForMonthDto>>();
            result.Data.ShouldNotBeEmpty();
        }
    }
}
