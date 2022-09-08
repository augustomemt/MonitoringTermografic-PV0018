using Microsoft.AspNetCore.Mvc;
using MonitoringTemograficApplication.Libraries.Filter;
using MonitoringTemograficApplication.Libraries.Login;
using MonitoringTemograficApplication.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoringTemograficApplication.Database
{
  [ClientAuthorizationAttibute]
  public class ProcessorController : Controller
  {
    private IProcessor _processorRepository;
    private LogingClient _LoginClient;
    public ProcessorController(IProcessor processorRepository, LogingClient LoginClient)
    {
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

    [HttpGet]
    public IActionResult Register()
    {
      return RedirectToAction("ProcessorTermografic", "Termografic");
    }


  }
 
}

