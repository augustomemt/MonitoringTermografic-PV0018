using MonitoringTemograficApplication.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace MonitoringTemograficApplication.Models
{

  public class Processor
  {

    
    [Range(0,9, ErrorMessageResourceType = typeof(Menssage), ErrorMessageResourceName = "MSG_E001")]
    public int Corrida { get; set;}
 

    
    [Range(0, 4, ErrorMessageResourceType = typeof(Menssage), ErrorMessageResourceName = "MSG_E001")]
    public int Panela { get; set; }

    
    [Range(0, 4, ErrorMessageResourceType = typeof(Menssage), ErrorMessageResourceName = "MSG_E001")]
    public int VidaPanela { get; set; }
  }
}
