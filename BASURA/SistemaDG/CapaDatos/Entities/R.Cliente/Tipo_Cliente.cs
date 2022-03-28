using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos.Entities.R.Cliente
{
    public class Tipo_Cliente : ConexionDB
    {
        private int idTC;
	    private string nombreTC;
        private string descrTC;
	    private int estado;

        public Tipo_Cliente() { }

        public Tipo_Cliente(int idTC, string nombreTC, string descrTC, int estado)
        {
            this.idTC = idTC;
            this.nombreTC = nombreTC;
            this.descrTC = descrTC;
            this.estado = estado;
        }

        public Tipo_Cliente(int idTC, string nombreTC, string descrTC)
        {
            this.idTC = idTC;
            this.nombreTC = nombreTC;
            this.descrTC = descrTC;
        }

        public Tipo_Cliente( string nombreTC, string descrTC)
        {
            this.nombreTC = nombreTC;
            this.descrTC = descrTC;
        }

        public int IdTC { get => idTC; set => idTC = value; }
        public string NombreTC { get => nombreTC; set => nombreTC = value; }
        public string DescrTC { get => descrTC; set => descrTC = value; }
        public int Estado { get => estado; set => estado = value; }

        //=========================|| PROCEDIMIENTOS ALMACENADIOS ||=========================//
        //VISUALIZAR
        public DataTable View_TipoCliente()
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

                        comando.CommandText = "SP_VTCliente";
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

        public void Insert_TipoCliente(Tipo_Cliente tc)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_INTCliente"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@NTC", tc.NombreTC);
                    command.Parameters.AddWithValue("@DSC", tc.DescrTC);


                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------

        public void Update_TipoCliente(Tipo_Cliente tc)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_UPTClieten"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@id", tc.IdTC);
                    command.Parameters.AddWithValue("@NTC", tc.NombreTC);
                    command.Parameters.AddWithValue("@DSC", tc.DescrTC);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------

        //Desactivar un departamento
        public void Unsubscribe_TipoCliente(int id)
        {
            using (var conection = GetConnection())
            {
                conection.Open();

                using (var Command = new SqlCommand())
                {
                    Command.Connection = conection;

                    Command.CommandText = "SP_DBTCliente";
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@id", id);

                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                }
            }
        }//------------------------------

        public DataTable Search_TipoCliente(string cadena)
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

                        Command.CommandText = "SP_Search_TCliente";
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@Dato ",cadena);

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
    }//-------
}//-----------
