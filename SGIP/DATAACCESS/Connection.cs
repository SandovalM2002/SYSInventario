using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATAACCESS
{
    public class Connection
    {
        //String solo lectura 
        private readonly string connectionString;

        //Constructor
        public Connection()
        {
           //conexion
            connectionString = "server=LAPTOP-44C1IQVO; DataBase =PanaderiaDb; Integrated Security = True";
        }

        //Solo accedido de una clase eradada
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
