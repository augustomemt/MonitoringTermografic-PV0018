using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoringTemograficApplication.Models
{
  public class Measurements
  {
    public int MeasurementKey { get; set; }

    public DateTime Time { get; set; }

    public int? LadleID { get; set; }

    public int? LadleAge { get; set; }

    public string RaceNumber { get; set; }

    public string Location { get; set; }


  }
}
