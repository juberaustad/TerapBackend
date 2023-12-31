﻿using Terap.Application.Responses;
using MediatR;
using System.Collections.Generic;

namespace Terap.Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoriesListQuery : IRequest<Response<IEnumerable<CategoryListVm>>>
    {
    }
}
