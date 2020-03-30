using System;
using System.Collections.Generic;
using System.Text;
using BMS.Data.Models;
using BMS.Data.Models.Messages;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Flight> Flights { get; set; }

        public DbSet<ArrivalMovement> ArrivalMovements { get; set; }

        public DbSet<DepartureMovement> DepartureMovements { get; set; }

        public DbSet<LoadDistributionMessage> LoadDistributionMessages { get; set; }

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
                .HasKey(x => x.FlightId);

            builder.Entity<Flight>()
                .HasOne(x => x.DepartureMovement)
                .WithOne(x => x.Flight)
                .HasForeignKey<DepartureMovement>(depMvt => depMvt.FlightRef);


            builder.Entity<Flight>()
                .HasOne(x => x.ArrivalMovement)
                .WithOne(x => x.Flight)
                .HasForeignKey<ArrivalMovement>(arrMvt => arrMvt.FlightRef);

            builder.Entity<Flight>()
                .HasOne(x => x.LDM)
                .WithOne(x => x.Flight)
                .HasForeignKey<LoadDistributionMessage>(ldm => ldm.FlightRef);

            base.OnModelCreating(builder);
        }
    }
}
