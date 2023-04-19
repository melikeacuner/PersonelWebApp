using BLL.Services.Abstract;
using Common.Auth;
using Entity.Models;
using Entity.PModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PersonelWebApp.Models;

namespace PersonelWebApp.Controllers
{
    [Authorize]
    public class LoginController : Controller
    { 
        private ILoginService _loginService { get; set; }
        public LoginController(ILoginService loginService)
        {
           _loginService = loginService ;
        }

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

            var user = _loginService.Login(login); 
          

            if(user is not null)
            { 
                var ClaimsPrincipal = AuthHelper.GetClaimsPrincipal(
                    new AuthModel()
                    {
                        Id = user.Id,
                        Name = user.Name,
                        NameIdentifier = user.Email,
                        Role = user.Role
                    });
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
