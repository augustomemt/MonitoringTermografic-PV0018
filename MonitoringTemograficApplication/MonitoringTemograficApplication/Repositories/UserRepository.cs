using Microsoft.Extensions.Configuration;
using MonitoringTemograficApplication.Database;
using MonitoringTemograficApplication.Models;
using MonitoringTemograficApplication.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoringTemograficApplication.Repositories
{
  public class UserRepository : IUserRepository
  {
    IConfiguration _config;
    MonitoringTermograficContext _context;

    public UserRepository(MonitoringTermograficContext context, IConfiguration configuration)
    {
      _context = context;
      _config = configuration;
    }
    public bool Login(string Name, string account)
    {
      using (SqlConnection connection = new SqlConnection("Server=VM-MEMT-14\\CSPNIVEL02;Database=EXT;user id=sa;password=metrum2002*;Trusted_Connection=False;"))
      {
        SqlCommand command = new SqlCommand("select pwdcompare(@passoword, [cPassWord]) from [EXT].[dbo].[TB_EXT_OP_CODE] where [cOpNam]=@User", connection);
        command.Parameters.Add("@passoword", SqlDbType.VarChar);
        command.Parameters["@passoword"].Value = account;
        command.Parameters.Add("@User", SqlDbType.VarChar);
        command.Parameters["@User"].Value = Name;
        try
        {
          connection.Open();
          var rowsAffected = command.ExecuteReader();
          while (rowsAffected.Read())
          {
            string treatment = rowsAffected[0].ToString();
            if(treatment == "1")
            {
              return true;
            }
            else
            {
              return false;
            }

          }
        }
        catch(Exception e)
        {
          return false;
        }
      }
      return false;
      
    }
  }
}
