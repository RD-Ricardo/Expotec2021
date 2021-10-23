using System.Collections.Generic;
using System.Threading.Tasks;
using Expotec2021.Application.DTOs;
using Expotec2021.Domain.Entities;

namespace Expotec2021.Application.Interfaces
{
    public interface ILaunchsServices
    {
        Task AddAsync(LaunchsDTO model);
        Task UpdateAsync(LaunchsDTO model, ApplicationUser user);
        Task RemoveAsync(LaunchsDTO model , ApplicationUser user);
        Task<IEnumerable<LaunchsDTO>> GettALl(ApplicationUser user);
        Task<ApplicationUser> GetInformation(ApplicationUser user); 
    }
}