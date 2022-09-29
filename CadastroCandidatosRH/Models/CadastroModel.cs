namespace CadastroCandidatosRH.Models
{
    public abstract class CadastroModel
    {
      
        protected CadastroModel(int id, string nome, object documento, string email, string tecnologias, string competencias)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Tecnologias = tecnologias;
            Competencias = competencias;
        }

        public int Id { get; private set; }

        public string Nome { get; private set; }        

        public int Documento { get;  private set; }

        public string Email{ get;  private set; }

        public string Competencias { get; set; }

        public string Tecnologias { get; private set; }

       
    }
}
