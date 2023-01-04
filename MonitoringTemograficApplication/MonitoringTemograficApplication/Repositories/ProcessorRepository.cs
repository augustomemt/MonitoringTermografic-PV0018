using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Extensions.Configuration;
using MonitoringTemograficApplication.Database;
using MonitoringTemograficApplication.Libraries.Login;
using MonitoringTemograficApplication.Models;
using MonitoringTemograficApplication.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace MonitoringTemograficApplication.Repositories
{
  public class ProcessorRepository : IProcessor
  {


    IConfiguration _config;
    MonitoringTermograficContext _context;
    MeasurementsContext _measurementsContext;
    LogingClient _logingClient;


    public ProcessorRepository(MonitoringTermograficContext context, IConfiguration configuration, LogingClient logingClient, MeasurementsContext measurementsContext)
    {
      _measurementsContext = measurementsContext;
      _context = context;
      _config = configuration;
      _logingClient = logingClient;

    }

    public IPagedList<TB_EXT_LD_LOG> GetAllProcessors(int? page, string search)
    {
      int RecordPage = _config.GetValue<int>("RecordPage");

      int NumberPage = page ?? 1;
      var baseProcessor = _context.TB_EXT_LD_LOG.ToList().AsQueryable().OrderByDescending(d => d.dProcessor);


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
        command.Parameters["@LaleID"].Value = (processor.Panela);
        command.Parameters.Add("@HeatNumber", SqlDbType.SmallInt);
        command.Parameters["@HeatNumber"].Value = (processor.Corrida);
        command.Parameters.Add("@cHeatNo", SqlDbType.VarChar);
        command.Parameters["@cHeatNo"].Value = 'A';
        command.Parameters.Add("@LadleAge", SqlDbType.SmallInt);
        command.Parameters["@LadleAge"].Value = (processor.VidaPanela);

        try
        {
          connection.Open();
          var rowsAffected = command.ExecuteNonQuery();
          RegisterProcessor(new TB_EXT_LD_LOG { cHeatNo = Convert.ToString((processor.Corrida)), cUser = _logingClient.GetCliente().Usuario, dProcessor = time, nLdNo = Convert.ToInt16(processor.Panela), nLadleAge = Convert.ToInt32(processor.VidaPanela) });

          return true;

        }
        catch (Exception e)
        {
          return false;
        }

      }
      return false;
    }


    public IPagedList<Measurements> GetAllMeasurements(int? page, string search)
    {
      int RecordPage = _config.GetValue<int>("RecordPage");

      int NumberPage = page ?? 1;
      var baseProcessor = _measurementsContext.Measurements.Where(m => m.LadleID != null && m.LadleAge != null && m.RaceNumber != null /*&& m.Location != null*/ ).ToList().AsQueryable().OrderByDescending(d => d.Time);


      return baseProcessor.ToPagedList<Measurements>(NumberPage, 10);
    }
    public Measurements GetId(int id)
    {
      var measurements = _measurementsContext.Measurements.Where(m => m.MeasurementKey == id).FirstOrDefault();
      return (measurements);
    }

    public IPagedList<Measurements> GetAllMeasurementsMising(int? page, string search)
    {
      int RecordPage = _config.GetValue<int>("RecordPage");

      int NumberPage = page ?? 1;
      var baseProcessor = _measurementsContext.Measurements.Where(m => m.LadleID == null || m.LadleAge == null || m.RaceNumber == null).ToList().AsQueryable().OrderByDescending(d => d.Time);


      return baseProcessor.ToPagedList<Measurements>(NumberPage, 20);
    }

    public IPagedList<Measurements> GetReport(int? page, DateRange dateRange)
    {
      int RecordPage = _config.GetValue<int>("RecordPage");

      int NumberPage = page ?? 1;
      var start = Convert.ToDateTime(dateRange.dateStart);
      var end = Convert.ToDateTime(dateRange.dateEnd);
      var resultReport = _measurementsContext.Measurements.Where(m => m.LadleID != null && m.LadleAge != null && m.RaceNumber != null && m.Time >= Convert.ToDateTime(dateRange.dateStart) && m.Time <= Convert.ToDateTime(dateRange.dateEnd)).ToList().AsQueryable().OrderByDescending(d => d.Time);



      return resultReport.ToPagedList<Measurements>(NumberPage, 10);
    }
    public dynamic GetReports(int? page, DateRange dateRange)
    {


      int NumberPage = page ?? 1;
      var start = Convert.ToDateTime(dateRange.dateStart);
      var end = Convert.ToDateTime(dateRange.dateEnd);
      var resultReport = _measurementsContext.Measurements.Where(m => m.LadleID != null && m.LadleAge != null && m.RaceNumber != null && m.Origin != null && m.LadleDescription != null && m.Location != null && m.Time >= Convert.ToDateTime(dateRange.dateStart) && m.Time <= Convert.ToDateTime(dateRange.dateEnd)).ToList().AsQueryable().OrderByDescending(d => d.Time);

      int totalRecords = resultReport.Count();
      var size = 15;
      switch (totalRecords)
      {

        case int i when (i <= 100):
          size = 10;
          break;
        case int i when (i <= 300):
          size = 25;
          break;
        case int i when (i <= 500):
          size = 50;
          break;
        case int i when (i <= 1000):
          size = 100;
          break;

      }
      if (page.HasValue)
      {
        resultReport = resultReport.Skip((NumberPage - 1) * 10).Take(size).OrderByDescending(s => s.Time);
      }

      int totalPages = (int)Math.Ceiling((double)totalRecords / size);

      var result = new
      {
        measurements = resultReport,
        totalRecords = totalRecords,
        totalPages = totalPages
      };

      return result;
    }

    public List<Measurements> GetAllExport(DateRange dateRange)
    {
      var start = Convert.ToDateTime(dateRange.dateStart);
      var end = Convert.ToDateTime(dateRange.dateEnd);
      var resultReport = _measurementsContext.Measurements.Where(m => m.LadleID != null && m.LadleAge != null && m.RaceNumber != null && m.Time >= Convert.ToDateTime(dateRange.dateStart) && m.Time <= Convert.ToDateTime(dateRange.dateEnd)).OrderByDescending(d => d.Time).ToList();
      return resultReport;
    }

    public byte[] GetFileExport(List<Measurements> results, DateRange dateRange)
    {
      var currentDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
      using (var file = new XLWorkbook(currentDirectory + "/Template/MonitoramentoTermografico-Template.Xlsx"))
      {

        var ws = file.Worksheet(1);


        ws.Cell("B2").Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        ws.Cell("B4").Value = dateRange.dateStart;
        ws.Cell("E4").Value = dateRange.dateEnd;

        int startRow = 9;
        int colum = 1;


        foreach (var result in results)
        {
          colum = 1;
          ws.Cell(startRow, colum++).Value = result.MeasurementKey;
          ws.Cell(startRow, colum++).Value = result.Time;
          ws.Cell(startRow, colum++).Value = result.LadleID;
          ws.Cell(startRow, colum++).Value = result.LadleAge;
          ws.Cell(startRow, colum++).Value = result.RaceNumber;
          ws.Cell(startRow, colum++).Value = result.Location;
          ws.Cell(startRow, colum++).Value = result.Origin;
          ws.Cell(startRow, colum++).Value = result.LadleDescription;
          ws.Cell(startRow, colum++).Value = result.OriginDescription;

          startRow++;
        }
        using (var stream = new MemoryStream())
        {
          file.SaveAs(stream);
          var content = stream.ToArray();
          return content;
        }
      }

    }
    public bool Delete(string MeasurementKey)
    {
      {
        try
        {
          Int64 id = Convert.ToInt64(MeasurementKey);
          using (SqlConnection connection = new SqlConnection(_config.GetConnectionString("SIMT")))
          {
            SqlCommand command = new SqlCommand("DELETE FROM [LadleCheck3].[dbo].[Measurements]  where MeasurementKey = @Measureid  DELETE FROM [LadleCheck3].[dbo].[MeasurementResults]  where MeasurementKey =@Measureid  DELETE FROM [LadleCheck3].[dbo].[MeasurementResultImages]  where MeasurementKey =@Measureid  DELETE FROM [LadleCheck3].[dbo].[MeasurementThresholds]  where MeasurementKey =@Measureid", connection);
            command.Parameters.Add("@Measureid", SqlDbType.BigInt);
            command.Parameters["@Measureid"].Value = id;
            connection.Open();
            var rowsAffected = command.ExecuteNonQuery();
          }
          return true;
        }
        catch
        {

          return false;

        }
      }
    }

    public bool Processor()
    {
      using (SqlConnection connection = new SqlConnection(_config.GetConnectionString("SIMT")))
      {

        try
        {
          SqlCommand baseProcessor = new SqlCommand("spMEMT_UpdateMeasurement", connection);
          connection.Open();
          baseProcessor.ExecuteNonQuery();

          return true;

        }
        catch
        {
          return false;

        }
      }
    }

  }
}


