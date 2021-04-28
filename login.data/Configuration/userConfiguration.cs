using login.data.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace login.data.Configuration
{
    public class userConfiguration : IEntityTypeConfiguration<user>
    {
        public void Configure(EntityTypeBuilder<user> builder)
        {
            builder.ToTable("USER");
            builder.HasKey(x => x.UserID);
            builder.Property(x => x.userName).IsRequired();
            builder.Property(x => x.password).IsRequired(); 
        }
    }
}
