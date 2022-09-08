﻿using System;
using System.ComponentModel.DataAnnotations;

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
