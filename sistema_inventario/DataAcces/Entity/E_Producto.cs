using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAcces.Entity
{
    public class E_Producto : ConnectionToSQL
    {
        private int id_producto;
        private string nombre_producto;
        private decimal costo_producto;
        private decimal precio_producto;
        private int existencia_producto;
        private string demanda_producto;
        private float tasaM_producto;
        private int stockSeguridad_producto;
        private bool stado;

        public E_Producto(int id_producto, string nombre_producto, decimal costo_producto, decimal precio_producto, int existencia_producto, string demanda_producto, float tasaM_producto, int stockSeguridad_producto, bool stado)
        {
            this.id_producto = id_producto;
            this.nombre_producto = nombre_producto;
            this.costo_producto = costo_producto;
            this.precio_producto = precio_producto;
            this.existencia_producto = existencia_producto;
            this.demanda_producto = demanda_producto;
            this.tasaM_producto = tasaM_producto;
            this.stockSeguridad_producto = stockSeguridad_producto;
            this.estado_producto = stado;
        }

        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public decimal Costo_producto { get => costo_producto; set => costo_producto = value; }
        public decimal Precio_producto { get => precio_producto; set => precio_producto = value; }
        public int Existencia_producto { get => existencia_producto; set => existencia_producto = value; }
        public string Demanda_producto { get => demanda_producto; set => demanda_producto = value; }
        public float TasaM_producto { get => tasaM_producto; set => tasaM_producto = value; }
        public int StockSeguridad_producto { get => stockSeguridad_producto; set => stockSeguridad_producto = value; }

        public bool Estado { get => estado_producto; set => estado_producto = value; }


        public bool estado_producto { get => estado_producto; set => estado_producto = value; }



        public DataTable Search_product(string data)
        {
            DataTable res = new DataTable();
            try
            {
                using (var conection = GetConnection())
                {
                    conection.Open();
                    using (var Command = new SqlCommand())
                    {
                        Command.Connection = conection;

                        Command.CommandText = "SP_VIEW_PRODUCT";
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@dato", data);

                        SqlDataAdapter leer = new SqlDataAdapter(Command);
                        leer.Fill(res);

                        Command.ExecuteNonQuery();
                        Command.Parameters.Clear();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return res;
        }

        public void Insert_product(E_Producto producto)
        {
            using (var conection = GetConnection())
            {
                conection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = conection;

                    command.CommandText = "SP_INSERT_PRODUCT";
                    command.CommandType = CommandType.StoredProcedure;

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@nombre", producto.Nombre_producto);
                    command.Parameters.AddWithValue("@costo", producto.Costo_producto);
                    command.Parameters.AddWithValue("@precio", producto.Precio_producto);
                    command.Parameters.AddWithValue("@exist", producto.Existencia_producto);
                    command.Parameters.AddWithValue("ss", producto.StockSeguridad_producto);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void Update_producto(E_Producto producto)
        {
            using (var conection = GetConnection())
            {
                conection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = conection;

                    command.CommandText = "SP_UPDATE_PRODUCT";
                    command.CommandType = CommandType.StoredProcedure;

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@Id", producto.Id_producto);
                    command.Parameters.AddWithValue("@nombre", producto.Nombre_producto);
                    command.Parameters.AddWithValue("@costo", producto.Costo_producto);
                    command.Parameters.AddWithValue("@precio", producto.Precio_producto);
                    command.Parameters.AddWithValue("@exist", producto.Existencia_producto);
                    command.Parameters.AddWithValue("ss", producto.StockSeguridad_producto);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void Unsubscribe_producto(int id)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = conection;

                    Command.CommandText = "SP_DELETE_PRODUCT";
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@Id", id);

                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                }
            }
        }
    }
