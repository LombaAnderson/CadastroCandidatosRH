namespace CadastroCandidatosRH.Models
{
    public class CadastroCandidatoModel: CadastroModel
    {
        public CadastroCandidatoModel(
            int id,
            string nome, 
            int documento, 
            string email, 
            string competencias,
            string tecnologias): base(id,nome,documento,email,competencias,tecnologias)
        {
            Id = id;
            Nome= nome;
            Documento = documento;
            Email = email;
            Competencias = competencias;    
        }

        public int Id { get; private set; }

        public string Nome { get; private set; }

        public int Documento { get; private set; }

        public string Email { get; private set; }

        public string Competencias { get; private set; }


    }
}
