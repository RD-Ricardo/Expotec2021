using System.Collections.Generic;
using Expotec2021.Domain.Entities;
using MediatR;

namespace Expotec2021.Application.Events.CategoryLaunchsEvent.Queries
{
    public class GetAllCategoryLaunchsQuery : IRequest<IEnumerable<CategoryLaunch>>
    {
        
    }
}