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
    public class Empleado : ConexionDB
    {
        private int idEmpleado;
        private string pNombre;
        private string sNombre;
        private string pApellido;
        private string sApellido;
        private string documento;
        private string nuDocumento;
        private string cargo;
        private int departameto;
        private string direccion;
        private string telEmpleado;
        private string correo;
        private int estado;

        public Empleado () { }

        public Empleado(int idEmpleado, string pNombre, string sNombre, string pApellido, string sApellido, string documento, string nuDocumento, string cargo, int departameto, string direccion, string telEmpleado, string correo, int estado)
        {
            this.idEmpleado = idEmpleado;
            this.pNombre = pNombre;
            this.sNombre = sNombre;
            this.pApellido = pApellido;
            this.sApellido = sApellido;
            this.documento = documento;
            this.nuDocumento = nuDocumento;
            this.cargo = cargo;
            this.departameto = departameto;
            this.direccion = direccion;
            this.telEmpleado = telEmpleado;
            this.correo = correo;
            this.estado = estado;
        }

        public Empleado(int idEmpleado, string pNombre, string sNombre, string pApellido, string sApellido, string documento, string nuDocumento, string cargo, int departameto, string direccion, string telEmpleado, string correo)
        {
            this.idEmpleado = idEmpleado;
            this.pNombre = pNombre;
            this.sNombre = sNombre;
            this.pApellido = pApellido;
            this.sApellido = sApellido;
            this.documento = documento;
            this.nuDocumento = nuDocumento;
            this.cargo = cargo;
            this.departameto = departameto;
            this.direccion = direccion;
            this.telEmpleado = telEmpleado;
            this.correo = correo;
        }

        public Empleado(string pNombre, string sNombre, string pApellido, string sApellido, string documento, string nuDocumento, string cargo, int departameto, string direccion, string telEmpleado, string correo)
        {
            this.pNombre = pNombre;
            this.sNombre = sNombre;
            this.pApellido = pApellido;
            this.sApellido = sApellido;
            this.documento = documento;
            this.nuDocumento = nuDocumento;
            this.cargo = cargo;
            this.departameto = departameto;
            this.direccion = direccion;
            this.telEmpleado = telEmpleado;
            this.correo = correo;
        }

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string PNombre { get => pNombre; set => pNombre = value; }
        public string SNombre { get => sNombre; set => sNombre = value; }
        public string PApellido { get => pApellido; set => pApellido = value; }
        public string SApellido { get => sApellido; set => sApellido = value; }
        public string Documento { get => documento; set => documento = value; }
        public string NuDocumento { get => nuDocumento; set => nuDocumento = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int Departameto { get => departameto; set => departameto = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string TelEmpleado { get => telEmpleado; set => telEmpleado = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Estado { get => estado; set => estado = value; }


        //--------------------------------------|| PROCEDIMIENTOS ALMACENADOS ||----------------------------------//

        //VISUALIZAR
        public DataTable View_Empleado()
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

                        comando.CommandText = "SP_VEmpleado";
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

        public void Insert_Empleado(Empleado e)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_INEmpleado"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando
                    
                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@PN",e.PNombre);
                    command.Parameters.AddWithValue("@SN", e.SNombre);
                    command.Parameters.AddWithValue("@PA", e.PApellido);
                    command.Parameters.AddWithValue("@SA", e.SApellido);
                    command.Parameters.AddWithValue("@DC", e.Documento);
                    command.Parameters.AddWithValue("@NDC", e.NuDocumento);
                    command.Parameters.AddWithValue("@CGE", e.Cargo);
                    command.Parameters.AddWithValue("@Depto", e.Departameto);
                    command.Parameters.AddWithValue("@DE", e.Direccion);
                    command.Parameters.AddWithValue("@TE", e.TelEmpleado);
                    command.Parameters.AddWithValue("@CE", e.correo);
                    

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------


        public void Update_Empleado(Empleado e)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_UPEmpleado"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando


                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("Id",e.IdEmpleado);
                    command.Parameters.AddWithValue("@PN", e.PNombre);
                    command.Parameters.AddWithValue("@SN", e.SNombre);
                    command.Parameters.AddWithValue("@PA", e.PApellido);
                    command.Parameters.AddWithValue("@SA", e.SApellido);
                    command.Parameters.AddWithValue("@DC", e.Documento);
                    command.Parameters.AddWithValue("@NDC", e.NuDocumento);
                    command.Parameters.AddWithValue("@CGE", e.Cargo);
                    command.Parameters.AddWithValue("@Depto", e.Departameto);
                    command.Parameters.AddWithValue("@DE", e.Direccion);
                    command.Parameters.AddWithValue("@TE", e.TelEmpleado);
                    command.Parameters.AddWithValue("@CE", e.correo);


                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------

        //Desactivar un departamento
        public void Unsubscribe_Empleado(int id)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = conection;

                    Command.CommandText = "SP_DBEmpleado";
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@id", id);
                    
                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                }
            }
        }//------------------------------

        public DataTable Search_Empleado(string cadena)
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

                        Command.CommandText = "SP_Search_Empleado";
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
