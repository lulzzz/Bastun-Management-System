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
            builder.HasKey(x => x.FlightId);

            builder.HasMany(x => x.InboundMessages)
                .WithOne(x => x.InboundFlight)
                .HasForeignKey(x => x.InboundFlightId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
