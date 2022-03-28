using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Entities.R.OrdenTrabajo
{
    public class Orden_Trabajo : ConexionDB
    {
        private int idOT;
        private int numOrden;
	    private int idCliente;
	    private string producto;
	    private string marcaProd;
	    private string serieProd;
	    private string modeloProd;
	    private DateTime fechaOrden;
        private string trabajoRealizado;
	    private string observaciones;
        private int estado;

        public Orden_Trabajo () { }

        public Orden_Trabajo(int idOT, int numOrden,int idCliente, string producto, string marcaProd, string serieProd, string modeloProd, DateTime fechaOrden, string trabajoRealizado, string observaciones, int estado)
        {
            this.idOT = idOT;
            this.numOrden = numOrden;
            this.idCliente = idCliente;
            this.producto = producto;
            this.marcaProd = marcaProd;
            this.serieProd = serieProd;
            this.modeloProd = modeloProd;
            this.fechaOrden = fechaOrden;
            this.trabajoRealizado = trabajoRealizado;
            this.observaciones = observaciones;
            this.estado=estado;
        }

        public Orden_Trabajo(int idOT,int numOrden ,int idCliente, string producto, string marcaProd, string serieProd, string modeloProd, DateTime fechaOrden, string trabajoRealizado, string observaciones)
        {
            this.idOT = idOT;
            this.numOrden = numOrden;
            this.idCliente = idCliente;
            this.producto = producto;
            this.marcaProd = marcaProd;
            this.serieProd = serieProd;
            this.modeloProd = modeloProd;
            this.fechaOrden = fechaOrden;
            this.trabajoRealizado = trabajoRealizado;
            this.observaciones = observaciones;
        }

        public Orden_Trabajo(int idCliente,int numOrden ,string producto, string marcaProd, string serieProd, string modeloProd, DateTime fechaOrden, string trabajoRealizado, string observaciones)
        {
            this.idCliente = idCliente;
            this.numOrden = numOrden;
            this.producto = producto;
            this.marcaProd = marcaProd;
            this.serieProd = serieProd;
            this.modeloProd = modeloProd;
            this.fechaOrden = fechaOrden;
            this.trabajoRealizado = trabajoRealizado;
            this.observaciones = observaciones;
        }


        public int IdOT { get => idOT; set => idOT = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Producto { get => producto; set => producto = value; }
        public string MarcaProd { get => marcaProd; set => marcaProd = value; }
        public string SerieProd { get => serieProd; set => serieProd = value; }
        public string ModeloProd { get => modeloProd; set => modeloProd = value; }
        public DateTime FechaOrden { get => fechaOrden; set => fechaOrden = value; }
        public string TrabajoRealizado { get => trabajoRealizado; set => trabajoRealizado = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public int Estado { get => estado; set => estado = value; }
        public int NumOrden { get => numOrden; set => numOrden = value; }

        //=================================|| PROCEDIMIENTOS ALMACENADOS ||===============================//

        //VISUALIZAR
        public DataTable View_OrdenTrabajo()
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

                        comando.CommandText = "SP_VOrdenT";
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

        public void Insert_OrdenTrabajo(Orden_Trabajo ot)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_INOrdenT"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@IDC", ot.IdCliente);
                    command.Parameters.AddWithValue("@Prod", ot.Producto);
                    command.Parameters.AddWithValue("@MaProd", ot.MarcaProd);
                    command.Parameters.AddWithValue("@SProd", ot.SerieProd);
                    command.Parameters.AddWithValue("@MoProd", ot.ModeloProd);
                    command.Parameters.AddWithValue("@FO", ot.FechaOrden);
                    command.Parameters.AddWithValue("@TR", ot.TrabajoRealizado);
                    command.Parameters.AddWithValue("@OB", ot.Observaciones);
                    command.Parameters.AddWithValue("@NO", ot.NumOrden);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------


        public void Update_OrdenTrabajo(Orden_Trabajo ot)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_UPOrdenT"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@Id", ot.IdOT);
                    command.Parameters.AddWithValue("@IDC", ot.IdCliente);
                    command.Parameters.AddWithValue("@Prod", ot.Producto);
                    command.Parameters.AddWithValue("@MaProd", ot.MarcaProd);
                    command.Parameters.AddWithValue("@SProd", ot.SerieProd);
                    command.Parameters.AddWithValue("@MoProd", ot.ModeloProd);
                    command.Parameters.AddWithValue("@FO", ot.FechaOrden);
                    command.Parameters.AddWithValue("@TR", ot.TrabajoRealizado);
                    command.Parameters.AddWithValue("@OB", ot.Observaciones);
                    command.Parameters.AddWithValue("@NO", ot.NumOrden);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------

        //Desactivar un departamento
        public void Unsubscribe_OrdenTrabajo(int id)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = conection;

                    Command.CommandText = "SP_DBOrdenT";
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@id", id);

                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                }
            }
        }//------------------------------

        public DataTable Search_OrdenTrabajo(string cadena)
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

                        Command.CommandText = "SP_Search_OrdenTrabajo";
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
