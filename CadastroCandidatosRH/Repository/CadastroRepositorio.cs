using CadastroCandidatosRH.Data;
using CadastroCandidatosRH.Models;

namespace CadastroCandidatosRH.Repository
{

    public class CadastroRepositorio : ICadastroRepositorio
    {
        private readonly CadastroContext _cadastroContext;
        public CadastroRepositorio(CadastroContext cadastroContext)
        {
            _cadastroContext = cadastroContext;

        }

        public CadastroCandidatoModel Adicionar(CadastroCandidatoModel cadastro)
        {
            // Gravar no banco de dados

            _cadastroContext.Cadastros.Add(cadastro);
            _cadastroContext.SaveChanges();
            return cadastro;
        }

        public void Adicionar(CadastroEmpresaModel cadastro)
        {

        }
    }
}
