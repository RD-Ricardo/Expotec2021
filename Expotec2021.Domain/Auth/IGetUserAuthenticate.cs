using System.Threading.Tasks;
using Expotec2021.Domain.Entities;

namespace Expotec2021.Domain.Auth
{
    public interface IGetUserAuthenticate
    {
         Task<ApplicationUser> GetUserAuthenticate(string id);
    }
}