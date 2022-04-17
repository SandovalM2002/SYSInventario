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
    public class E_Stock : ConnectionToSQL
    {
        private int id;
        private string nombre;
        private bool tipo;
        private decimal costo;
        private decimal precio;
        private int stock;
        private int stock_s;
        private int total;
        private bool estado;

        public E_Stock(int id, string nombre, bool tipo, decimal costo, decimal precio, int stock, int stock_s, int total, bool estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.tipo = tipo;
            this.costo = costo;
            this.precio = precio;
            this.stock = stock;
            this.stock_s = stock_s;
            this.total = total;
            this.estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public bool Tipo { get => tipo; set => tipo = value; }
        public decimal Costo { get => costo; set => costo = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Stock_s { get => stock_s; set => stock_s = value; }
        public int Total { get => total; set => total = value; }
        public bool Estado { get => estado; set => estado = value; }

        #region "STORAGE PROCEDURE IN DATABASE"

        public DataTable View_Stock(string data, bool t)
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

                        Command.CommandText = "SP_VIEW_SEARCH_STOCK";
                        Command.CommandType = CommandType.StoredProcedure;


                        Command.Parameters.AddWithValue("@dato", data);
                        Command.Parameters.AddWithValue("@T", t);

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

        public void Insert_Stock(E_Stock producto)
        {
            using (var conection = GetConnection())
            {
                conection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = conection;

                    command.CommandText = "SP_ADD_STOCK";
                    command.CommandType = CommandType.StoredProcedure;

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@N", producto.Nombre);
                    command.Parameters.AddWithValue("@T", producto.Tipo);
                    command.Parameters.AddWithValue("@C", producto.Costo);
                    command.Parameters.AddWithValue("@P", producto.Precio);
                    command.Parameters.AddWithValue("@E", producto.Stock);
                    command.Parameters.AddWithValue("@SS", producto.Stock_s);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void Update_Stock(E_Stock producto)
        {
            using (var conection = GetConnection())
            {
                conection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = conection;

                    command.CommandText = "SP_UPDATE_STOCK";
                    command.CommandType = CommandType.StoredProcedure;

                    //Parametros del Procedimiento almacenado
                    
                    command.Parameters.AddWithValue("@Id", producto.Id);
                    command.Parameters.AddWithValue("@N", producto.Nombre);
                    command.Parameters.AddWithValue("@T", producto.Tipo);
                    command.Parameters.AddWithValue("@C", producto.Costo);
                    command.Parameters.AddWithValue("@P", producto.Precio);
                    command.Parameters.AddWithValue("@E", producto.Stock);
                    command.Parameters.AddWithValue("@SS", producto.Stock_s);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void Unsubscribe_Stock(int id)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = conection;

                    Command.CommandText = "SP_DELETE_STOCK";
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@Id", id);

                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                }
            }
        }

        #endregion
    }
}
