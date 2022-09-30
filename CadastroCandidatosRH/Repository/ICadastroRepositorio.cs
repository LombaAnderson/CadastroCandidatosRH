using CadastroCandidatosRH.Models;

namespace CadastroCandidatosRH.Repository
{
    public interface ICadastroRepositorio
    {
        CadastroCandidatoModel Adicionar(CadastroCandidatoModel cadastro);
        void Adicionar(CadastroEmpresaModel cadastro);
    }
}
