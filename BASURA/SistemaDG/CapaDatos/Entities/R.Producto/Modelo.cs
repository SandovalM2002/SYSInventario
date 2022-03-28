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
    public class Modelo : ConexionDB
    {
        private int idModelo;
	    private string numeroModelo;
	    private int estModelo;

        public Modelo() { }

        public Modelo(int idModelo, string numeroModelo, int estModelo)
        {
            this.idModelo = idModelo;
            this.numeroModelo = numeroModelo;
            this.estModelo = estModelo;
        }

        public Modelo( string numeroModelo)
        {
            this.numeroModelo = numeroModelo;
        }

        public Modelo(int idModelo, string numeroModelo)
        {
            this.idModelo = idModelo;
            this.numeroModelo = numeroModelo;
        }

        public int IdModelo { get => idModelo; set => idModelo = value; }
        public string NumeroModelo { get => numeroModelo; set => numeroModelo = value; }
        public int EstModelo { get => estModelo; set => estModelo = value; }

        //=================================|| PROCEDIMIENTOS ALMACENADOS ||===============================//

        //VISUALIZAR
        public DataTable View_Modelo()
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

                        comando.CommandText = "SP_VModelo";
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

        public void Insert_Modelo(Modelo m)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_INModelo"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@NR", m.NumeroModelo);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------


        public void Update_Modelo(Modelo m)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_UPModelo"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@Id", m.IdModelo);
                    command.Parameters.AddWithValue("@NM", m.NumeroModelo);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------

        //Desactivar un departamento
        public void Unsubscribe_Modelo(int id)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = conection;

                    Command.CommandText = "SP_DBModelo";
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@id", id);

                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                    

                }
            }
        }//------------------------------

        public DataTable Search_Modelo(int id)
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

                        Command.CommandText = "SP_SAModelo";
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@id", id);

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
    }//----------
}//--------------
