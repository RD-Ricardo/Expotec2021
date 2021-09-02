using System.Collections.Generic;
using System.Threading.Tasks;
using Expotec2021.Domain.Entities;

namespace Expotec2021.Domain.Interfaces
{
    public interface IListTaskRepository
    {
        Task<ListTask> CreateAsync(ListTask model);
        Task<ListTask> UpdateAsync(ListTask model);
        Task<ListTask> DeleteAsync(ListTask model);
        Task<IEnumerable<ListTask>> GetAllListTaskAsync();
        Task<ListTask> GetByIdListTaskAsync(int id);
    }
}