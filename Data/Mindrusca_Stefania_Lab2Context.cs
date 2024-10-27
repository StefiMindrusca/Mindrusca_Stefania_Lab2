using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mindrusca_Stefania_Lab2.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace Mindrusca_Stefania_Lab2.Data
{
    public class Mindrusca_Stefania_Lab2Context : DbContext
    {
        public Mindrusca_Stefania_Lab2Context (DbContextOptions<Mindrusca_Stefania_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Mindrusca_Stefania_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Mindrusca_Stefania_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Mindrusca_Stefania_Lab2.Models.Category> Category { get; set; } = default!;

    }
}
