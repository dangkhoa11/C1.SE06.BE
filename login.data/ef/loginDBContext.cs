using login.data.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace login.data.ef
{
    public class loginDBContext : DbContext
    {
        public loginDBContext( DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<user> users { get; set; }
    }
}
