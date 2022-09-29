using System.ComponentModel.DataAnnotations;

namespace CadastroCandidatosRH.Models
{
    public class CadastroModel
    {
      
        public CadastroModel(int id, string nome, string cargo, string documento, string email, string tecnologias, string competencias)
        {
            Id = id;
            Nome = nome;
            Cargo = cargo;
            Documento = documento;
            Email = email;
            Tecnologias = tecnologias;
            Competencias = competencias;
        }
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome completo é obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo cargo é obrigatório!")]
        public string Cargo { get; set; }

        [Required(ErrorMessage = "O campo RG é obrigatório!")]
        public string Documento { get;  set; }

        [Required(ErrorMessage = "O campo email é obrigatório!")]
        public string Email{ get;  set; }

        [Required(ErrorMessage = "O campo competências é obrigatório!")]
        public string Competencias { get; set; }

        [Required(ErrorMessage = "O campo tecnologias é obrigatório!")]
        public string Tecnologias { get; set; }

       
    }
}
