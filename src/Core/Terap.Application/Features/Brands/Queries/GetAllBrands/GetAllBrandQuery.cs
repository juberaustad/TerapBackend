﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.Brands.Queries.GetAllBrands
{
    public class GetAllBrandQuery : IRequest<Response<List<Brand>>>
    {
        public Guid Id { get; set; }
    }
}
