using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI
{
    internal class CoctailsData : DbContext
    {
        public DbSet<Coctail> Coctails { get; set; }
        public CoctailsData()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Coctails.db");
        }

    }
}
