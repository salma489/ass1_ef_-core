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

        protected override void OnModelCreating(ModelBuilder modelBuilder)



        {


            modelBuilder.Entity<AirCraft>()
       .Property(a => a.Id)
       .UseIdentityColumn();
            modelBuilder.Entity<Employee>()
                .HasOne(E => E.airline).WithMany(A => A.employees)
                .HasForeignKey(E => E.AirlineId);

            modelBuilder.Entity<AirCraft>().HasOne(a=>a.airCraftLine)
                .WithMany(c=>c.aircrafts).HasForeignKey(a=>a.airlineid);

            modelBuilder.Entity<Airline>().HasMany(a => a.transactions).WithOne(t => t.airlinetransaction)
                .HasForeignKey(t => t.airlinid);
            modelBuilder.Entity<AirCraft>().OwnsOne(a => a.crew);

            modelBuilder.Entity<Airline>()
        .HasMany(a => a.Phones)
        .WithOne(p => p.Airline)
        .HasForeignKey(p => p.AirlineId);



            modelBuilder.Entity<AirCraftRoute>()
                 .HasKey(ar => new { ar.AirCraftId, ar.RouteId });
            modelBuilder.Entity<AirCraftRoute>()
                .HasOne(ar => ar.AirCraft).WithMany(a => a.AirCraftRoutes)
            .HasForeignKey(ar=>ar.AirCraftId);


            modelBuilder.Entity<AirCraftRoute>()
                .HasOne(ar=>ar.Route).WithMany(r => r.AirCraftRoutes)
                .HasForeignKey(ar=>ar.RouteId);




                
        }
        public DbSet<AirCraft> AirCrafts { get; set; }
        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Route> Route { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<AirCraftRoute> AirCraftRoutes { get; set; }




    }
}
