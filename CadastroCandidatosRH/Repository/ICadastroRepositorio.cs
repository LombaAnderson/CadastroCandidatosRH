using CadastroCandidatosRH.Models;

namespace CadastroCandidatosRH.Repository
{
    public interface ICadastroRepositorio
    {
        Candidato Adicionar(Candidato cadastro);
        void Adicionar(Empresa cadastro);
    }
}
