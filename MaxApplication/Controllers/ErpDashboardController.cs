using Microsoft.AspNetCore.Mvc;

namespace MaxApplication.Controllers
{
    public class ErpDashboardController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
