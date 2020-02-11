using Dapper;
using Microsoft.Win32.SafeHandles;
using MySql.Data.MySqlClient;
using Paleo_ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Paleo_ClassLibrary.Data
{
    public class MySqlConnect : IDisposable
    {
        private IDbConnection connection = null;

        public List<User> GetOsoby(User user)
        {
            try
            {
                var conString = Helper.ConnVal("STRAVA");

                using (connection = new MySqlConnection(conString))
                {
                    var p = new DynamicParameters();
                    p.AddDynamicParams(user);
                    var output = connection.Query<User>("GetUsers", p, commandType:CommandType.StoredProcedure).ToList();
                    return output;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Chyba při pokusu načíst všechny osoby u volání metody {ex.TargetSite.ReflectedType.FullName}. Zpráva {ex.Message}");
            }

        }

        #region IDisposable Support
        public void Dispose()
        {
            if (connection != null && connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
        #endregion
    }
}
