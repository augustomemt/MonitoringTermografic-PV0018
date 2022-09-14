using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MonitoringTemograficApplication.Models
{
  public class Measurements
  {
    [Key]
    public Int64 MeasurementKey { get; set; }

    
    public DateTime Time { get; set; }

   
    public int? LadleID { get; set; }

    public int? LadleAge { get; set; }

    public string RaceNumber { get; set; }

    public string Location { get; set; }
  }
}
