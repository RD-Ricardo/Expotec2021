using System.Collections.Generic;
using System.Threading.Tasks;
using Expotec2021.Application.DTOs;
using Expotec2021.Domain.Entities;

namespace Expotec2021.Application.Interfaces
{
    public interface IBlogServices
    {
        Task AddAsync(PostDTO model);
        Task UpdateAsync(PostDTO model);
        Task<IEnumerable<PostDTO>> GetAllAsync();
        Task<ApplicationUser> GetInformation(ApplicationUser user); 
    }
}