using System.Collections.Generic;
using System.Threading.Tasks;
using Expotec2021.Application.DTOs;
using Expotec2021.Domain.Entities;

namespace Expotec2021.Application.Interfaces
{
    public interface ITarefasServices
    {
      Task AddAsync(ListTasksDTO model);
      Task UpdateAsync(int id);
      Task RemoveAsync(int id);
      Task<IEnumerable<ListTasksDTO>> GettALl(ApplicationUser user);
      Task<ApplicationUser> GetInformation(ApplicationUser user); 
    }
}