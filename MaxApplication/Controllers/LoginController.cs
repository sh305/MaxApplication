using Microsoft.AspNetCore.Mvc;

namespace MaxApplication.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult UserLogin()
        {
            return View();
        }
        public IActionResult UserPassword()
        {
            return View();

        }
    }
}
