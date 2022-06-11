using AutiCare.Modelos;
using AutiCareWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace AutiCareWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Usuario usuario = new Usuario();

            return View(usuario);
        }

        [HttpPost]
        public IActionResult CriarUsuario(Usuario usuario)
        {
            if (!ModelState.IsValid)
                return RedirectToAction(nameof(Index), usuario);

            //Gravar no banco

            return RedirectToAction(nameof(Diagnostico));
        }

        public IActionResult Diagnostico()
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
