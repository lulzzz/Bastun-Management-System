﻿namespace BMS.EntityConfigurations
{
    using BMS.Data;
    using BMS.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class AircraftConfiguration : IEntityTypeConfiguration<Aircraft>
    {
        public void Configure(EntityTypeBuilder<Aircraft> builder)
        {

            builder.HasKey(x => x.AircraftId);

            builder.HasOne(x => x.FuelForm)
               .WithOne(x => x.Aircraft)
               .HasForeignKey<FuelForm>(x => x.AircraftId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.WeightForm)
                .WithOne(x => x.Aircraft)
                .HasForeignKey<WeightForm>(x => x.AircraftId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Cabin)
                .WithOne(x => x.Aircraft)
                .HasForeignKey<AircraftCabin>(x => x.AircraftId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(x => x.BaggageHold)
                .WithOne(x => x.Aircraft)
                .HasForeignKey<AircraftBaggageHold>(x => x.AircraftId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
