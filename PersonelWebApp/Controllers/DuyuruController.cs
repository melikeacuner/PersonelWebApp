using Microsoft.AspNetCore.Mvc;

namespace PersonelWebApp.Controllers
{
    public class DuyuruController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
