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
        private string nodo_padre;
        private string nodo_hijo;
        private string descrip;

        public E_Nodo() { }

        public E_Nodo(int id_nodo, string nodo_padre, string nodo_hijo, string descrip)
        {
            this.Id_nodo = id_nodo;
            this.Nodo_padre = nodo_padre;
            this.Nodo_hijo = nodo_hijo;
            this.Descrip = descrip;
        }

        public int Id_nodo { get => id_nodo; set => id_nodo = value; }
        public string Nodo_padre { get => nodo_padre; set => nodo_padre = value; }
        public string Nodo_hijo { get => nodo_hijo; set => nodo_hijo = value; }
        public string Descrip { get => descrip; set => descrip = value; }


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
    }
}
