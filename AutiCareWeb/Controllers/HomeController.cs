using AutiCare.Models;
using AutiCareWeb.Models;
using AutiCareWeb.Models.Banco;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace AutiCareWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //Receber aqui a instância do DbContext
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
        public IActionResult Index(Usuario usuario)
        {
            if (!ModelState.IsValid)
                return RedirectToAction(nameof(Index), usuario);

            GerenciadorRespostas.AdicionarRespostasUsuario(usuario);

            return RedirectToAction(nameof(Diagnostico));
        }

        public IActionResult Diagnostico()
        {
            Diagnostico diagnostico = new Diagnostico();
            return View(diagnostico);
        }
        [HttpPost]
        public IActionResult Diagnostico(Diagnostico diagnostico)
        {
            GerenciadorRespostas.AdicionarRespostasDiagnostico(diagnostico);

            //gravar no BD
            //GerenciadorRespostas.DevolverTabelaDiagnosticoPreenchido();

            return null;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
