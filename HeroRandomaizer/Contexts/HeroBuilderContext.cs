using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroRandomaizer.Models;
namespace HeroRandomaizer.Contexts
{
    public class HeroBuilderContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source = heroes.db");
        }

        public DbSet<Clans> Clans { get; set; }
        public DbSet<PowerAttributes> powerAttributes { get; set; }

        public DbSet<HeroModel> Heroes { get; set; }

    }
}
