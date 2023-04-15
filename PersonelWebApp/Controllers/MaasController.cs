using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PersonelWebApp.Controllers
{
    [Authorize]
    public class MaasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
