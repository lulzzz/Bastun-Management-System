using System;
using System.Collections.Generic;
using System.Text;
using BMS.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Flight> Flights { get; set; }

        public DbSet<ArrivalMovement> ArrivalMovements { get; set; }

        public DbSet<DepartureMovement> DepartureMovements { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Flight>()
                .HasKey(x => x.FlightNumber);
                

            base.OnModelCreating(builder);
        }
    }
}
