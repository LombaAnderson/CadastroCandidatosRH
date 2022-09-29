using System.ComponentModel.DataAnnotations;

namespace CadastroCandidatosRH.Models
{
    public class CadastroEmpresaModel:CadastroModel

    {
        public CadastroEmpresaModel(
            int id, 
            string nome,
            string cargo, 
            string documento,
            string email, 
            string tecnologias,
            string competencias): base(id,nome,cargo,documento,email,tecnologias,competencias)
        {
            Id = id;
            Cargo = cargo;
            Nome = nome;
            Email = email;
            Tecnologias = tecnologias;  
        }


        [Key]
        [Required]
        public int Id { get; private set; }


        [Required(ErrorMessage = "O campo nome completo é obrigatório!")]

        public string Cargo { get; private set; }


        [Required(ErrorMessage = "O campo nome completo é obrigatório!")]

        public string Nome { get; set; }

        [Required(ErrorMessage ="O campo email é obrigatório")]
        public string Email { get; private set; }

        [Required(ErrorMessage ="O campo tecnologias é obrigatório")]
        public string Tecnologias { get; private set; }
    }
}
