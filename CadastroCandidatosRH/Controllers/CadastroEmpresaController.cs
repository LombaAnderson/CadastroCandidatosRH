using Microsoft.AspNetCore.Mvc;

namespace CadastroCandidatosRH.Controllers
{
    public class CadastroEmpresaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CriarEmpresa()
        {
            return View();
        }

        public IActionResult EditarEmpresa()
        {
            return View();
        }

        public IActionResult DeletarEmpresaConfirmacao()
        {
            return View();
        }
    }
}
