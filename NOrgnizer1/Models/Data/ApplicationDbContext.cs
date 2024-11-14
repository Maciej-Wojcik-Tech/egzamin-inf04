using Microsoft.EntityFrameworkCore;
using NOrgnizer1.Models;
namespace NOrgnizer1.Models.Data;


/*
 
włączanie migracji

Enable-Migrations


Update-Database

Add-Migration

 */

public class ApplicationDbContext : DbContext
{


    public DbSet<Zadanie> Zadania { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb;
            Database = BlogDetectiveDatabase; Trusted_Connection = True; ");

    }


}