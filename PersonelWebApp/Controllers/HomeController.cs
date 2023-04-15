using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PersonelWebApp.Models;
using System.Diagnostics;

namespace PersonelWebApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult LoginPage()
        {
            return PartialView();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profilim()
        {
            return View();
        }

        public IActionResult Izinler()
        {
            return View();
        }

        public IActionResult Maas()
        {
            return View();
        }

        public IActionResult Takvim()
        {
            return View();
        }

        public IActionResult Duyurular()
        {
            return View();
        }

        public IActionResult Aktiviteler()
        {
            return View();
        }

        public IActionResult Calisanlar()
        {
            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}