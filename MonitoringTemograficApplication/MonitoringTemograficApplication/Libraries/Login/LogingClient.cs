using MonitoringTemograficApplication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoringTemograficApplication.Libraries.Login
{
    public class LogingClient
    {
        private string Key = "Login.Cliente";
        private Session.Session _session;

        public LogingClient(Session.Session session)
        {
            _session = session;
        }



        public void Login(User cliente)
        {
            //Serializar
            string clienteJSONString = JsonConvert.SerializeObject(cliente);

            _session.Register(Key, clienteJSONString);
        }

        public User GetCliente()
        {
            //Deserializar
            if (_session.Exist(Key))
            {
                string clienteJSONString = _session.Search(Key);
                return JsonConvert.DeserializeObject<User>(clienteJSONString); ;
            }
            else
            {
                return null;
            }
        }

        public void Logout()
        {
            _session.RemoveAll();
        }
    }
}
