using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PersonelWebApp.Controllers
{
    [Authorize]
    public class DuyuruController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
