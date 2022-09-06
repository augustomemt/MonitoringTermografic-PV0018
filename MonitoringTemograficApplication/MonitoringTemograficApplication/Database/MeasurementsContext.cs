using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MonitoringTemograficApplication.Models;

namespace MonitoringTemograficApplication.Database
{
  public class MeasurementsContext: DbContext
  {
    public DbSet<Measurements> measurements { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      IConfiguration configuration = new ConfigurationBuilder()
      .SetBasePath(Directory.GetCurrentDirectory())
      .AddJsonFile("appsettings.json", false, true)
      .Build();
      optionsBuilder.UseSqlServer(configuration.GetConnectionString("SIMT"));

    }

  }
}
