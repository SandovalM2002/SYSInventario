using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Entities.R.Cliente
{
    public class Cliente: ConexionDB
    {
        private int idCliente;
	    private int tipoCliente;
	    private string documento;
	    private string pNombre;
	    private string sNombre;
	    private string pApellido;
	    private string sApellido;
	    private string nEmpresa;
	    private int depto;
	    private string direccion;
	    private string correo;
	    private string telCliente;
	    private int estadoCliente; 
        

        public Cliente () { }

        public Cliente(int idCliente, int tipoCliente, string documento, string pNombre, string sNombre, string pApellido, string sApellido, string nEmpresa, int depto, string direccion, string correo, string telCliente, int estadoCliente)
        {
            this.idCliente = idCliente;
            this.tipoCliente = tipoCliente;
            this.documento = documento;
            this.pNombre = pNombre;
            this.sNombre = sNombre;
            this.pApellido = pApellido;
            this.sApellido = sApellido;
            this.nEmpresa = nEmpresa;
            this.depto = depto;
            this.direccion = direccion;
            this.correo = correo;
            this.telCliente = telCliente;
            this.estadoCliente = estadoCliente;
        }

        public Cliente(int idCliente, int tipoCliente, string documento, string pNombre, string sNombre, string pApellido, string sApellido, string nEmpresa, int depto, string direccion, string correo, string telCliente)
        {
            this.idCliente = idCliente;
            this.tipoCliente = tipoCliente;
            this.documento = documento;
            this.pNombre = pNombre;
            this.sNombre = sNombre;
            this.pApellido = pApellido;
            this.sApellido = sApellido;
            this.nEmpresa = nEmpresa;
            this.depto = depto;
            this.direccion = direccion;
            this.correo = correo;
            this.telCliente = telCliente;
        }

        public Cliente(int tipoCliente, string documento, string pNombre, string sNombre, string pApellido, string sApellido, string nEmpresa, int depto, string direccion, string correo, string telCliente)
        {
            this.tipoCliente = tipoCliente;
            this.documento = documento;
            this.pNombre = pNombre;
            this.sNombre = sNombre;
            this.pApellido = pApellido;
            this.sApellido = sApellido;
            this.nEmpresa = nEmpresa;
            this.depto = depto;
            this.direccion = direccion;
            this.correo = correo;
            this.telCliente = telCliente;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int TipoCliente { get => tipoCliente; set => tipoCliente = value; }
        public string Documento { get => documento; set => documento = value; }
        public string PNombre { get => pNombre; set => pNombre = value; }
        public string SNombre { get => sNombre; set => sNombre = value; }
        public string PApellido { get => pApellido; set => pApellido = value; }
        public string SApellido { get => sApellido; set => sApellido = value; }
        public string NEmpresa { get => nEmpresa; set => nEmpresa = value; }
        public int Depto { get => depto; set => depto = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Correo { get => correo; set => correo = value; }
        public string TelCliente { get => telCliente; set => telCliente = value; }
        public int EstadoCliente { get => estadoCliente; set => estadoCliente = value; }

        //=================================|| PROCEDIMIENTOS ALMACENADOS ||===============================//

        //VISUALIZAR
        public DataTable View_Cliente()
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

                        comando.CommandText = "SP_VCliente";
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

        public void Insert_Cliente(Cliente c)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_INCliente"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@TPC",c.TipoCliente);
                    command.Parameters.AddWithValue("@DC", c.Documento);
                    command.Parameters.AddWithValue("@PN", c.PNombre);
                    command.Parameters.AddWithValue("@SN", c.SNombre);
                    command.Parameters.AddWithValue("@PA", c.PApellido);
                    command.Parameters.AddWithValue("@SA", c.SApellido);
                    command.Parameters.AddWithValue("@EC", c.NEmpresa);
                    command.Parameters.AddWithValue("@Depto", c.Depto);
                    command.Parameters.AddWithValue("@DE", c.Direccion);
                    command.Parameters.AddWithValue("@CE", c.Correo);
                    command.Parameters.AddWithValue("@TC", c.TelCliente);
                
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------


        public void Update_Cliente(Cliente c)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_UPCliente"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@Id", c.IdCliente);
                    command.Parameters.AddWithValue("@TPC", c.TipoCliente);
                    command.Parameters.AddWithValue("@DC", c.Documento);
                    command.Parameters.AddWithValue("@PN", c.PNombre);
                    command.Parameters.AddWithValue("@SN", c.SNombre);
                    command.Parameters.AddWithValue("@PA", c.PApellido);
                    command.Parameters.AddWithValue("@SA", c.SApellido);
                    command.Parameters.AddWithValue("@EC", c.NEmpresa);
                    command.Parameters.AddWithValue("@Depto", c.Depto);
                    command.Parameters.AddWithValue("@DE", c.Direccion);
                    command.Parameters.AddWithValue("@CE", c.Correo);
                    command.Parameters.AddWithValue("@TC", c.TelCliente);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------

        //Desactivar un departamento
        public void Unsubscribe_Cliente(int id)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = conection;

                    Command.CommandText = "SP_DBCliente";
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@id", id);

                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                }
            }
        }//------------------------------

        public DataTable Search_Cliente(string cadena)
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

                        Command.CommandText = "SP_Search_Cliente";
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
    }//-------
}//-----------
