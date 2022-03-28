using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos.Entities.R.Login
{
    public class Usuario : ConexionDB
    {
        private int id;
        private string nombreUser;
        private string contra;
        private int rol;
        private int estado;

        public Usuario() { }

        public Usuario(int id, string nombreUser, string contra, int rol, int estado)
        {
            this.id = id;
            this.nombreUser = nombreUser;
            this.contra = contra;
            this.rol = rol;
            this.estado = estado;
        }

        public Usuario(int id, string nombreUser, string contra, int rol)
        {
            this.id = id;
            this.nombreUser = nombreUser;
            this.contra = contra;
            this.rol = rol;
        }

        public Usuario(string nombreUser, string contra, int rol)
        {
            this.nombreUser = nombreUser;
            this.contra = contra;
            this.rol = rol;
        }

        public int Id { get => id; set => id = value; }
        public string NombreUser { get => nombreUser; set => nombreUser = value; }
        public string Contra { get => contra; set => contra = value; }
        public int Rol { get => rol; set => rol = value; }
        public int Estado { get => estado; set => estado = value; }

        //ViSUALIZAR
        public DataTable View_Usuario()
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

                        comando.CommandText = "SP_VUsuario";
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

        public void Insert_Usurio(Usuario u)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_INUsuario"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@NU", u.NombreUser);
                    command.Parameters.AddWithValue("@PU", u.Contra);
                    command.Parameters.AddWithValue("@IDR",u.Rol);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------


        public void Update_Usuario(Usuario u)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_UPUsuario"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@Id", u.NombreUser);
                    command.Parameters.AddWithValue("@NU", u.NombreUser);
                    command.Parameters.AddWithValue("@PU", u.Contra);
                    command.Parameters.AddWithValue("@IDR", u.Rol);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------

        public void Unsubscribe_Usuario(int id)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = conection;

                    Command.CommandText = "SP_DBUsuario";
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@id", id);
                    
                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                }
            }
        }//------------------------------

        public DataTable Search_Usuario(int id)
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

                        Command.CommandText = "SP_SAUsuario";
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

    }
}
