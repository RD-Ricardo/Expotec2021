using Microsoft.AspNetCore.Mvc;

namespace Expotec2021.Web.Controllers
{
    public class SharedController : Controller
    {
        [HttpGet]
        public ActionResult _InformationUser()
        {

            return View();
        }
    }
}