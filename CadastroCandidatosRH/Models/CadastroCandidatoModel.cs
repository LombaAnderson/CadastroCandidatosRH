using System.ComponentModel.DataAnnotations;

namespace CadastroCandidatosRH.Models
{
    public class CadastroCandidatoModel: CadastroModel
    {
        public CadastroCandidatoModel(
            int id,
            string nome, 
            string cargo,
            string documento, 
            string email, 
            string competencias,
            string tecnologias): base(id, cargo,nome,documento,email,competencias,tecnologias)
        {
            Id = id;
            Nome= nome;
            Documento = documento;
            Email = email;
            Competencias = competencias;    
        }

        [Key]
        [Required]
        public int Id { get; private set; }

        [Required(ErrorMessage = "O campo nome completo é obrigatório!")]
        public string Nome { get; private set; }

        [Required(ErrorMessage = "O campo RG é obrigatório!")]
        public string Documento { get; private set; }

        [Required(ErrorMessage = "O campo email é obrigatório!")]
        public string Email { get; private set; }

        [Required(ErrorMessage = "O campo competências é obrigatório!")]
        public string Competencias { get; private set; }


    }
}
