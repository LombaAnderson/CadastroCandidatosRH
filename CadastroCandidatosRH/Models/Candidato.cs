using System.ComponentModel.DataAnnotations;

namespace CadastroCandidatosRH.Models
{
    public class Candidato
    {
        
        [Key]
        [Required]
        public int Id { get;  set; }

        [Required(ErrorMessage = "O campo nome completo é obrigatório!")]
        public string Nome { get;  set; }

        [Required(ErrorMessage = "O campo RG é obrigatório!")]
        public string Documento { get;  set; }

        [Required(ErrorMessage = "O campo email é obrigatório!")]
        public string Email { get;  set; }

        [Required(ErrorMessage = "O campo competências é obrigatório!")]
        public string Competencias { get;  set; }
    }
}
