using Microsoft.AspNetCore.Mvc;

namespace SportsForEveryone.WebUI.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
