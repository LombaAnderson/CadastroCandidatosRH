using System.ComponentModel.DataAnnotations;

namespace CadastroCandidatosRH.Models
{
    public class Empresa

    {     
        [Key]
        [Required]
        public int Id { get; private set; }


        [Required(ErrorMessage = "O campo nome completo é obrigatório!")]

        public string Nome { get; set; }

        [Required(ErrorMessage ="O campo email é obrigatório")]
        public string Email { get; private set; }

        [Required(ErrorMessage ="O campo tecnologias é obrigatório")]
        public string Tecnologias { get; private set; }

        [Required(ErrorMessage = "O campo vagas disponíveis é obrigatório!")]
        public string VagasDisponiveis { get; set; }
    }
}
