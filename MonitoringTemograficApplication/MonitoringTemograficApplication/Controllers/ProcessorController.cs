using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office.CustomXsn;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MonitoringTemograficApplication.Libraries.Filter;
using MonitoringTemograficApplication.Libraries.Login;
using MonitoringTemograficApplication.Models;
using MonitoringTemograficApplication.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoringTemograficApplication.Database
{
    //[ClientAuthorizationAttibute]
    public class ProcessorController : Controller
    {
        private MeasurementsContext _MeasurementsContext;
        private IProcessor _processorRepository;
        private LogingClient _LoginClient;
        public ProcessorController(IProcessor processorRepository, LogingClient LoginClient, MeasurementsContext MeasurementsContext)
        {
            _MeasurementsContext = MeasurementsContext;
            _LoginClient = LoginClient;
            _processorRepository = processorRepository;
        }


        public IActionResult Logout()
        {
            _LoginClient.Logout();
            return RedirectToAction("Login", "Termografic");
        }

        public IActionResult Index(int? page, string search)
        {

            var procesors = _processorRepository.GetAllProcessors(page, search);
            return View(procesors);
            return RedirectToAction("Index", "Processor");
        }
        public IActionResult MeasurementExist(int? page, string search)
        {
            var measurements = _processorRepository.GetAllMeasurements(page, search);
            return View(measurements);
            return RedirectToAction("MeasurementExist", "Processor");
        }

        public IActionResult MeasurementMissing(int? page, string search)
        {
            var measurements = _processorRepository.GetAllMeasurementsMising(page, search);
            return View(measurements);
            return RedirectToAction("MeasurementMissing", "Processor");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return RedirectToAction("ProcessorTermografic", "Termografic");
        }

        public JsonResult GetId(int id)
        {
            var measurent = _processorRepository.GetId(id);
            return Json(measurent);
        }

        [HttpPut]
        public JsonResult Edit(Measurements Measruremnt01)
        {
            _MeasurementsContext.Measurements.Update(Measruremnt01);
            _MeasurementsContext.SaveChanges();
            return Json(Measruremnt01);

        }
        public JsonResult Delet(Measurements Measruremnt01)
        {
            _MeasurementsContext.Measurements.Remove(Measruremnt01);
            _MeasurementsContext.SaveChanges();
            return Json(Measruremnt01);

        }

        [HttpGet]
        public IActionResult Report(string dateStart, string dateEnd, int? page)
        {
            DateRange dateRange = new DateRange();
            if (dateStart == null || dateEnd == null)
            {
                dateRange.dateStart = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd");
                dateRange.dateEnd = DateTime.Now.ToString("yyyy-MM-dd");
            }
            else
            {
                dateRange.dateStart = dateStart;
                dateRange.dateEnd = dateEnd;
            }
            var measurements = _processorRepository.GetReport(page, dateRange);
            return View(measurements);

            return RedirectToAction("Report", "Processor");

        }
        [HttpGet]
        public JsonResult PostReport(string dateStart, string dateEnd, int? page)
        {
            DateRange dateRange = new DateRange();
            if (dateStart == null || dateEnd == null)
            {
                dateRange.dateStart = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd");
                dateRange.dateEnd = DateTime.Now.ToString("yyyy-MM-dd");
            }
            else
            {
                dateRange.dateStart = dateStart;
                dateRange.dateEnd = dateEnd;
            }
            var resultado = _processorRepository.GetReports(page, dateRange);
            return Json(resultado);
        }
        [HttpGet]
        public IActionResult ExportXlsx(string dateStart, string dateEnd, int? page)
        {
            DateRange dateRange = new DateRange();
            if (dateStart == null || dateEnd == null)
            {
                dateRange.dateStart = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd");
                dateRange.dateEnd = DateTime.Now.ToString("yyyy-MM-dd");
            }
            else
            {
                dateRange.dateStart = dateStart;
                dateRange.dateEnd = dateEnd;
            }
            var resultado = _processorRepository.GetAllExport(dateRange);
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Relatorio");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "ID das Imagens";
                worksheet.Cell(currentRow, 2).Value = "Data";
                worksheet.Cell(currentRow, 3).Value = "Numero da panela";
                worksheet.Cell(currentRow, 4).Value = "Descrição da panela";
                worksheet.Cell(currentRow, 5).Value = "Rota";
                worksheet.Cell(currentRow, 6).Value = "Localização";
                


                foreach (var result in resultado)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = result.MeasurementKey;
                    worksheet.Cell(currentRow, 2).Value = result.Time;
                    worksheet.Cell(currentRow, 3).Value = result.LadleID;
                    worksheet.Cell(currentRow, 4).Value = result.LadleAge;
                    worksheet.Cell(currentRow, 5).Value = result.LadleDescription;
                    worksheet.Cell(currentRow, 6).Value = result.Origin;
                    worksheet.Cell(currentRow, 7).Value = result.Location;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "Aplication/vnd.openxmlformats-officedocument.soreadsheetml.sheet", "monitoramentotermograficos.xlsx");
                }


            }
            return View();
        }

    }



}

