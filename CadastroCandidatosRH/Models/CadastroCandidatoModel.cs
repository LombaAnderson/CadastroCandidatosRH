using System.ComponentModel.DataAnnotations;

namespace CadastroCandidatosRH.Models
{
    public class CadastroCandidatoModel
    {
        //public CadastroCandidatoModel(
        //    int id,
        //    string nome, 
        //    string documento, 
        //    string email, 
        //    string competencias)
        //{
        //    Id = id;
        //    Nome= nome;
        //    Documento = documento;
        //    Email = email;
        //    Competencias = competencias;   
            
        //}

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
