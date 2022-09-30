using CadastroCandidatosRH.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroCandidatosRH.Data
{
    public class CadastroContext: DbContext
    {
        public CadastroContext(DbContextOptions<CadastroContext> opt) : base(opt)
        {
                
        }

        public DbSet<Candidato> Cadastros { get; set; }
    }
}
