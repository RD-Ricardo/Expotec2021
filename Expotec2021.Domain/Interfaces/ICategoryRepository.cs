using System.Collections.Generic;
using System.Threading.Tasks;
using Expotec2021.Domain.Entities;

namespace Expotec2021.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<CategoryLaunch> CreateAsync(CategoryLaunch model);
        Task<CategoryLaunch> UpdateAsync(CategoryLaunch model);
        Task<CategoryLaunch> DeleteAsync(CategoryLaunch model);
        Task<IEnumerable<CategoryLaunch>> GetAllCategoriesAsync();
        Task<CategoryLaunch> GetByIdCategoriesAsync(int id);
    }
}