﻿using ClosedXML.Excel;
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


      return baseProcessor.ToPagedList<Measurements>(NumberPage, 10);
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
      var resultReport = _measurementsContext.Measurements.Where(m => m.LadleID != null && m.LadleAge != null && m.RaceNumber != null && m.Time >= Convert.ToDateTime(dateRange.dateStart) && m.Time <= Convert.ToDateTime(dateRange.dateEnd)).ToList().AsQueryable().OrderByDescending(d => d.Time);

      int totalRecords = resultReport.Count();
      if (page.HasValue)
      {
        resultReport = resultReport.Skip((NumberPage - 1) * 10).Take(10).OrderByDescending(s => s.Time);
      }

      int totalPages = (int)Math.Ceiling((double)totalRecords / 10);

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
      var resultReport = _measurementsContext.Measurements.Where(m => m.LadleID != null && m.LadleAge != null && m.RaceNumber != null  && m.Time >= Convert.ToDateTime(dateRange.dateStart) && m.Time <= Convert.ToDateTime(dateRange.dateEnd)).OrderByDescending(d => d.Time).ToList();
      return resultReport;
    }

    public byte[] GetFileExport(List<Measurements> results , DateRange dateRange)
    {

      using (var file = new XLWorkbook(@"C:\Users\Administrator\Desktop\ValidationCSP\MonitoringTermografic-PV0018\MonitoringTemograficApplication\MonitoringTemograficApplication\Template\MonitoramentoTermografico-Template.xlsx"))
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


  }
}
