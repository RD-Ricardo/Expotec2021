using System.Threading.Tasks;
using Expotec2021.Domain.Auth;
using Expotec2021.Web.ViewModel;
using Expotec2021.Web.ViewModel.RegisterViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Expotec2021.Web.Controllers
{   
    public class AccountController : Controller
    {
        private readonly IAuthenticate _authenticate;
        public AccountController(IAuthenticate authenticate)
        {
            _authenticate = authenticate;
        }

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel()
            {
                ReturnUrl = returnUrl
            });
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var result = await _authenticate.Authenticate(model.Email, model.Password);

            if(result)
            {
                if(string.IsNullOrEmpty(model.ReturnUrl))
                {   
                    return RedirectToAction("Index", "Blog");
                }
                return Redirect(model.ReturnUrl);
            }
            else{
                
                ViewBag.Message =  "Login Invalido";
                return View();
            }
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            var resuslt = await _authenticate.RegisterUser(model.Email, model.Password,model.Cep);

            if(resuslt)
            {
                return Redirect("/Blog");
            }
            else
            {
               // ModelState.AddModelError(string.Empty, "Invalid register attempt(password must be strong.)");
                return View(model);
            }
        }

        public async Task<IActionResult> Logout()
        {
            await _authenticate.Logout();
            return Redirect("/");
        }
    }
}