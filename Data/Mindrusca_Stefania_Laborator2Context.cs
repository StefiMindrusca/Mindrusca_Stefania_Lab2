using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mindrusca_Stefania_Laborator2.Models;

namespace Mindrusca_Stefania_Laborator2.Data
{
    public class Mindrusca_Stefania_Laborator2Context : DbContext
    {
        public Mindrusca_Stefania_Laborator2Context (DbContextOptions<Mindrusca_Stefania_Laborator2Context> options)
            : base(options)
        {
        }

        public DbSet<Mindrusca_Stefania_Laborator2.Models.Book> Book { get; set; } = default!;
        public DbSet<Mindrusca_Stefania_Laborator2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Mindrusca_Stefania_Laborator2.Models.Author> Author { get; set; } = default!;
    }
}
