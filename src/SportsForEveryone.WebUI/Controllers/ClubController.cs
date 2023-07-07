using Microsoft.AspNetCore.Mvc;

namespace SportsForEveryone.WebUI.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
