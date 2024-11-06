using Microsoft.EntityFrameworkCore;

namespace ZBazamiDanychProjekt.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Zadanie> Zadania { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        // Usuń metodę OnConfiguring
    }
}
