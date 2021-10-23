using System.Linq;
using System.Threading.Tasks;
using Expotec2021.Application.DTOs;
using Expotec2021.Application.Interfaces;
using Expotec2021.Domain.Entities;
using Expotec2021.Infra.Data.context;
using Expotec2021.Web.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Expotec2021.Web.Controllers
{   
    [Authorize]
    public class TarefasController : Controller
    {
        private readonly Context _context;
        private readonly ITarefasServices _tarefaService;
        private readonly UserManager<ApplicationUser> _usermanager;
        public TarefasController( ITarefasServices tarefasServices,
            UserManager<ApplicationUser> usermanager, Context context)
        {
            _tarefaService = tarefasServices;
            _usermanager = usermanager;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _usermanager.GetUserAsync(User);
            var ok = new TarefaViewModel
            {
                ListTask = await _tarefaService.GettALl(result),
                user = await _tarefaService.GetInformation(result)
            };
            return View(ok);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TarefaViewModel model)
        {
            var userCurrent = await _usermanager.GetUserAsync(User);
            model.TasksCreate.ApplicationUserId = userCurrent.Id;
            model.TasksCreate.CreateDate = System.DateTime.Now;
            await  _tarefaService.AddAsync(model.TasksCreate);
            return RedirectToAction(nameof(Index));
        }


       [HttpPost]
       public async Task<IActionResult> Delete(int id)
       {

           await _tarefaService.RemoveAsync(id);
           return Ok();
       }


      
    }
}