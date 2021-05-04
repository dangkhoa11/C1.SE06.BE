using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RETP.data.ef
{
    public class RETPDbFactory : IDesignTimeDbContextFactory<RETPDBContext>
    {
        public RETPDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            var connectionString = configuration.GetConnectionString("RETPDb");
            var optionsBuilder = new DbContextOptionsBuilder<RETPDBContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new RETPDBContext(optionsBuilder.Options);
        }
    }
}
    