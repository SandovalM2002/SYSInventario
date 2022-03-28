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
    public class Ubicacion : ConexionDB
    {
        //Variables
        private int idUbicacion;
	    private string nombrePais;
	    private string deptoPais;
	    private int estUbicacaion;
        //Constructor Getter and Setter
        public Ubicacion () { }

        public Ubicacion(int idUbicacion, string nombrePais, string deptoPais, int estUbicacaion)
        {
            this.idUbicacion = idUbicacion;
            this.nombrePais = nombrePais;
            this.deptoPais = deptoPais;
            this.estUbicacaion = estUbicacaion;
        }

        public Ubicacion(int idUbicacion, string nombrePais, string deptoPais)
        {
            this.idUbicacion = idUbicacion;
            this.nombrePais = nombrePais;
            this.deptoPais = deptoPais;
        }

        public Ubicacion( string nombrePais, string deptoPais)
        {
            this.nombrePais = nombrePais;
            this.deptoPais = deptoPais;
        }

        public int IdUbicacion { get => idUbicacion; set => idUbicacion = value; }
        public string NombrePais { get => nombrePais; set => nombrePais = value; }
        public string DeptoPais { get => deptoPais; set => deptoPais = value; }
        public int EstUbicacaion { get => estUbicacaion; set => estUbicacaion = value; }

        //============================|| PROCEDIMIENTOS ALMACENADO ||========================//

        //VISUALIZAR
        public DataTable View_Ubicacion()
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

                        comando.CommandText = "SP_VUbicacion";
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

        public void Insert_Ubicacion(Ubicacion u)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_INUbicacion"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@NPU", u.NombrePais);
                    command.Parameters.AddWithValue("@DPU",u.DeptoPais);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------


        public void Update_Ubicacion(Ubicacion u)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_UPUbicacion"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@Id",u.IdUbicacion);
                    command.Parameters.AddWithValue("@NPU", u.NombrePais);
                    command.Parameters.AddWithValue("@NDU", u.DeptoPais);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------

        //Desactivar una Ubicacion
        public void Unsubscribe_Ubicacion(int id)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = conection;

                    Command.CommandText = "SP_DBUbicacion";
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@id", id);

                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                }
            }
        }//------------------------------

        public DataTable Search_Ubicacion(string cadena)
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

                        Command.CommandText = "SP_Search_Ubicacion";
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

    }//--------------
}//------------------
