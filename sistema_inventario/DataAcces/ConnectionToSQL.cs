using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    public class ConnectionToSQL
    {
        private readonly string connectionString;

        public ConnectionToSQL()
        {
            connectionString = "server = DESKTOP-CG4DUQL; DataBase = MAYER; Integrated Security = True";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
