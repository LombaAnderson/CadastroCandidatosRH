using System.ComponentModel.DataAnnotations;

namespace CadastroCandidatosRH.Models
{
    public class Empresa

    {     
        [Key]
        [Required]
        public int Id { get;  set; }

        [Required(ErrorMessage = "O campo cargo é obrigatório!")]

        public string Cargo { get; set; }


        [Required(ErrorMessage = "O campo nome da empresa é obrigatório!")]

        public string Nome { get; set; }

        [Required(ErrorMessage ="O campo email é obrigatório")]
        public string Email { get;  set; }

        [Required(ErrorMessage ="O campo tecnologias requeridas é obrigatório")]
        public string Tecnologias { get;  set; }

        [Required(ErrorMessage = "O campo vagas disponíveis é obrigatório!")]
        public string VagasDisponiveis { get; set; }
    }
}
