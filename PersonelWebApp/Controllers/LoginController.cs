using Microsoft.AspNetCore.Mvc;

namespace PersonelWebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return PartialView();
        }
    }
}
