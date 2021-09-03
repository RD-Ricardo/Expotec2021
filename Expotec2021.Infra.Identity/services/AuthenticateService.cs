using System.Threading.Tasks;
using Expotec2021.Domain.Auth;
using Expotec2021.Infra.Identity.models;
using Microsoft.AspNetCore.Identity;

namespace Expotec2021.Infra.Identity.services
{
    public class AuthenticateService: IAuthenticate
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signIlManager;
        public AuthenticateService(UserManager<User> userManager, 
                SignInManager<User> signIlManager)
        {
            _userManager = userManager;
            _signIlManager = signIlManager;
        }
        public async  Task<bool> Authenticate(string email, string password)
        {
            var result = await _signIlManager.PasswordSignInAsync(email,password,false,lockoutOnFailure:false);

            return result.Succeeded;
        }
        public async Task<bool> RegisterUser(string email, string password)
        {
           var  applicationUser = new User
           {
               UserName = email,
               Email = email,
           };

           var result = await _userManager.CreateAsync(applicationUser, password);

           if(result.Succeeded)
           {
               await _signIlManager.SignInAsync(applicationUser, isPersistent:false);
           }

           return result.Succeeded;
        }
        public async Task Logout()
        {
            await _signIlManager.SignOutAsync();
        }
    }
}