using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pasca_Denisa_Laborator2.Models;

namespace Pasca_Denisa_Laborator2.Data
{
    public class Pasca_Denisa_Laborator2Context : DbContext
    {
        public Pasca_Denisa_Laborator2Context (DbContextOptions<Pasca_Denisa_Laborator2Context> options)
            : base(options)
        {
        }

        public DbSet<Pasca_Denisa_Laborator2.Models.Book> Book { get; set; } = default!;

        public DbSet<Pasca_Denisa_Laborator2.Models.Publisher> Publisher { get; set; }

        public DbSet<Pasca_Denisa_Laborator2.Models.Author> Author { get; set; }
    }
}
