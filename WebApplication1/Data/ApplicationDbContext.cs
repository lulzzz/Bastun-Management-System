using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using BMS.Data;
using BMS.Data.Models;
using BMS.Data.Models.Messages;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<InboundFlight> InboundFlights { get; set; }

        public DbSet<OutboundFlight> OutboundFlights { get; set; }

        public DbSet<ArrivalMovement> ArrivalMovements { get; set; }

        public DbSet<DepartureMovement> DepartureMovements { get; set; }

        public DbSet<Aircraft> Aircraft { get; set; }

        public DbSet<ContainerPalletMessage> ContainerPalletMessages { get; set; }

        public DbSet<LoadDistributionMessage> LoadDistributionMessages { get; set; }

        public DbSet<AircraftBaggageHold> AircraftBaggageHolds { get; set; }

        public DbSet<AircraftCabin> AircraftCabins { get; set; }

        public DbSet<FuelForm> FuelForms { get; set; }

        public DbSet<WeightForm> WeightForms { get; set; }

        public DbSet<Passenger> Passengers { get; set; }

        public DbSet<Container> Containers { get; set; }

        public DbSet<ContainerInfo> ContainerInfos { get; set; }

        public DbSet<Suitcase> Suitcases { get; set; }

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

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            builder.Entity<Message>().ToTable("Messages");

            base.OnModelCreating(builder);
        }
    }
}
