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
    public class E_RepecionProgramada : ConnectionToSQL
    {
        private int id_rp;
        private int nodo_rp;
        private int cantidad_rp;
        private int periodo_rp;

        public E_RepecionProgramada()
        {
        }

        public E_RepecionProgramada(int id_rp, int nodo_rp, int cantidad_rp, int periodo_rp)
        {
            this.id_rp = id_rp;
            this.nodo_rp = nodo_rp;
            this.cantidad_rp = cantidad_rp;
            this.periodo_rp = periodo_rp;
        }

        public int Id_rp { get => id_rp; set => id_rp = value; }
        public int Nodo_rp { get => nodo_rp; set => nodo_rp = value; }
        public int Cantidad_rp { get => cantidad_rp; set => cantidad_rp = value; }
        public int Periodo_rp { get => periodo_rp; set => periodo_rp = value; }

        #region "STORAGE PROCEDURE IN DATABASE"

        public DataTable View_Recepciones_Programadas()
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

                        Command.CommandText = "SP_VIEW_RP";
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

        public void Insert_Recepciones_Programadas(E_RepecionProgramada repecionProgramada)
        {
            using (var conection = GetConnection())
            {
                conection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = conection;

                    command.CommandText = "SP_ADD_RP";
                    command.CommandType = CommandType.StoredProcedure;

                    //Parametros del Procedimiento almacenado
                    command.Parameters.AddWithValue("@nodo", repecionProgramada.Nodo_rp);
                    command.Parameters.AddWithValue("@periodo", repecionProgramada.Periodo_rp);
                    command.Parameters.AddWithValue("@cantidad", repecionProgramada.Cantidad_rp);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void Update_Recepciones_Programadas(E_RepecionProgramada repecionProgramada)
        {
            using (var conection = GetConnection())
            {
                conection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = conection;

                    command.CommandText = "SP_UPDATE_RP";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@id", repecionProgramada.Id_rp);
                    command.Parameters.AddWithValue("@nodo", repecionProgramada.Nodo_rp);
                    command.Parameters.AddWithValue("@periodo", repecionProgramada.Periodo_rp);
                    command.Parameters.AddWithValue("@cantidad", repecionProgramada.Cantidad_rp);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void Unsubscribe_Recepciones_Programadas(int id)
        {
            using (var conection = GetConnection())
            {
                conection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = conection;

                    Command.CommandText = "SP_DELETE_RP";
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@id", id);

                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                }
            }
        }

        #endregion
    }
}
