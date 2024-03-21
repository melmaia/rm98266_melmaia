using Evolutime.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Evolutime.Controllers
{
    public class AgradecimentoController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AgradecimentoController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Agradecimento()
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
