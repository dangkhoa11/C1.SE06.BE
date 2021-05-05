using RETP.data.Configuration;
using RETP.data.entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace RETP.data.ef
{
    public class RETPDBContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public RETPDBContext( DbContextOptions<RETPDBContext> options) : base(options)
        {
             
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new AppUserConfig());
            modelBuilder.ApplyConfiguration(new AppRoleConfig());
            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles");
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins");
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<AppUser> Users { get; set; }
         
    }
}
