using Common.Auth;
using Entity.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PersonelWebApp.Models;

namespace PersonelWebApp.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            if(User is not null && User.Identity is not null && User.Identity.IsAuthenticated) 
            { 
                return RedirectToAction("Index","Home"); 
            }
            return PartialView();
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(Login login)
        {
            var DbUser = new Employee() { };
            var user = new AuthModel()
            {
                Id = DbUser.Id,
                Name = DbUser.Name + " " + DbUser.Surname,
                NameIdentifier = DbUser.Email,
                Role = DbUser.Role,

            };

            if(login.Email== "melike@com.tr" && login.Pass== "123")
            { 
                var ClaimsPrincipal = AuthHelper.GetClaimsPrincipal(user);
                await HttpContext.SignInAsync(ClaimsPrincipal);
                return RedirectToAction("Index", "Home");
            }
            else 
            { 
                return RedirectToAction("Index", "Login");
            }
          
        }

        public IActionResult Denied()
        {
            return PartialView();
        }

    }
}
