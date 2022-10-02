using CadastroCandidatosRH.Models;
//using CadastroCandidatosRH.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CadastroCandidatosRH.Controllers
{
    public class CandidatoController : Controller
    {
        //private readonly ICadastroCandidatoRepositorio _cadastroRepositorio;
        //public CandidatoController(ICadastroCandidatoRepositorio cadastroRepositorio)
        //{
        //    _cadastroRepositorio = cadastroRepositorio;

        //}
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

        //[HttpPost]
        //public IActionResult CriarCandidato(Candidato cadastro)
        //{
        //    _cadastroRepositorio.Adicionar(cadastro);
        //    return RedirectToAction("Index");
        //}
    }
}
