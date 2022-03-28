using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Entities
{
    public class Tipo_Producto : ConexionDB
    {
        private int idTProd;
	    private string nombreTP;
	    private string descTP;
	    private int modeloTP;
	    private string serieTP;
	    private int estadoTP;

        public Tipo_Producto () { }

        public Tipo_Producto(int idTProd, string nombreTP, string descTP, int modeloTP, string serieTP, int estadoTP)
        {
            this.idTProd = idTProd;
            this.nombreTP = nombreTP;
            this.descTP = descTP;
            this.modeloTP = modeloTP;
            this.serieTP = serieTP;
            this.estadoTP = estadoTP;
        }

        public Tipo_Producto(int idTProd, string nombreTP, string descTP, int modeloTP, string serieTP)
        {
            this.idTProd = idTProd;
            this.nombreTP = nombreTP;
            this.descTP = descTP;
            this.modeloTP = modeloTP;
            this.serieTP = serieTP;
        }
        public Tipo_Producto( string nombreTP, string descTP, int modeloTP, string serieTP)
        {
            this.nombreTP = nombreTP;
            this.descTP = descTP;
            this.modeloTP = modeloTP;
            this.serieTP = serieTP;
        }

        public int IdTProd { get => idTProd; set => idTProd = value; }
        public string NombreTP { get => nombreTP; set => nombreTP = value; }
        public string DescTP { get => descTP; set => descTP = value; }
        public int ModeloTP { get => modeloTP; set => modeloTP = value; }
        public string SerieTP { get => serieTP; set => serieTP = value; }
        public int EstadoTP { get => estadoTP; set => estadoTP = value; }

        //=====================================|| PROCEDIMIENTOS ALMACENADOS || =======================//

        //VISUALIZAR
        public DataTable View_TipoProducto()
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

                        comando.CommandText = "SP_VTProducto";
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

        public void Insert_TipoProducto(Tipo_Producto tp)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_TProducto"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@NTP",tp.NombreTP);
                    command.Parameters.AddWithValue("@DescTP",tp.DescTP);
                    command.Parameters.AddWithValue("@MTP",tp.ModeloTP);
                    command.Parameters.AddWithValue("@STP",tp.SerieTP);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------


        public void Update_TipoProducto(Tipo_Producto tp)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_UPTProducto"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@Id", tp.IdTProd);
                    command.Parameters.AddWithValue("@NTP", tp.NombreTP);
                    command.Parameters.AddWithValue("@DescTP", tp.DescTP);
                    command.Parameters.AddWithValue("@MTP", tp.ModeloTP);
                    command.Parameters.AddWithValue("@STP", tp.SerieTP);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------

        //Desactivar un departamento
        public void Unsubscribe_TipoProducto(int id)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = conection;

                    Command.CommandText = "SP_DBTProducto";
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@id", id);
                    
                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                }
            }
        }//------------------------------

        public DataTable Search_TipoProducto(string cadena)
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

                        Command.CommandText = "SP_Search_TProducto";
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

    }//--------
}//------------
