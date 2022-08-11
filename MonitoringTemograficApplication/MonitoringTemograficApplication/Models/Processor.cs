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
        [Required(ErrorMessageResourceType = typeof(Menssage), ErrorMessageResourceName = "MSG_E001")]
        [StringLength(10, ErrorMessageResourceType = typeof(Menssage), ErrorMessageResourceName = "MSG_E001")]
        public string Corrida { get; set; }

        [Required(ErrorMessageResourceType = typeof(Menssage), ErrorMessageResourceName = "MSG_E001")]
        [StringLength(5, ErrorMessageResourceType = typeof(Menssage), ErrorMessageResourceName = "MSG_E001")]
        public string Panela { get; set; }
    }
}
