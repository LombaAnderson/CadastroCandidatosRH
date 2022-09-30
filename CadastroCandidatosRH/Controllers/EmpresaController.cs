using CadastroCandidatosRH.Models;
using CadastroCandidatosRH.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CadastroCandidatosRH.Controllers
{

    public class EmpresaController : Controller
    {
        private readonly ICadastroRepositorio _cadastroRepositorio;
        public EmpresaController(ICadastroRepositorio cadastroRepositorio)
        {
            _cadastroRepositorio = cadastroRepositorio;

        }
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

        [HttpPost]
        public IActionResult CriarEmpresa(Empresa cadastroCandidato)
        {
            _cadastroRepositorio.Adicionar(cadastroCandidato);
            return RedirectToAction("Index");
        }
    }
}
