using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RETP.data.entities;
using System.Linq;

namespace RETP.data.Configuration
{
    public class AppRoleConfig : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.ToTable("ROLE");
            builder.Property(x => x.Description).HasMaxLength(200).IsRequired();
        }
}
}
