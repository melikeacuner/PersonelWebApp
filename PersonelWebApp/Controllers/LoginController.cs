using Microsoft.AspNetCore.Mvc;
using PersonelWebApp.Models;

namespace PersonelWebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            if(login.Email=="admin@sdfj.com" && login.Pass== "123")
            { 
                return RedirectToAction("Index", "Home");
            }
            else 
            { 
                return RedirectToAction("Index", "Login");
            }
          
        }

    }
}
