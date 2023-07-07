using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace TestEmployeeEF.Models
{
    public class EFContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Contractor> Contractors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration iconfig = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            optionsBuilder.UseSqlServer(iconfig.GetConnectionString("MasterDatabase"));
        }
    }
}
