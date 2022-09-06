using Microsoft.EntityFrameworkCore;
using MonitoringTemograficApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoringTemograficApplication.Database
{
    public class MonitoringTermograficContext : DbContext
    {
        /*
         * EF Core - ORM
         * ORM -> Bibliteca mapear Objetos para Banco de Dados Relacionais
         */
        public MonitoringTermograficContext(DbContextOptions<MonitoringTermograficContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<TB_EXT_LD_LOG> TB_EXT_LD_LOG { get; set; }

        public DbSet<TB_EXT_OP_CODE> TB_EXT_OP_CODE { get; set; }

      
  }
}
