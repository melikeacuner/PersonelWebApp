using Microsoft.AspNetCore.Mvc;

namespace PersonelWebApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
