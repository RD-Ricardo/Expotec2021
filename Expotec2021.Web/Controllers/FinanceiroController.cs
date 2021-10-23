using System.Threading.Tasks;
using Expotec2021.Application.DTOs;
using Expotec2021.Application.Interfaces;
using Expotec2021.Domain.Entities;
using Expotec2021.Domain.Interfaces;
using Expotec2021.Web.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Expotec2021.Web.Controllers
{
    [Authorize]
    public class FinanceiroController : Controller
    {
        private readonly ICategoriesServices _categoriesServices;
        private readonly ILaunchsServices _services;
         private readonly UserManager<ApplicationUser> _userManager;
        public FinanceiroController(ILaunchsServices services, UserManager<ApplicationUser> userManager 
            ,ICategoriesServices categoriesServices)
        {
            _services = services;
            _userManager = userManager;
            _categoriesServices = categoriesServices;
        
        }

        public async Task<IActionResult> Index()
        {
            var usuario = await _userManager.GetUserAsync(User);

            var ok = new FinanceiroViewModel()
            {
                ListLaunhsDTO = await _services.GettALl(usuario),
                user = await _services.GetInformation(usuario)
            };

            ViewBag.ClienteId = new SelectList(await _categoriesServices.GettALl(),"Id","Name");
            ViewBag.UserIdTeste = usuario.Id;
            return View(ok);
        }


        


        [HttpPost]
        public async Task<IActionResult> Create(FinanceiroViewModel model)
        {

           var currentUser = await _userManager.GetUserAsync(User);
           model.LaunchsDTO.ApplicationUserId = currentUser.Id;
           await _services.AddAsync(model.LaunchsDTO);
           return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public  async Task<IActionResult> GetUser()
        { 
            var usuarioAuthenticate = await _userManager.GetUserAsync(User); 

            var ok = new ApplicationUser
            {   
                Id = usuarioAuthenticate.Id,
                CodIbge = usuarioAuthenticate.CodIbge
            };
            
            return View("identity/_UserInformation.cshtml" , ok);
        }
    }
}