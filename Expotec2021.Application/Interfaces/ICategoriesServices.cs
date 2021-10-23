using System.Collections.Generic;
using System.Threading.Tasks;
using Expotec2021.Application.DTOs;
using Expotec2021.Domain.Entities;

namespace Expotec2021.Application.Interfaces
{
    public interface ICategoriesServices
    {
      Task AddAsync(CategoryLaunchDTO model);
      Task UpdateAsync(CategoryLaunchDTO model);
      Task RemoveAsync(CategoryLaunchDTO model);
      Task<IEnumerable<CategoryLaunchDTO>> GettALl();
    }
}