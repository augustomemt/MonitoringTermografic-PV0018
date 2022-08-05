using Microsoft.Extensions.Configuration;
using MonitoringTemograficApplication.Database;
using MonitoringTemograficApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoringTemograficApplication.Repositories
{
  public class TermograficMonitoringRepository : ITermograficMonitoringcs
  {
    IConfiguration _config;
    MonitoringTermograficContext _context;

    public TermograficMonitoringRepository(MonitoringTermograficContext context, IConfiguration configuration)
    {
      _context = context;
      _config = configuration;
    }
    public void registerTermografic(Processor processor)
    {
      if(processor != null)
      {
         
      }
    }
  }
}
