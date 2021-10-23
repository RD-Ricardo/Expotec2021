using System.Collections.Generic;
using System.Threading.Tasks;
using Expotec2021.Domain.Entities;


namespace Expotec2021.Domain.Interfaces
{
    public interface IPostsRepository
    {
        Task<Posts> CreateAsync(Posts model);
        Task<Posts> UpdateAsync(Posts model);
        Task<Posts> DeleteAsync(Posts model);
        Task<IEnumerable<Posts>> GetAllPostsAsync();
        Task<Posts> GetByIdPostsAsync(int id);
        Task<ApplicationUser> GetInformation(ApplicationUser user);
    }
}