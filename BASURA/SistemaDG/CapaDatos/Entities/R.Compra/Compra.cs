using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos.Entities.R.Compra
{
    public class Compra : ConexionDB
    {
        private int idC;
	    private int idProd;
	    private int cantComprada;
        private float precioCompra;
        private int idEmpleado;
	    private DateTime fechaCompra;


        private int estado;

        public Compra() { }

        public Compra(int idC, int idProd, int cantComprada, float precioCompra, int idEmpleado, DateTime fechaCompra, int estado)
        {
            this.idC = idC;
            this.idProd = idProd;
            this.cantComprada = cantComprada;
            this.precioCompra = precioCompra;
            this.idEmpleado = idEmpleado;
            this.fechaCompra = fechaCompra;
            this.estado = estado;
        }

        public Compra(int idC, int idProd, int cantComprada, float precioCompra, int idEmpleado, DateTime fechaCompra)
        {
            this.idC = idC;
            this.idProd = idProd;
            this.cantComprada = cantComprada;
            this.precioCompra = precioCompra;
            this.idEmpleado = idEmpleado;
            this.fechaCompra = fechaCompra;
        }

        public Compra(int idProd, int cantComprada, float precioCompra, int idEmpleado, DateTime fechaCompra)
        {
            this.idProd = idProd;
            this.cantComprada = cantComprada;
            this.precioCompra = precioCompra;
            this.idEmpleado = idEmpleado;
            this.fechaCompra = fechaCompra;
        }


        public int IdC { get => idC; set => idC = value; }
        public int IdProd { get => idProd; set => idProd = value; }
        public int CantComprada { get => cantComprada; set => cantComprada = value; }
        public float PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }
        public int Estado { get => estado; set => estado = value; }

        //==========================================|| PROCEDIMENTOS ALMACENADOS ||==============================================//

        //VISUALIZAR
        public DataTable View_Compra()
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

                        comando.CommandText = "SP_VCompra";
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

        public void Insert_Compra(Compra c)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_INCompra"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@Prod", c.IdProd);
                    command.Parameters.AddWithValue("@Cant", c.CantComprada);
                    command.Parameters.AddWithValue("@Prec", c.PrecioCompra);
                    command.Parameters.AddWithValue("@Empleado", c.IdEmpleado);
                    command.Parameters.AddWithValue("@FechaCompra", c.FechaCompra);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------


        public void Update_Compra(Compra c)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_UPCompra"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@Id", c.IdC);
                    command.Parameters.AddWithValue("@Prod", c.IdProd);
                    command.Parameters.AddWithValue("@Cant", c.CantComprada);
                    command.Parameters.AddWithValue("@Prec", c.PrecioCompra);
                    command.Parameters.AddWithValue("@Empleado", c.IdEmpleado);
                    command.Parameters.AddWithValue("@FechaCompra", c.FechaCompra);
                    
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------

        //Desactivar un departamento
        public void Unsubscribe_Compra(int id)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = conection;

                    Command.CommandText = "SP_DBCompra";
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@id", id);

                   
                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                }
            }
        }//------------------------------

        public DataTable Search_Compra(string cadena)
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

                        Command.CommandText = "SP_Search_Compra";
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
