﻿namespace BMS.EntityConfigurations
{
    using BMS.Data.Models.Messages;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class ContainerPalletMessageConfiguration : IEntityTypeConfiguration<ContainerPalletMessage>
    {
        public void Configure(EntityTypeBuilder<ContainerPalletMessage> builder)
        {
      
            builder.HasMany(x => x.ContainerInfo)
                .WithOne(x => x.ContainerPalletMessage)
                .HasForeignKey(x => x.ContainerPalletMessageId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
