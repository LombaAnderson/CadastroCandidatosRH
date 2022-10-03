using AutoMapper;
using CadastroCandidatosRH.Data;
using CadastroCandidatosRH.Data.Dtos;
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

        private CadastroContext _context;
        private IMapper _mapper; 
        public IActionResult Index(CadastroContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            return View();
        }

        public IActionResult CriarCandidato(CreateCandidatoDto CandidatoDto)
        {
            Candidato candidato = _mapper.Map<Candidato>(CandidatoDto);
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
