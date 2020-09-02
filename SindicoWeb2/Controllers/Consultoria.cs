using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SindicoWeb2.Models;

namespace SindicoWeb2.Controllers
{
    public class Consultoria : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public Consultoria(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Gestao()
        {
            return View();
        }

        public IActionResult Outorga()
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
