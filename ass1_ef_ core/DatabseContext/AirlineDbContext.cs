using Microsoft.EntityFrameworkCore;
using System;
using ass1_ef__core.airlineModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_ef__core.DatabseContext
{
    internal class AirlineDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Airline;Trusted_Connection=true;TrustServerCertificate=true");
        }
        public DbSet<AirCraft> AirCrafts { get; set; }
        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Route> Route { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

    }
}
