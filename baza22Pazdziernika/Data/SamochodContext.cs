using Microsoft.EntityFrameworkCore;

namespace baza.Data
{
    public class SamochodContext
    {
        public SamochodContext(DbContextOptions<SamochodContext> options) :base(options) { }
        public DbSet<Samochod> Samochody { get; set; }
    }
}
