using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Web.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
        public IActionResult RegisterCompleted()
        {
            return View();
        }
    }
}
