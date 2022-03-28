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
    public class DevOrden_Compra : ConexionDB
    {

        private int idDev;
	    private int idOrden;
	    private int cantidadDev;
        private string observacion;
	    private DateTime fechaDev;
        private int estado;

        public DevOrden_Compra() { }

        public DevOrden_Compra(int idDev, int idOrden, int cantidadDev, string observacion, DateTime fechaDev, int estado)
        {
            this.idDev = idDev;
            this.idOrden = idOrden;
            this.cantidadDev = cantidadDev;
            this.observacion = observacion;
            this.fechaDev = fechaDev;
            this.estado = estado;
        }

        public DevOrden_Compra(int idDev, int idOrden, int cantidadDev, string observacion, DateTime fechaDev)
        {
            this.idDev = idDev;
            this.idOrden = idOrden;
            this.cantidadDev = cantidadDev;
            this.observacion = observacion;
            this.fechaDev = fechaDev;
        }

        public DevOrden_Compra( int idOrden, int cantidadDev, string observacion, DateTime fechaDev)
        {
            this.idOrden = idOrden;
            this.cantidadDev = cantidadDev;
            this.observacion = observacion;
            this.fechaDev = fechaDev;
        }

        public int IdDev { get => idDev; set => idDev = value; }
        public int IdOrden { get => idOrden; set => idOrden = value; }
        public int CantidadDev { get => cantidadDev; set => cantidadDev = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public DateTime FechaDev { get => fechaDev; set => fechaDev = value; }
        public int Estado { get => estado; set => estado = value; }

        //=====================================|| Procedimientos almacenados ||===================================//

        //VISUALIZAR
        public DataTable View_DevOrdenCompra()
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

                        comando.CommandText = "SP_VDevOrdenCompra";
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

        public void Insert_DevOrdenCompra(DevOrden_Compra dev)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_INDevOrdenCompra"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@IdOrd", dev.IdOrden);
                    command.Parameters.AddWithValue("@CantDev",dev.CantidadDev);
                    command.Parameters.AddWithValue("@Observion",dev.Observacion);
                    command.Parameters.AddWithValue("@FechaDev",dev.FechaDev);
                    
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------


        public void Update_DevOrdenCompra(DevOrden_Compra dev)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_UPDevOrdenCompra"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@ID", dev.IdDev);
                    command.Parameters.AddWithValue("@IdOrd", dev.IdOrden);
                    command.Parameters.AddWithValue("@CantDev", dev.CantidadDev);
                    command.Parameters.AddWithValue("@Observion", dev.Observacion);
                    command.Parameters.AddWithValue("@FechaDev", dev.FechaDev);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------

        //Desactivar un departamento
        public void Unsubscribe_DevOrdenCompra(int id)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = conection;

                    Command.CommandText = "SP_DBDevOrdenCompra";
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@id", id);

                    
                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                }
            }
        }//------------------------------

        public DataTable Search_DevOrdenCompra(string cadena)
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

                        Command.CommandText = "SP_Search_DevOrdenCompra";
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

    }//------
}//----------
