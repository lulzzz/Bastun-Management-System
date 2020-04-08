namespace BMS.EntityConfigurations
{
    using System;
    using System.Collections.Generic;
    using BMS.Models;
    using System.Linq;
    using System.Threading.Tasks;
    using BMS.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ContainerConfiguration : IEntityTypeConfiguration<Container>
    {
        public void Configure(EntityTypeBuilder<Container> builder)
        {
            builder.HasOne(x => x.ContainerInfo)
                .WithOne(x => x.Container)
                .HasForeignKey<ContainerInfo>(x => x.ContainerInfoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
