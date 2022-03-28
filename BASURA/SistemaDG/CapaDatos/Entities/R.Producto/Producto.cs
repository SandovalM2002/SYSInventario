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
    public class Producto: ConexionDB
    {
        private int idProd;
        private string codProd;
        private string nombreProd;
        private int tipoProd;
        private string marcaProd;
        private string desProd;
        private int estado;

        public Producto() { }

        public Producto(int idProd, string codProd, string nombreProd, int tipoProd, string marcaProd, string desProd, int estado)
        {
            this.idProd = idProd;
            this.codProd = codProd;
            this.nombreProd = nombreProd;
            this.tipoProd = tipoProd;
            this.marcaProd = marcaProd;
            this.desProd = desProd;
            this.estado = estado;
        }

        public Producto(int idProd, string codProd, string nombreProd, int tipoProd, string marcaProd, string desProd)
        {
            this.idProd = idProd;
            this.codProd = codProd;
            this.nombreProd = nombreProd;
            this.tipoProd = tipoProd;
            this.marcaProd = marcaProd;
            this.desProd = desProd;

        }

        public Producto(string codProd, string nombreProd, int tipoProd, string marcaProd, string desProd)
        {
            this.codProd = codProd;
            this.nombreProd = nombreProd;
            this.tipoProd = tipoProd;
            this.marcaProd = marcaProd;
            this.desProd = desProd;
        }

        public int IdProd { get => idProd; set => idProd = value; }
        public string CodProd { get => codProd; set => codProd = value; }
        public string NombreProd { get => nombreProd; set => nombreProd = value; }
        public int TipoProd { get => tipoProd; set => tipoProd = value; }
        public string MarcaProd { get => marcaProd; set => marcaProd = value; }
        public string DesProd { get => desProd; set => desProd = value; }
        public int Estado { get => estado; set => estado = value; }


        //==========================================|| PROCEDIMIENTOS ALMACENADOS || ============================//
        //VISUALIZAR
        public DataTable View_Producto()
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

                        comando.CommandText = "SP_VProducto";
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

        public void Insert_Producto(Producto p)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_INProducto"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@CodProd",p.CodProd);
                    command.Parameters.AddWithValue("@NP", p.NombreProd);
                    command.Parameters.AddWithValue("@TP", p.TipoProd);
                    command.Parameters.AddWithValue("@MP",p.MarcaProd);
                    command.Parameters.AddWithValue("@DP",p.DesProd);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------


        public void Update_Producto(Producto p)
        {
            using (var conection = GetConnection()) //Decimos que Connection sera igual a la Funacion de Obtener la Conexion a la Base de Datos
            {
                conection.Open();

                using (var command = new SqlCommand()) // Decimos que command sera los comandos para SQL
                {
                    command.Connection = conection;

                    command.CommandText = "SP_UProducto"; //Nombre del comando de la estrucutra sql
                    command.CommandType = CommandType.StoredProcedure; //Tipo de Comando

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@id",p.IdProd);
                    command.Parameters.AddWithValue("@CodProd", p.CodProd);
                    command.Parameters.AddWithValue("@NP", p.NombreProd);
                    command.Parameters.AddWithValue("@TP", p.TipoProd);
                    command.Parameters.AddWithValue("@MP", p.MarcaProd);
                    command.Parameters.AddWithValue("@DP", p.DesProd);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }//-------------------------------

        //Desactivar un departamento
        public void Unsubscribe_Producto(int id)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = conection;

                    Command.CommandText = "SP_DBProductos";
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@id", id);
                    
                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                }
            }
        }//------------------------------

        public DataTable Search_Producto(string cad)
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

                        Command.CommandText = "SP_Search_Producto";
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@Dato", cad);

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

    }//--------
}//------------
