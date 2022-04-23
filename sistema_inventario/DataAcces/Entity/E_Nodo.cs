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
        private int cant;
        private int periodo;
        private string descrip;

        public E_Nodo () { }

        public E_Nodo(int id_nodo, int nodo_padre, int nodo_hijo, int cant, int periodo, string descrip)
        {
            this.id_nodo = id_nodo;
            this.nodo_padre = nodo_padre;
            this.nodo_hijo = nodo_hijo;
            this.cant = cant;
            this.periodo = periodo;
            this.descrip = descrip;
        }

        public int Id_nodo { get => id_nodo; set => id_nodo = value; }
        public int Nodo_padre { get => nodo_padre; set => nodo_padre = value; }
        public int Nodo_hijo { get => nodo_hijo; set => nodo_hijo = value; }
        public int Cant { get => cant; set => cant = value; }
        public int Periodo { get => periodo; set => periodo = value; }
        public string Descrip { get => descrip; set => descrip = value; }
       
        
        #region "PROCEDURE TO SQL"

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

                        cmd.CommandText = "SP_VIEW_SEARCH_NODO";
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

                        Command.CommandText = "SP_VIEW_SEARCH_NODO";
                        Command.CommandType = CommandType.StoredProcedure;


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
        }

        public void Insert_Nodo(E_Nodo Nodo)
        {
            using (var conection = GetConnection())
            {
                conection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = conection;

                    command.CommandText = "SP_ADD_NODO";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@P", Nodo.Nodo_padre);
                    command.Parameters.AddWithValue("@H", Nodo.Nodo_hijo);
                    command.Parameters.AddWithValue("@q", Nodo.Cant);
                    command.Parameters.AddWithValue("@t", Nodo.Periodo);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void Update_Nodo(E_Nodo Nodo)
        {
            using (var conection = GetConnection())
            {
                conection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = conection;

                    command.CommandText = "SP_UPDATE_NODO";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", Nodo.Id_nodo);
                    command.Parameters.AddWithValue("@q", Nodo.Cant);
                    command.Parameters.AddWithValue("@t", Nodo.Periodo);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void Delete_Nodo(int id)
        {
            using (var conection = GetConnection())
            {
                conection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = conection;

                    command.CommandText = "SP_DELETE_NODO";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }    
        #endregion
    }
}
