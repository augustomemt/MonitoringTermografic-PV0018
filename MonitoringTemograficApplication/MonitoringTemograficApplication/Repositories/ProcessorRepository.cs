using Microsoft.Extensions.Configuration;
using MonitoringTemograficApplication.Database;
using MonitoringTemograficApplication.Libraries.Login;
using MonitoringTemograficApplication.Models;
using MonitoringTemograficApplication.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace MonitoringTemograficApplication.Repositories
{
  public class ProcessorRepository : IProcessor
  {


    IConfiguration _config;
    MonitoringTermograficContext _context;
    LogingClient _logingClient;

    public ProcessorRepository(MonitoringTermograficContext context, IConfiguration configuration, LogingClient logingClient)
    {
      _context = context;
      _config = configuration;
      _logingClient = logingClient;
    }

    public IPagedList<TB_EXT_LD_LOG> GetAllProcessors(int? page, string search)
    {
      int RecordPage = _config.GetValue<int>("RecordPage");

      int NumberPage = page ?? 1;
      var TESTE = _context.TB_EXT_LD_LOG.ToList();
      var baseProcessor = TESTE.AsQueryable();

      if (!String.IsNullOrEmpty(search))
      {
        baseProcessor = baseProcessor.Where(a => a.cHeatNo.ToString().Contains(search.Trim())).OrderByDescending(a => a.dProcessor);
      }
      return baseProcessor.ToPagedList<TB_EXT_LD_LOG>(NumberPage, 10);
    }

    public void RegisterProcessor(TB_EXT_LD_LOG log)
    {
      _context.Add(log);
      _context.SaveChanges();

    }

    public bool processorChange(Processor processor)
    {
      using (SqlConnection connection = new SqlConnection(_config.GetConnectionString("SIMT")))
      {
        var time = DateTime.Now;
        SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Measurements]([Time],[LadleID],[HeatNumber],[cHeatNo])VALUES(@Time, @LaleID, @HeatNumber, @cHeatNo)", connection);
        command.Parameters.Add("@Time", SqlDbType.DateTime);
        command.Parameters["@Time"].Value = time;
        command.Parameters.Add("@LaleID", SqlDbType.SmallInt);
        command.Parameters["@LaleID"].Value = Convert.ToInt16(processor.Panela);
        command.Parameters.Add("@HeatNumber", SqlDbType.SmallInt);
        command.Parameters["@HeatNumber"].Value = Convert.ToInt16(processor.Corrida.Trim('A'));
        command.Parameters.Add("@cHeatNo", SqlDbType.VarChar);
        command.Parameters["@cHeatNo"].Value = 'A';

        try
        {
          connection.Open();
          var rowsAffected = command.ExecuteNonQuery();
          RegisterProcessor(new TB_EXT_LD_LOG { cHeatNo = processor.Corrida, cUser = _logingClient.GetCliente().Usuario, dProcessor = time, nLdNo = Convert.ToInt16(processor.Panela) });
          
          return true;
         
        }
        catch (Exception e)
        {
          return false;
        }

      }
      return false;
    }


  }
}
