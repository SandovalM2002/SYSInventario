using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATAACCESS.entities.Producto
{
    public class Producto:Connection
    {
        /*id_prod SMALLINT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	nombre_prod VARCHAR(50) NOT NULL,
	costo_prod DECIMAL(5,2) NOT NULL,
	existencia_prod SMALLINT NOT NULL,
	precio_prod DECIMAL (5,2) NULL,
	estado_prod BIT DEFAULT 1,*/

        private int id_prod;
        private string nombre_prod;
        private decimal costo_prod;
        private int existencia_prod;
        private decimal precio_prod;
        private int estado;

        public Producto() { }

        public Producto(int id_prod, string nombre_prod, decimal costo_prod, int existencia_prod, decimal precio_prod, int estado)
        {
            this.id_prod = id_prod;
            this.nombre_prod = nombre_prod;
            this.costo_prod = costo_prod;
            this.existencia_prod = existencia_prod;
            this.precio_prod = precio_prod;
            this.estado = estado;
        }

        public Producto(int id_prod, string nombre_prod, decimal costo_prod, int existencia_prod, decimal precio_prod)
        {
            this.id_prod = id_prod;
            this.nombre_prod = nombre_prod;
            this.costo_prod = costo_prod;
            this.existencia_prod = existencia_prod;
            this.precio_prod = precio_prod;
        }

        public Producto(string nombre_prod, decimal costo_prod, int existencia_prod, decimal precio_prod)
        {
            this.nombre_prod = nombre_prod;
            this.costo_prod = costo_prod;
            this.existencia_prod = existencia_prod;
            this.precio_prod = precio_prod;
        }

        public int IdProd { get => id_prod; set => id_prod = value; }
        public string NombreProd { get => nombre_prod; set => nombre_prod = value; }
        public decimal CostoProd { get => costo_prod; set => costo_prod = value; }
        public int ExistenciaProd { get => existencia_prod; set => existencia_prod = value; }
        public decimal PrecioProd { get => precio_prod; set => precio_prod = value; }
        public int Estado { get => estado; set => estado = value; }

        //==========================================|| PROCEDIMIENTOS ALMACENADOS || ============================//
        //VISUALIZAR
        public DataTable View_Producto()
        {
            DataTable res = new DataTable();
            try
            {
                using (var coneccion = GetConnection())
                {
                    coneccion.Open();
                    using (var comando = new SqlCommand())
                    {
                        comando.Connection = coneccion;

                        comando.CommandText = "SP_VIEW_PRODUCTO";
                        comando.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter adp = new SqlDataAdapter(comando);
                        adp.Fill(res);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return res;
        }//-------------------------------


    }
}
