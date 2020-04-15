namespace BMS.EntityConfigurations
{
    using BMS.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class InboundFlightConfiguration : IEntityTypeConfiguration<InboundFlight>
    {
        public void Configure(EntityTypeBuilder<InboundFlight> builder)
        {

            builder.HasMany(x => x.InboundMessages)
                .WithOne(x => x.InboundFlight)
                .HasForeignKey(x => x.InboundFlightId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.ArrivalMovement)
                .WithOne(x => x.InboundFlight)
                .HasForeignKey<ArrivalMovement>(x => x.InboundFlightId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.InboundContainers)
                .WithOne(x => x.InboundFlight)
                .HasForeignKey(x => x.InboundFlightId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
