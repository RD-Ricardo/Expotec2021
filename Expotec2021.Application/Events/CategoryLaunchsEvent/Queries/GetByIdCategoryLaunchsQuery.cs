using Expotec2021.Domain.Entities;
using MediatR;

namespace Expotec2021.Application.Events.CategoryLaunchsEvent.Queries
{
    public class GetByIdCategoryLaunchsQuery : IRequest<CategoryLaunch>
    {
        public int Id { get; private set; }
        public GetByIdCategoryLaunchsQuery(int id)
        {
            Id = id;
        }
    }
}