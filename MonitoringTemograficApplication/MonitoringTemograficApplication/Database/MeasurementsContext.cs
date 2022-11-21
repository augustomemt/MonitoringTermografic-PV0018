using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MonitoringTemograficApplication.Models;
using System.IO;

namespace MonitoringTemograficApplication.Database
{
  public class MeasurementsContext : DbContext
  {
    public DbSet<Measurements> Measurements { get; set; }

    public MeasurementsContext(DbContextOptions<MeasurementsContext> options) : base(options)
    {
     // ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

      //IConfiguration configuration = new ConfigurationBuilder()
      //.SetBasePath(Directory.GetCurrentDirectory())
      //.AddJsonFile("appsettings.json", false, true)
      //.Build();
      //optionsBuilder.UseSqlServer(configuration.GetConnectionString("SIMT"));

    }
  }
}
