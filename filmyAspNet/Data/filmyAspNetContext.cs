using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using filmyAspNet.Models;

namespace filmyAspNet.Data
{
    public class filmyAspNetContext : DbContext
    {
        public filmyAspNetContext (DbContextOptions<filmyAspNetContext> options)
            : base(options)
        {
        }

        public DbSet<filmyAspNet.Models.Movie> Movie { get; set; } = default!;
    }
}
