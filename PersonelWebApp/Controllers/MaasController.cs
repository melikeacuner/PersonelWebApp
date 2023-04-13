using Microsoft.AspNetCore.Mvc;

namespace PersonelWebApp.Controllers
{
    public class MaasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
