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
    public class E_Material:ConnectionToSQL
    {
        private int id_material;
        private string nombre_material;
        private decimal costo_material;
        private int existencia_material;
        private int stockSeguridad_material;
        private bool estado_producto;

        public E_Material() { }

        public E_Material(int id_material, string nombre_material, decimal costo_material, int existencia_material, int stockSeguridad_material, bool estado_producto)
        {
            this.id_material = id_material;
            this.nombre_material = nombre_material;
            this.costo_material = costo_material;
            this.existencia_material = existencia_material;
            this.stockSeguridad_material = stockSeguridad_material;
            this.estado_producto = estado_producto;
        }

        public int Id_material { get => id_material; set => id_material = value; }
        public string Nombre_material { get => nombre_material; set => nombre_material = value; }
        public decimal Costo_material { get => costo_material; set => costo_material = value; }
        public int Existencia_material { get => existencia_material; set => existencia_material = value; }
        public int StockSeguridad_material { get => stockSeguridad_material; set => stockSeguridad_material = value; }
        public bool Estado_producto { get => estado_producto; set => estado_producto = value; }


        //STORAGE PROCEDURE METHODS
        public DataTable Search_View_Material(string data)
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

                        Command.CommandText = "SP_VIEW_MATERIAL";
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

        public void Insert_Material(E_Material m)
        {
            using (var conection = GetConnection())
            {
                conection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = conection;

                    command.CommandText = "SP_INSERT_MATERIAL";
                    command.CommandType = CommandType.StoredProcedure;

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@nombre", m.Nombre_material);
                    command.Parameters.AddWithValue("@costo", m.Costo_material);
                    command.Parameters.AddWithValue("@exist", m.Existencia_material);
                    command.Parameters.AddWithValue("ss", m.StockSeguridad_material);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void Update_Material(E_Material m)
        {
            using (var conection = GetConnection())
            {
                conection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = conection;

                    command.CommandText = "SP_UPDATE_MATERIAL";
                    command.CommandType = CommandType.StoredProcedure;

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@Id", m.Id_material);
                    command.Parameters.AddWithValue("@nombre", m.Nombre_material);
                    command.Parameters.AddWithValue("@costo", m.Costo_material);
                    command.Parameters.AddWithValue("@exist", m.Existencia_material);
                    command.Parameters.AddWithValue("ss", m.StockSeguridad_material);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void Unsubscribe_Material(int id)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = conection;

                    Command.CommandText = "SP_DELETE_MATERIAL";
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@Id", id);

                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                }
            }
        }
    }
}
