using System.ComponentModel.DataAnnotations;

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


        [Key]
        [Required]
        public int Id { get; private set; }

        [Required(ErrorMessage = "O campo nome completo é obrigatório!")]
        public string Nome { get; private set; }

        [Required(ErrorMessage ="O campo email é obrigatório")]
        public string Email { get; private set; }

        [Required(ErrorMessage ="O campo tecnologias é obrigatório")]
        public string Tecnologias { get; private set; }
    }
}
