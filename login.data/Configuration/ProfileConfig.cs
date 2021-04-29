using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using login.data.entities;
using System.Linq;

namespace login.data.Configuration
{
    public class ProfileConfig : IEntityTypeConfiguration<profile>
    {
        public void Configure(EntityTypeBuilder<profile> builder)
        {
        //    builder.ToTable("PROFILE");
        //    builder.HasKey(p => p.ProfileID);
        //    builder.HasOne(u => u.user).WithOne(p => p.profile)
        //        .HasForeignKey<user>(p=>p.UserID);
        //    builder.Property(p => p.Firstname);
        //    builder.Property(p => p.Lastname);
        //    builder.Property(p => p.PhoneNumber);
        //    builder.Property(p => p.Email);
        }
}
}
