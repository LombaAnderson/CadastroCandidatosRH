using CadastroCandidatosRH.Models;
//using CadastroCandidatosRH.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CadastroCandidatosRH.Controllers
{

    public class EmpresaController : Controller
    {
        //private readonly ICadastroCandidatoRepositorio _cadastroRepositorio;
        //public EmpresaController(ICadastroCandidatoRepositorio cadastroRepositorio)
        //{
        //    _cadastroRepositorio = cadastroRepositorio;

        //}
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

        //[HttpPost]
        //public IActionResult CriarEmpresa(Empresa empresas)
        //{
        //    _cadastroRepositorio.Adicionar(empresas);
        //    return RedirectToAction("Index");
        //}
    }
}
