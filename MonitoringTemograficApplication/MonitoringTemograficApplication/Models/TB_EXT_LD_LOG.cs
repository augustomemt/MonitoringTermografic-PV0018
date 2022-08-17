using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoringTemograficApplication.Models
{
    public class TB_EXT_LD_LOG
    {
        [Key]
        public DateTime dProcessor { get; set; }
        public string cUser { get; set; }
        public string cHeatNo { get; set; }
        public Int16 nLdNo { get; set; }
        public int nLadleAge { get; set; }



  }
}
