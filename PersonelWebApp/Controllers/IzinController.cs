using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace PersonelWebApp.Controllers
{
    [Authorize]
    public class IzinController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
