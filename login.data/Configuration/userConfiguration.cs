using RETP.data.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace RETP.data.Configuration
{
    public class userConfiguration : IEntityTypeConfiguration<user>
    {
        public void Configure(EntityTypeBuilder<user> builder)
        {
            builder.ToTable("USER");
            builder.HasKey(x => x.UserID);
            builder.Property(x => x.userName).IsRequired();
            builder.Property(x => x.password).IsRequired();
            builder.Property(x => x.firstname);
            builder.Property(x => x.lastname);
            builder.Property(x => x.phoneNumber);
            builder.Property(x => x.email);
        }
    }
}
