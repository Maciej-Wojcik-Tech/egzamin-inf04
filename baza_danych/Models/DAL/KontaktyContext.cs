using Microsoft.EntityFrameworkCore;

namespace baza_danych.Models.DAL
{
    public class KontaktyContext : DbContext
    {
        //public KontaktyContext. To jest nieintuicyjna nazwa, to jest główny plik do DB
        public DbSet<Kontakt> Kontakty { get; set; } // tabela kontakty
        public DbSet<Samochody> Samochody { get; set; } // tabela kontakty
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //ustawienie serwera SQL
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb;
         Database = BlogDetectiveDatabase; Trusted_Connection = True; ");

        }
    }
}
