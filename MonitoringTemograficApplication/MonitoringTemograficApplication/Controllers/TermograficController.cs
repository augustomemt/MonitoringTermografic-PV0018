using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MonitoringTemograficApplication.Libraries.Filter;
using MonitoringTemograficApplication.Libraries.Login;
using MonitoringTemograficApplication.Models;
using MonitoringTemograficApplication.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MonitoringTemograficApplication.Controllers
{

  public class TermograficController : Controller
  {
    private LogingClient _LoginClient;
    private IUserRepository _userRepository;
    private IProcessor _processor;
    public TermograficController(LogingClient LoginClient, IUserRepository Userrepository, IProcessor processor)
    {
      _LoginClient = LoginClient;
      _userRepository = Userrepository;
      _processor = processor;
    }

    public IActionResult Index()
    {
      return View();
    }

    [ClientAuthorizationAttibute]
    public IActionResult ProcessorTermografic()
    {
      return View();
    }
    [HttpPost]
    public IActionResult ProcessorTermografic([FromForm] Processor client)
    {

     

      if (ModelState.IsValid)
      {
      


        var result = _processor.processorChange(client);
        if (result != false)
        {
          return RedirectToAction("Index", "Processor");
        }
        else
        {
          ViewData["MSG_A"] = "Algo deu errado ao processar";
          return View();
        }



      }
      else
      {
        StringBuilder sb = new StringBuilder();
        foreach (var text in ModelState)
        {
          foreach (var err in text.Value.Errors)
          {
            sb.Append(err.ErrorMessage + "<br />");
          }

        }
        ViewData["MSG_E"] = sb.ToString();

      }
      return View();
    }
    [HttpPost]
    public IActionResult Cancel()
    {
      return RedirectToAction("index", "Processor");
    }

    [ClientAuthorizationAttibute]
    public IActionResult Privacy()
    {
      return View();

    }

    public IActionResult Logout()
    {
      _LoginClient.Logout();
      return RedirectToAction("Login", "Termografic");
    }

    [HttpGet]
    public IActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Login([FromForm] User client)
    {
      if (ModelState.IsValid)
      {
        bool userDB = _userRepository.Login(client.Usuario, client.Senha);

        if (userDB != false)
        {
          _LoginClient.Login(client);

          return RedirectToAction("Index", "Processor");
        }
        else
        {
          ViewData["MSG_E"] = "Usuário não encontrado, verifique o usuário e senha digitado!";
          return View();
        }
      }
      else
      {
        StringBuilder sb = new StringBuilder();
        foreach (var text in ModelState)
        {
          foreach (var err in text.Value.Errors)
          {
            sb.Append(err.ErrorMessage);
          }

        }
        ViewData["MSG_E"] = sb.ToString();
      }


      var model = ModelState;
      return View();
    }

  }
}
