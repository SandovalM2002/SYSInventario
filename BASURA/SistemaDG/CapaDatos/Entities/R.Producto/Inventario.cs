using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos.Entities.R.Producto
{
    public class Inventario : ConexionDB
    {
        private int idInv;
	    private int idProd;
	    private int exist;
        private float precioP;
        private int estado;

        public Inventario() { }

        public Inventario(int idInv, int idProd, int exist, float precioP, int estado)
        {
            this.idInv = idInv;
            this.idProd = idProd;
            this.exist = exist;
            this.precioP = precioP;
            this.estado = estado;
        }

        public Inventario(int idInv, int idProd, int exist, float precioP)
        {
            this.idInv = idInv;
            this.idProd = idProd;
            this.exist = exist;
            this.precioP = precioP;
        }

        public Inventario(int idProd, int exist, float precioP)
        {
            this.idProd = idProd;
            this.exist = exist;
            this.precioP = precioP;
        }


        public int IdInv { get => idInv; set => idInv = value; }
        public int IdProd { get => idProd; set => idProd = value; }
        public int Exist { get => exist; set => exist = value; }
        public float PrecioP { get => precioP; set => precioP = value; }
        public int Estado { get => estado; set => estado = value; }


        //=================================|| PROCEDIMIENTOS ALMACENADOS ||===============================//

        //VISUALIZAR
        public DataTable View_Inventario()
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

                        comando.CommandText = "SP_VInventario";
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

        public void Insert_Inventario(Inventario i)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_INInventario"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando
                    
                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@IdProd", i.IdProd);
                    command.Parameters.AddWithValue("@Exist", i.Exist);
                    command.Parameters.AddWithValue("@Precio", i.PrecioP);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------


        public void Update_Inventario(Inventario i)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_UPInventario"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@Id", i.IdInv);
                    command.Parameters.AddWithValue("@IdProd", i.IdProd);
                    command.Parameters.AddWithValue("@Exist", i.Exist);
                    command.Parameters.AddWithValue("@Precio", i.PrecioP);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------

        //Desactivar un departamento
        public void Unsubscribe_Inventario(int id)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = conection;

                    Command.CommandText = "SP_DBInventario";
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@id", id);

                    
                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                }
            }
        }//------------------------------

        public DataTable Search_Inventario(string cadena)
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

                        Command.CommandText = "SP_Search_Inventario";
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@Dato", cadena);

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
        }//--------------------------------

    }
}
