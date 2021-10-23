using System.Collections.Generic;
using System.Threading.Tasks;
using Expotec2021.Domain.Entities;

namespace Expotec2021.Domain.Interfaces
{
    public interface IJobsRepository
    {
        Task<Jobs> CreateAsync(Jobs model, ApplicationUser user);
        Task<Jobs> UpdateAsync(Jobs model, ApplicationUser user);
        Task <IEnumerable<Jobs>> GetAllJobsAsync();
        Task<Jobs> GetByIdJobsAsync(int id);

        Task<ApplicationUser> GetInformation(ApplicationUser user);
    }
}