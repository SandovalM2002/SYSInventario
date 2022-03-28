using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class ConexionDB
    {
        //String solo lectura 
        private readonly string connectionString;

        //Constructor
        public ConexionDB()
        {
            //omar
            connectionString = "server=tcp:OMARSANDOVAL\\SQLEXPRESS,1433; DataBase =ServiciosDG; Integrated Security = True";
            //fran
           // connectionString = "server=DESKTOP-GS6PUM7; DataBase =ServiciosDG; Integrated Security = True";
        }

        //Solo accedido de una clase eradada
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }//Final de la clase
}//---------------------------
