using CadastroCandidatosRH.Data;
using CadastroCandidatosRH.Models;

namespace CadastroCandidatosRH.Repository
{

    public class CandidatoRepositorio : ICandidatoRepositorio
    {
        private readonly CadastroContext _cadastroContext;
        public CandidatoRepositorio(CadastroContext cadastroContext)
        {
            _cadastroContext = cadastroContext;

        }


        public Candidato Adicionar(Candidato cadastro)
        {
            // Gravar no banco de dados

            _cadastroContext.Cadastros.Add(cadastro);
            _cadastroContext.SaveChanges();
            return cadastro;
        }



    }
}
