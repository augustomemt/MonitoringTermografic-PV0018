using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MonitoringTemograficApplication.Libraries.Login;
using MonitoringTemograficApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoringTemograficApplication.Libraries.Filter
{
    public class ClientAuthorizationAttibute : Attribute, IAuthorizationFilter
    {
        LogingClient _loginCliente;
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _loginCliente = (LogingClient)context.HttpContext.RequestServices.GetService(typeof(LogingClient));
            User cliente = _loginCliente.GetCliente();
            if (cliente == null)
            {

                context.Result = new RedirectResult("/Home/Login"); 
                
            }
        }
    }
}
