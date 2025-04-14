using Microsoft.AspNetCore.Mvc;

namespace MaxApplication.Controllers
{
    public class ErpDashboard : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
