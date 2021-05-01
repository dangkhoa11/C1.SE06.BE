using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace login.data.ef
{
    public class loginDbFactory : IDesignTimeDbContextFactory<loginDBContext>
    {
        public loginDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            var connectionString = configuration.GetConnectionString("RETPDb");
            var optionsBuilder = new DbContextOptionsBuilder<loginDBContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new loginDBContext(optionsBuilder.Options);
        }
    }
}
    