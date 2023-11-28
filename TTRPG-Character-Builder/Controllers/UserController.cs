using Microsoft.AspNetCore.Mvc;

namespace TTRPG_Character_Builder.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
