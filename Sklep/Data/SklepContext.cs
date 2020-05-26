using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sklep.Models;

namespace Sklep.Data
{
    public class SklepContext : DbContext
    {
        public SklepContext (DbContextOptions<SklepContext> options)
            : base(options)
        {
        }

        public DbSet<Produkty> Produkty { get; set; }
        public DbSet<Kategorie> Kategorie { get; set; }
        public DbSet<Producenci> Producenci { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produkty>().ToTable("Produkty");
            modelBuilder.Entity<Kategorie>().ToTable("Kategorie");
            modelBuilder.Entity<Producenci>().ToTable("Producenci");
        } 
    }
}
