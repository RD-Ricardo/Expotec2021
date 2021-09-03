using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Expotec2021.Application.Events.CategoryLaunchsEvent.Queries;
using Expotec2021.Domain.Entities;
using Expotec2021.Domain.Interfaces;
using MediatR;

namespace Expotec2021.Application.Events.CategoryLaunchsEvent.Handler
{
    public class GetAllCategoryLaunchsHandler : IRequestHandler<GetAllCategoryLaunchsQuery, IEnumerable<CategoryLaunch>>
    {

        private readonly ICategoryRepository _repository;

        public GetAllCategoryLaunchsHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<CategoryLaunch>> Handle(GetAllCategoryLaunchsQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllCategoriesAsync();
        }

        
    }
}