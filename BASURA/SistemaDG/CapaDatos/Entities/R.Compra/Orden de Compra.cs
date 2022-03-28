using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos.Entities.R.Compra
{
    public class Orden_de_Compra : ConexionDB
    {
        private int idOrden;
        private string numeroOrden;
        private int idProv;
        private string producto;
        private int cantidadComprada;
        private float precioUnitario;
        private DateTime fechaPedido;
        private DateTime fechaPago;
        private string terminosEntrega;
        private int idEmpleado;
        private int estado;
        
        public Orden_de_Compra() { }

        public Orden_de_Compra(int idOrden, string numeroOrden, int idProv, string producto, int cantidadComprada, float precioUnitario, DateTime fechaPedido, DateTime fechaPago, string terminosEntrega, int idEmpleado, int estado)
        {
            this.idOrden = idOrden;
            this.numeroOrden = numeroOrden;
            this.idProv = idProv;
            this.producto = producto;
            this.cantidadComprada = cantidadComprada;
            this.precioUnitario = precioUnitario;
            this.fechaPedido = fechaPedido;
            this.fechaPago = fechaPago;
            this.terminosEntrega = terminosEntrega;
            this.idEmpleado = idEmpleado;
            this.estado = estado;
        }

        public Orden_de_Compra(int idOrden, string numeroOrden, int idProv, string producto, int cantidadComprada, float precioUnitario, DateTime fechaPedido, DateTime  fechaPago, string terminosEntrega, int idEmpleado)
        {
            this.idOrden = idOrden;
            this.numeroOrden = numeroOrden;
            this.idProv = idProv;
            this.producto = producto;
            this.cantidadComprada = cantidadComprada;
            this.precioUnitario = precioUnitario;
            this.fechaPedido = fechaPedido;
            this.fechaPago = fechaPago;
            this.terminosEntrega = terminosEntrega;
            this.idEmpleado = idEmpleado;
        }

        public Orden_de_Compra( string numeroOrden, int idProv, string producto, int cantidadComprada, float precioUnitario, DateTime fechaPedido,DateTime fechaPago, string terminosEntrega, int idEmpleado)
        {
            this.numeroOrden = numeroOrden;
            this.idProv = idProv;
            this.producto = producto;
            this.cantidadComprada = cantidadComprada;
            this.precioUnitario = precioUnitario;
            this.fechaPedido = fechaPedido;
            this.fechaPago = fechaPago;
            this.terminosEntrega = terminosEntrega;
            this.idEmpleado = idEmpleado;
        }

        public int IdOrden { get => idOrden; set => idOrden = value; }
        public string NumeroOrden { get => numeroOrden; set => numeroOrden = value; }
        public int IdProv { get => idProv; set => idProv = value; }
        public string Producto { get => producto; set => producto = value; }
        public int CantidadComprada { get => cantidadComprada; set => cantidadComprada = value; }
        public float PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public DateTime FechaPedido { get => fechaPedido; set => fechaPedido = value; }
        public DateTime FechaPago { get => fechaPago; set => fechaPago = value; }
        public string TerminosEntrega { get => terminosEntrega; set => terminosEntrega = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public int Estado { get => estado; set => estado = value; }

        //========================================|| PROCEDIMIENTOS ALMACENADOS ||=========================================//

        //VISUALIZAR
        public DataTable View_OrdenCompra()
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

                        comando.CommandText = "SP_VOrdenCompra";
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

        public void Insert_OrdenCompra(Orden_de_Compra o)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_INOrdenCompra"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@NO",o.NumeroOrden);
                    command.Parameters.AddWithValue("@IdProv", o.IdProv);
                    command.Parameters.AddWithValue("@NProd",o.Producto);
                    command.Parameters.AddWithValue("@CantComprada",o.CantidadComprada);
                    command.Parameters.AddWithValue("@PU",o.PrecioUnitario );
                    command.Parameters.AddWithValue("@FechaP",o.FechaPedido);
                    command.Parameters.AddWithValue("@FechaE", o.FechaPago);
                    command.Parameters.AddWithValue("@TE",o.TerminosEntrega);
                    command.Parameters.AddWithValue("@Empleado",o.IdEmpleado);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------


        public void Update_OrdenCompra(Orden_de_Compra o)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_UPOrdenCompra"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@Id",o.IdOrden);
                    command.Parameters.AddWithValue("@NO", o.NumeroOrden);
                    command.Parameters.AddWithValue("@IdProv", o.IdProv);
                    command.Parameters.AddWithValue("@NProd", o.Producto);
                    command.Parameters.AddWithValue("@CantComprada", o.CantidadComprada);
                    command.Parameters.AddWithValue("@PU", o.PrecioUnitario);
                    command.Parameters.AddWithValue("@FechaP", o.FechaPedido);
                    command.Parameters.AddWithValue("@FechaE", o.FechaPago);
                    command.Parameters.AddWithValue("@TE", o.TerminosEntrega);
                    command.Parameters.AddWithValue("@Empleado", o.IdEmpleado);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------

        //Desactivar un departamento
        public void Unsubscribe_OrdenCompra(int id)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = conection;

                    Command.CommandText = "SP_DBOrdenCompra";
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@id", id);

                    
                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                }
            }
        }//------------------------------

        public DataTable Search_OrdenCompra(string cadena)
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

                        Command.CommandText = "SP_Search_OrdenCompra";
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
    }//----------
}//--------------
