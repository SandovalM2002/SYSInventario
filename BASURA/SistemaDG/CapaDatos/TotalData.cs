using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos
{
    public class TotalData : ConexionDB
    {
        private string Total_Inventario;
        private string Total_OrdenT;
        private string Total_OrdenC;
        private string Total_Cliente;

        public TotalData() { }

        public TotalData(string total_Inventario, string total_OrdenT, string total_OrdenC, string total_Cliente)
        {
            this.Total_Inventario = total_Inventario;
            this.Total_OrdenT = total_OrdenT;
            this.Total_OrdenC = total_OrdenC;
            this.Total_OrdenC = total_Cliente;
        }

        public string Total_Inventarios { get => Total_Inventario; set => Total_Inventario = value; }
        public string Total_OrdenTrabajo { get => Total_OrdenT; set => Total_OrdenT = value; }
        public string Total_OrdenCompra { get => Total_OrdenC; set => Total_OrdenC = value; }
        public string Total_Clientes { get => Total_Cliente; set => Total_Cliente = value; }
        
        //--------------------------------------------------//

        public void ShowTotal(TotalData d)
        {
            using (var connection = GetConnection()) {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = "SP_SumaryHome";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TI", 0);
                    command.Parameters.AddWithValue("@TC", 0);
                    command.Parameters.AddWithValue("@TOT", 0);
                    command.Parameters.AddWithValue("@TOC", 0);

                    command.ExecuteNonQuery();

                    d.Total_Inventarios = command.Parameters["@TI"].Value.ToString();
                    d.Total_Cliente = command.Parameters["@TC"].Value.ToString();
                    d.Total_OrdenCompra = command.Parameters["@TOC"].Value.ToString();
                    d.Total_OrdenTrabajo = command.Parameters["@TOT"].Value.ToString();
                    
                }//Second Using 
            }//Primary Using
        }
    }//-------------------------------------
}
