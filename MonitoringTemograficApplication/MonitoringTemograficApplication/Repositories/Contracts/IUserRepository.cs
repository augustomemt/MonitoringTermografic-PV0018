using MonitoringTemograficApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoringTemograficApplication.Repositories.Contracts
{
    public interface IUserRepository
    {
        public bool Login(string Name, string account);

    }
}
