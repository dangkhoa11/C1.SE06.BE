

using login.data.Configuration;
using login.data.entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace login.data.ef
{
    public class loginDBContext : IdentityDbContext<user>
    {
        public loginDBContext( DbContextOptions options) : base(options)
        {
             
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new userConfiguration());
            modelBuilder.ApplyConfiguration(new ProfileConfig());

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<user> users { get; set; }
         
    }
}
