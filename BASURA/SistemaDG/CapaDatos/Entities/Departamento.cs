using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos.Entities
{
    public class Departamento : ConexionDB
    {
        private int idDepto;
	    private string nombreDepto;
	    private int estadoDepto;
        
        public Departamento() { }

        public Departamento(int idDepto, string nombreDepto, int estadoDepto)
        {
            this.idDepto = idDepto;
            this.nombreDepto = nombreDepto;
            this.estadoDepto = estadoDepto;
        }


        public Departamento(string nombreDepto)
        {
            this.nombreDepto = nombreDepto;
        }


        public Departamento(int idDepto, string nombreDepto)
        {
            this.idDepto = idDepto;
            this.nombreDepto = nombreDepto;
        }


        public int IdDepto { get => idDepto; set => idDepto = value; }
        public string NombreDepto { get => nombreDepto; set => nombreDepto = value; }
        public int EstadoDepto { get => estadoDepto; set => estadoDepto = value; }

        //==================================||PROCEDIMIENTOS ALMACENADOS||=====================================//

        //VISUALIZAR
        public DataTable View_Departamento()
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

                        comando.CommandText = "SP_VDepartamento";
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

        public void Insert_Departamento(Departamento d)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_INDepartamento"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@ND",d.NombreDepto);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------


        public void Update_Departamento(Departamento d)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_UPDepartamento"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@Id", d.IdDepto);
                    command.Parameters.AddWithValue("@ND", d.NombreDepto);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------

        //Desactivar un departamento
        public void Unsubscribe_Departamento(int id)
        {
            using (var conection = GetConnection())
            {
                conection.Open();

                using (var Command = new SqlCommand())
                {
                    Command.Connection = conection;

                    Command.CommandText = "SP_DBDepartamento";
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@id", id);
                    
                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                }
            }
        }//------------------------------

        public DataTable Search_Departamento(int id)
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

                        Command.CommandText = "SP_SADepartamento";
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

    }//------------
}//----------------
