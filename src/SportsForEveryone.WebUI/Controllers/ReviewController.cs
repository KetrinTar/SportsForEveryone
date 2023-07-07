using Microsoft.AspNetCore.Mvc;

namespace SportsForEveryone.WebUI.Controllers
{
    public class ReviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
