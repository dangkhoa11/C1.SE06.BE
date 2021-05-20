using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RETP.data.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RETP.data.Configuration
{
    public class ProductConfig : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.ToTable("RE");
            builder.HasKey(x => x.RE_ID);
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.ImagePath).IsRequired();
            builder.Property(x => x.Address).IsRequired();
            builder.Property(x => x.Longitude).IsRequired();
            builder.Property(x => x.Latitude).IsRequired();
        }
    }
}
