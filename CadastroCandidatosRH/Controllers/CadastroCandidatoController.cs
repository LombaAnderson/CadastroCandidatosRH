using Microsoft.AspNetCore.Mvc;

namespace CadastroCandidatosRH.Controllers
{
    public class CadastroCandidatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CriarCandidato()
        {
            return View();
        }

        public IActionResult EditarCandidato()
        {
            return View();
        }

        public IActionResult DeletarCandidatoConfirmacao()
        {
            return View();
        }
    }
}
