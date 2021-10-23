using System.Threading.Tasks;
using Expotec2021.Domain.Auth;
using Expotec2021.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Expotec2021.Infra.Data.Services
{
    public class AuthenticateService : IAuthenticate
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signIlManager;
        public AuthenticateService(UserManager<ApplicationUser> userManager, 
                SignInManager<ApplicationUser> signIlManager)
        {
            _userManager = userManager;
            _signIlManager = signIlManager;
        }
        public async Task<bool> Authenticate(string email, string password)
        {
            var result = await _signIlManager.PasswordSignInAsync(email,password,false,lockoutOnFailure:false);

            return result.Succeeded;
        }
        public async Task<bool> RegisterUser(string email, string password, string cep)
        {
           var  applicationUser = new ApplicationUser
           {
               UserName = email,
               Email = email,
               CodIbge = cep
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