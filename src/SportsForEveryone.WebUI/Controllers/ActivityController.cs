using Microsoft.AspNetCore.Mvc;

namespace SportsForEveryone.WebUI.Controllers
{
    public class ActivityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
