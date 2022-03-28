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
    public class Proveedor : ConexionDB
    {
        private int idProv;
        private string nombreProv;
        private string documentoProv;
        private string nDocProv;
        private int ubicacion;
        private string direccion;
        private string telfonoProv;
        private string correoProv;
        private int estadoProv; // 0 - 1

        public Proveedor() { }

        public Proveedor(int idProv, string nombreProv, string documentoProv, string nDocProv, int ubicacion, string direccion, string telfonoProv, string correoProv, int estadoProv) : this(idProv, nombreProv, documentoProv, nDocProv, ubicacion, direccion, telfonoProv, correoProv)
        {
            this.estadoProv = estadoProv;
        }

        public Proveedor(int idProv, string nombreProv, string documentoProv, string nDocProv, int ubicacion, string direccion, string telfonoProv, string correoProv)
        {
            this.idProv = idProv;
            this.nombreProv = nombreProv;
            this.documentoProv = documentoProv;
            this.nDocProv = nDocProv;
            this.ubicacion = ubicacion;
            this.direccion = direccion;
            this.telfonoProv = telfonoProv;
            this.correoProv = correoProv;
        }

        public Proveedor(string nombreProv, string documentoProv, string nDocProv, int ubicacion, string direccion, string telfonoProv, string correoProv)
        {
            this.nombreProv = nombreProv;
            this.documentoProv = documentoProv;
            this.nDocProv = nDocProv;
            this.ubicacion = ubicacion;
            this.direccion = direccion;
            this.telfonoProv = telfonoProv;
            this.correoProv = correoProv;
        }

        public int IdProv { get => idProv; set => idProv = value; }
        public string NombreProv { get => nombreProv; set => nombreProv = value; }
        public string DocumentoProv { get => documentoProv; set => documentoProv = value; }
        public string NDocProv { get => nDocProv; set => nDocProv = value; }
        public int Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string TelfonoProv { get => telfonoProv; set => telfonoProv = value; }
        public string CorreoProv { get => correoProv; set => correoProv = value; }
        public int EstadoProv { get => estadoProv; set => estadoProv = value; }

        //====================================================|| PROCEDIMIENTOS ALMACENADOS ||===========================//

        //VISUALIZAR
        public DataTable View_Proveedor()
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

                        comando.CommandText = "SP_VProveedor";
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

        public void Insert_Proveedor(Proveedor p)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_INProveedor"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado

                    command.Parameters.AddWithValue("@NP",p.NombreProv);
                    command.Parameters.AddWithValue("@DC",p.DocumentoProv);
                    command.Parameters.AddWithValue("@NDC", p.NDocProv);
                    command.Parameters.AddWithValue("@UBP",p.Ubicacion);
                    command.Parameters.AddWithValue("@DP", p.Direccion);
                    command.Parameters.AddWithValue("@TP", p.TelfonoProv);
                    command.Parameters.AddWithValue("@CP",p.CorreoProv);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------


        public void Update_Proveedor(Proveedor p)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_UPProveedor"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@Id",p.IdProv);
                    command.Parameters.AddWithValue("@NP", p.NombreProv);
                    command.Parameters.AddWithValue("@DC", p.DocumentoProv);
                    command.Parameters.AddWithValue("@NDC", p.NDocProv);
                    command.Parameters.AddWithValue("@UBP", p.Ubicacion);
                    command.Parameters.AddWithValue("@DP", p.Direccion);
                    command.Parameters.AddWithValue("@TP", p.TelfonoProv);
                    command.Parameters.AddWithValue("@CP", p.CorreoProv);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------

        //Desactivar un departamento
        public void Unsubscribe_Proveedor(int id)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = conection;

                    Command.CommandText = "SP_DBProveedor";
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@id", id);

                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                }
            }
        }//------------------------------

        public DataTable Search_Proveedor(string cadena)
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

                        Command.CommandText = "SP_Search_Proveedor";
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

    }//------------
}//----------------
