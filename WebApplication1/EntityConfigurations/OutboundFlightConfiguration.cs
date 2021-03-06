﻿namespace BMS.EntityConfigurations
{
    using BMS.Data.LoadingInstructions;
    using BMS.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class OutboundFlightConfiguration : IEntityTypeConfiguration<OutboundFlight>
    {
        public void Configure(EntityTypeBuilder<OutboundFlight> builder)
        {

            builder.HasMany(x => x.OutboundMessages)
                .WithOne(x => x.OutboundFlight)
                .HasForeignKey(x => x.OutboundFlightId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.OutboundContainers)
                .WithOne(x => x.OutboundFlight)
                .HasForeignKey(x => x.OutboundFlightId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Aircraft)
                .WithOne(obF => obF.OutboundFlight)
                .HasForeignKey<Aircraft>(fk => fk.OutboundFlightId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.DepartureMovement)
                .WithOne(x => x.OutboundFlight)
                .HasForeignKey<DepartureMovement>(mvt => mvt.OutboundFlightId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.LoadingInstruction)
                .WithOne(x => x.OutboundFlight)
                .HasForeignKey<LoadingInstruction>(li => li.OutboundFlightId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
