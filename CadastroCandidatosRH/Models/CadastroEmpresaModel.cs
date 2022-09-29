namespace CadastroCandidatosRH.Models
{
    public class CadastroEmpresaModel:CadastroModel

    {
        public CadastroEmpresaModel(
            int id, 
            string nome, 
            string documento,
            string email, 
            string tecnologias,
            string competencias): base(id,nome,documento,email,tecnologias,competencias)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Tecnologias = tecnologias;  
        }

        public int Id { get; private set; }

        public string Nome { get; private set; }

        public string Email { get; private set; }

        public string Tecnologias { get; private set; }
    }
}
