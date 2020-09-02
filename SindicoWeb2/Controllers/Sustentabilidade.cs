using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SindicoWeb2.Models;

namespace SindicoWeb2.Controllers
{
    public class Sustentabilidade : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public Sustentabilidade(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Coleta()
        {
            return View();
        }
           public IActionResult Tratamento()
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
