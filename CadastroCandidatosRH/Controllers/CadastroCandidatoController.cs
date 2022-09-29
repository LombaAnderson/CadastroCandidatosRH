using CadastroCandidatosRH.Models;
using CadastroCandidatosRH.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CadastroCandidatosRH.Controllers
{
    public class CadastroCandidatoController : Controller
    {
        private readonly ICadastroRepositorio _cadastroRepositorio;
        public CadastroCandidatoController(ICadastroRepositorio cadastroRepositorio)
        {
            _cadastroRepositorio = cadastroRepositorio;

        }
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

        [HttpPost]
        public IActionResult CriarCandidato(CadastroCandidatoModel cadastro) 
        {
            _cadastroRepositorio.Adicionar(cadastro);
            return RedirectToAction("Index");
        }
    }
}
