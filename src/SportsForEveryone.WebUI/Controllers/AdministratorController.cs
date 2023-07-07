using Microsoft.AspNetCore.Mvc;

namespace SportsForEveryone.WebUI.Controllers
{
    public class AdministratorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
