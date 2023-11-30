using Microsoft.AspNetCore.Mvc;
using TTRPG_Character_Builder.Models;

namespace TTRPG_Character_Builder.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            // Logic to display user profile or redirect to login
            return View();
        }

        public IActionResult Login()
        {
            // Logic for login page
            return View("~/Views/Account/Login.cshtml");
        }

        public IActionResult Register()
        {
            // Logic for registration page
            return View("~/Views/Account/Register.cshtml");
        }

        public IActionResult Manage()
        {
            // Logic for managing user profile
            return View();
        }
    }
}
