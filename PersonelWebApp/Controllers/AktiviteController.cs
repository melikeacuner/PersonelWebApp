using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PersonelWebApp.Controllers
{
    [Authorize]
    public class AktiviteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
