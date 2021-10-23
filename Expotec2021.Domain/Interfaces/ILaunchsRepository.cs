using System.Collections.Generic;
using System.Threading.Tasks;
using Expotec2021.Domain.Entities;

namespace Expotec2021.Domain.Interfaces
{
    public interface ILaunchsRepository
    {
        Task<bool> CreateAsync(Launchs model);
        Task<Launchs> UpdateAsync(Launchs model, ApplicationUser user);
        Task<Launchs> DeleteAsync(Launchs model, ApplicationUser user);
        Task<ApplicationUser> GetUserOk(ApplicationUser use);
        Task<IEnumerable<Launchs>> GetAllLaunhsAsync(ApplicationUser useId);
        Task<Launchs> GetByIdLaunchsAsync(int id);
        Task<ApplicationUser> GetInformation(ApplicationUser user);
    }
}