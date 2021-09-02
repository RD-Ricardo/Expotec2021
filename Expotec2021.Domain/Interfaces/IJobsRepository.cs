using System.Collections.Generic;
using System.Threading.Tasks;
using Expotec2021.Domain.Entities;

namespace Expotec2021.Domain.Interfaces
{
    public interface IJobsRepository
    {
        Task<Jobs> CreateAsync(Jobs model);
        Task<Jobs> UpdateAsync(Jobs model);
        Task<Jobs> DeleteAsync(Jobs model);
        Task <IEnumerable<Jobs>> GetAllJobsAsync();
        Task<Jobs> GetByIdJobsAsync(int id);
    }
}