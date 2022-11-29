using Microsoft.AspNetCore.Mvc;
using MonitoringTemograficApplication.Libraries.Login;
using MonitoringTemograficApplication.Models;
using MonitoringTemograficApplication.Repositories.Contracts;
using System;
using System.Linq;
using System.Net;


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
            try
            {
                _MeasurementsContext.Measurements.Update(Measruremnt01);
                _MeasurementsContext.SaveChanges();
                Response.StatusCode = (int)HttpStatusCode.OK;
                return Json(Measruremnt01);
            }
            catch
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json(new { Delet = false });
            }

        }
        [HttpDelete]
        public JsonResult Delete(string MeasurementKey)
        {
            try
            {
                Int64 id = Convert.ToInt64(MeasurementKey);
                var measurements = _MeasurementsContext.Measurements.Where(m => m.MeasurementKey == id).FirstOrDefault();
                _MeasurementsContext.Measurements.Remove(measurements);
                _MeasurementsContext.SaveChanges();
                Response.StatusCode = (int)HttpStatusCode.OK;
                return Json(new { Delet = true });
            }
            catch
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json(new { Delet = false });

            }

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
                try
                {
                    dateRange.dateStart = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd");
                    dateRange.dateEnd = DateTime.Now.ToString("yyyy-MM-dd");
                }
                catch
                {
                    return Json(new { PostReport = false });
                }

            }
            else
            {
                try
                {
                    dateRange.dateStart = dateStart;
                    dateRange.dateEnd = dateEnd;

                }
                catch
                {
                    return Json(new { PostReport = false });
                }

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
            var resultContent = _processorRepository.GetFileExport(resultado, dateRange);
            var name = DateTime.Now.ToString("yyyyMMddHHmmss") + "monitoramentotermograficos.xlsx";
            return File(resultContent, "Aplication/vnd.openxmlformats-officedocument.soreadsheetml.sheet", name);

            return View();
        }

    }



}

