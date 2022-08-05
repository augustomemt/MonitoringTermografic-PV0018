using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoringTemograficApplication.Models
{
    public class TB_EXT_OP_CODE
    {
        [Key]
        public string cEmpNo { get; set; }
        public string cOpNam { get; set; }

    }
}
