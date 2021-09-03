using System.Threading.Tasks;

namespace Expotec2021.Domain.Auth
{
    public interface IAuthenticate
    {
        Task<bool> Authenticate(string email, string password);
        Task<bool> RegisterUser(string email, string password); 
        Task Logout();
    }
}