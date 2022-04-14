using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAcces.Entity
{
    public class E_Nodo:ConnectionToSQL
    {
        private int id_nodo;
        private int nodo_padre;
        private int nodo_hijo;
        private string descrip;
        private int cant;

        public E_Nodo () { }

        public E_Nodo(int id_nodo, int nodo_padre, int nodo_hijo, string descrip, int cant)
        {
            this.Id_nodo = id_nodo;
            this.Nodo_padre = nodo_padre;
            this.Nodo_hijo = nodo_hijo;
            this.Descrip = descrip;
            this.Cant = cant;
        }

        public int Id_nodo { get => id_nodo; set => id_nodo = value; }
        public int Nodo_padre { get => nodo_padre; set => nodo_padre = value; }
        public int Nodo_hijo { get => nodo_hijo; set => nodo_hijo = value; }
        public string Descrip { get => descrip; set => descrip = value; }
        public int Cant { get => cant; set => cant = value; }
        #region "PROCEDURE TO SQL"

        //METODOS PROPIOS
        public DataSet cargaNodosSQL()
        {
            DataSet dts = new DataSet();
            try
            {
                using (var con = GetConnection())
                {
                    con.Open();

                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = con;

                        cmd.CommandText = "SP_VIEW_NODO";
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter leer = new SqlDataAdapter(cmd);
                        leer.Fill(dts, "Nodo");

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargaListaNodos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return dts;
        }

        public DataTable View_Nodo()
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

                        Command.CommandText = "SP_VIEW_NODO";
                        Command.CommandType = CommandType.StoredProcedure;


                        SqlDataAdapter leer = new SqlDataAdapter(Command);
                        leer.Fill(res);

                        Command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return res;
        }

        public void Insert_Nodo(E_Nodo n)
        {
            try
            {
                using (var conection = GetConnection())
                {
                    conection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = conection;

                        command.CommandText = "SP_INSERT_NODO";
                        command.CommandType = CommandType.StoredProcedure;

                        //Parametros del Procedimiento almacenado
                        command.Parameters.AddWithValue("@hijo", n.Nodo_hijo);
                        command.Parameters.AddWithValue("@Cant", n.Cant);

                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        
        public void Insert_Sub_Nodo (E_Nodo n)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SP_SUB_INSERT_NODO";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PADRE", n.Nodo_padre);
                        command.Parameters.AddWithValue("@HIJO", n.Nodo_hijo);
                        command.Parameters.AddWithValue("@cant", n.Cant);

                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        
        public void Update_Nodo(E_Nodo n)
        {
            using (var conection = GetConnection())
            {
                conection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = conection;

                    command.CommandText = "SP_UPDATE_NODO";
                    command.CommandType = CommandType.StoredProcedure;

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@Id", n.Id_nodo);
                    command.Parameters.AddWithValue("@cant", n.Cant);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void Unsubscribe_Nodo(int id, int t)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = conection;

                    Command.CommandText = "SP_DELETE_NODO";
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@Id", id);
                    Command.Parameters.AddWithValue("@t", t);

                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                }
            }
        }
        
        #endregion
    }
}
