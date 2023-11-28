using Microsoft.AspNetCore.Mvc;

namespace TTRPG_Character_Builder.Controllers
{
    public class HomeController : Controller
    {
        // GET: /
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Home/Privacy (optional)
        public IActionResult Privacy()
        {
            return View();
        }

        // Additional actions can be added here as needed
    }
}
