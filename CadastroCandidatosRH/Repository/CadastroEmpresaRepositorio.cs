//using CadastroCandidatosRH.Data;
//using CadastroCandidatosRH.Models;

//namespace CadastroCandidatosRH.Repository
//{
//    public class CadastroEmpresaRepositorio : ICadastroEmpresaRepositorio
//    {
//        private readonly CadastroContext _cadastroContext;
//        public CadastroEmpresaRepositorio(CadastroContext cadastroContext)
//        {
//            _cadastroContext = cadastroContext;

//        }

//        public Empresa Adicionar(Empresa empresas)
//        {
//            // Gravar no banco de dados

//            _cadastroContext.Empresas.Add(empresas);
//            _cadastroContext.SaveChanges();
//            return empresas;
//        }

//    }

//}
