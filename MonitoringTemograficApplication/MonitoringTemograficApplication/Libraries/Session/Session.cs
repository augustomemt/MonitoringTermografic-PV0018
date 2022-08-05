using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoringTemograficApplication.Libraries.Session
{
    public class Session
    {
        private readonly IHttpContextAccessor _context;       
        public Session(IHttpContextAccessor context)
        {
            _context = context;
        }

        public void Register(string Key, string Valor)
        {
            _context.HttpContext.Session.SetString(Key, Valor);
        }
        public void Update(string Key, string Valor)
        {
            if (Exist(Key))
            {
                _context.HttpContext.Session.Remove(Key);
            }
            _context.HttpContext.Session.SetString(Key, Valor);
        }
        public void Remove(string Key)
        {
            _context.HttpContext.Session.Remove(Key);
        }
        public string Search(string Key)
        {
            return _context.HttpContext.Session.GetString(Key);
        }

        public bool Exist(string Key)
        {
            if (_context.HttpContext.Session.GetString(Key) == null)
            {
                return false;
            }

            return true;
        }
        public void RemoveAll()
        {
            _context.HttpContext.Session.Clear();
        }
    }
}
