using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ferencz_Levente_Lab8.Models;

namespace Ferencz_Levente_Lab8.Data
{
    public class Ferencz_Levente_Lab8Context : DbContext
    {
        public Ferencz_Levente_Lab8Context (DbContextOptions<Ferencz_Levente_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Ferencz_Levente_Lab8.Models.Book> Book { get; set; }

        public DbSet<Ferencz_Levente_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Ferencz_Levente_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
