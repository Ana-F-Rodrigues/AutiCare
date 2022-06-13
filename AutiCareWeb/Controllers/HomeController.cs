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
        private readonly AutiCareDbContext _dbContext;

        //Receber aqui a instância do DbContext
        public HomeController(ILogger<HomeController> logger,
            AutiCareDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
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
            var tableDiagnostico = GerenciadorRespostas.DevolverTabelaDiagnosticoPreenchido();
            _dbContext.TableDiagnostico.Add(tableDiagnostico);
            _dbContext.SaveChanges();

            var resultado = diagnostico.DiagnosticoFinal();

            return RedirectToAction(nameof(ResultadoDiagnostico), new { valorResultado = resultado } );
        }

        public IActionResult ResultadoDiagnostico(bool valorResultado)
        {
            ViewData["Resultado"] = $"O resultado foi: {valorResultado}";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
