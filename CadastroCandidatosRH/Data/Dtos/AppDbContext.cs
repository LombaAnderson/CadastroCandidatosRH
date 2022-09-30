using CadastroCandidatosRH.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroCandidatosRH.Data.Dtos
{
    public class AppDbContext
    {
        public DbSet<Candidato> Candidatos { get; set; }

        public DbSet<Empresa> Empresas { get; set; }


    }
}
