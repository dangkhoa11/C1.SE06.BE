using RETP.data.Configuration;
using RETP.data.entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RETP.data.ef
{
    public class RETPDBContext : IdentityDbContext<AppUser, AppRole, long>
    {
        public RETPDBContext( DbContextOptions<RETPDBContext> options) : base(options)
        {
             
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new userConfiguration());
            //modelBuilder.ApplyConfiguration(new ProfileConfig());

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<user> users { get; set; }
         
    }
}
