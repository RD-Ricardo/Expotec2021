using System.Collections.Generic;
using System.Threading.Tasks;
using Expotec2021.Domain.Entities;

namespace Expotec2021.Domain.Interfaces
{
    public interface ILaunhsRepository
    {
        Task<Launchs> CreateAsync(Launchs model);
        Task<Launchs> UpdateAsync(Launchs model);
        Task<Launchs> DeleteAsync(Launchs model);
        Task<IEnumerable<Launchs>> GetAllLaunhsAsync();
        Task<Launchs> GetByIdLaunchsAsync(int id);
    }
}