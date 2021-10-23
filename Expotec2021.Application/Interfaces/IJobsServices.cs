using System.Collections.Generic;
using System.Threading.Tasks;
using Expotec2021.Application.DTOs;
using Expotec2021.Domain.Entities;

namespace Expotec2021.Application.Interfaces
{
    public interface IJobsServices
    {
      Task AddAsync(JobsDTO model, ApplicationUser user);
      Task UpdateAsync(JobsDTO model, ApplicationUser user);
      Task<IEnumerable<JobsDTO>> GetAll();
      Task<ApplicationUser> GetInformation(ApplicationUser user); 
    }
}