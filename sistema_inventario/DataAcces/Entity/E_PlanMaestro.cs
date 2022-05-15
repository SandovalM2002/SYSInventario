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
    public class E_PlanMaestro:ConnectionToSQL
    {
        private int id_pm;
        private int nodo_pm;
        private int demanda;
        private int periodo;

        public E_PlanMaestro() { }

        public E_PlanMaestro(int id_pm, int nodo_pm, int demanda, int periodo)
        {
            this.id_pm = id_pm;
            this.nodo_pm = nodo_pm;
            this.demanda = demanda;
            this.periodo = periodo;
        }

        public int Id_pm { get => id_pm; set => id_pm = value; }
        public int Nodo_pm { get => nodo_pm; set => nodo_pm = value; }
        public int Demanda { get => demanda; set => demanda = value; }
        public int Periodo { get => periodo; set => periodo = value; }

        #region "PROCEDURE TO SQL"
        public DataTable View_Plan_Maestro ()
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

                        Command.CommandText = "SP_VIEW_PM";
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

        public void Insert_Plan_Maestro(E_PlanMaestro pm)
        {
            using (var conection = GetConnection())
            {
                conection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = conection;

                    command.CommandText = "SP_ADD_NODO";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Nodo", pm.Nodo_pm);
                    command.Parameters.AddWithValue("@Demanda", pm.Demanda);
                    command.Parameters.AddWithValue("@Periodo", pm.Periodo);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void Update_Plan_Maestro(E_PlanMaestro pm)
        {
            using (var conection = GetConnection())
            {
                conection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = conection;

                    command.CommandText = "SP_UPDATE_PM";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ID", pm.Id_pm);
                    command.Parameters.AddWithValue("@Nodo", pm.Nodo_pm);
                    command.Parameters.AddWithValue("@Demanda", pm.Demanda);
                    command.Parameters.AddWithValue("@Periodo", pm.Periodo);

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void Delete_Plan_Maestro(int id)
        {
            using (var conection = GetConnection())
            {
                conection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = conection;

                    command.CommandText = "SP_DELETE_MP";
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
