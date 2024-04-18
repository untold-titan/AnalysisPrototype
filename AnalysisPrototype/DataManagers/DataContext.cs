using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalysisPrototype.Data;
using Microsoft.EntityFrameworkCore;

namespace AnalysisPrototype.DataManagers
{
    internal class DataContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        public DataContext()
        {
            SQLitePCL.Batteries_V2.Init();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "data.sqlite");
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}
