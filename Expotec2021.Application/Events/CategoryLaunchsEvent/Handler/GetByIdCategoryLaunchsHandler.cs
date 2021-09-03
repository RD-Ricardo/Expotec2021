using System.Threading;
using System.Threading.Tasks;
using Expotec2021.Application.Events.CategoryLaunchsEvent.Queries;
using Expotec2021.Domain.Entities;
using Expotec2021.Domain.Interfaces;
using MediatR;

namespace Expotec2021.Application.Events.CategoryLaunchsEvent.Handler
{
    public class GetByIdCategoryLaunchsHandler : IRequestHandler<GetByIdCategoryLaunchsQuery, CategoryLaunch>
    {

        private readonly ICategoryRepository _repositoryCategory;
      
        public GetByIdCategoryLaunchsHandler( ICategoryRepository repositoryCategory)
        {
            _repositoryCategory = repositoryCategory;
        }
        public async Task<CategoryLaunch> Handle(GetByIdCategoryLaunchsQuery request, CancellationToken cancellationToken)
        {
            return await _repositoryCategory.GetByIdCategoriesAsync(request.Id);
        }
    }
}