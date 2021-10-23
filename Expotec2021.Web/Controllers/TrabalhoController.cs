using System.Threading.Tasks;
using Expotec2021.Application.Interfaces;
using Expotec2021.Domain.Entities;
using Expotec2021.Web.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Expotec2021.Web.Controllers
{
    public class TrabalhoController : Controller
    {   

        private readonly ITarefasServices _tarefaService;
        private readonly UserManager<ApplicationUser> _usermanager;
        public TrabalhoController(ITarefasServices tarefasServices,
            UserManager<ApplicationUser> userManager)
        {
            _tarefaService = tarefasServices;
            _usermanager = userManager;
        }
        [HttpGet]
        public async  Task<IActionResult> Index()
        {
            var result = await _usermanager.GetUserAsync(User);
            var ok = new TarefaViewModel
            {
                user = await _tarefaService.GetInformation(result)
            };
            return View(ok);
        }
    }
}