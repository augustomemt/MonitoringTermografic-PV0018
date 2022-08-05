using MonitoringTemograficApplication.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoringTemograficApplication.Models
{
    public class User
    {
       

        [Required(ErrorMessageResourceType = typeof(Menssage), ErrorMessageResourceName = "MSG_E001")]        
        public string Usuario { get; set; }

        // [Required(ErrorMessageResourceType = typeof(Menssage), ErrorMessageResourceName = "MSG_E001")]
        // [MinLength(6, ErrorMessageResourceType = typeof(Menssage), ErrorMessageResourceName = "MSG_E002")]
        [Required(ErrorMessageResourceType = typeof(Menssage), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(2, ErrorMessageResourceType = typeof(Menssage), ErrorMessageResourceName = "MSG_E002")]
        public string Senha { get; set; }
    }
}
