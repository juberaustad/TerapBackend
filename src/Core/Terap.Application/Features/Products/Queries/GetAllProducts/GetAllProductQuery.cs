using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terap.Application.Responses;
using Terap.Domain.Entities;

namespace Terap.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductQuery : IRequest<Response<List<Product>>>
    {
    }
}
