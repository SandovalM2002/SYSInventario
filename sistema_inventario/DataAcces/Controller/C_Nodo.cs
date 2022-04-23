using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAcces.Controller
{
    public class C_Nodo
    {
        public static DataSet CargarNodos()
        {
            E_Nodo obj = new E_Nodo();
            return obj.cargaNodosSQL();
        }

        public static DataTable view() {
            E_Nodo obj = new E_Nodo();
            return obj.View_Nodo();
        }

        public static void Insert(string padre, string hijo, int cant, int periodo)
        {
            if ( string.IsNullOrWhiteSpace(hijo) || string.IsNullOrWhiteSpace(cant.ToString()) || string.IsNullOrWhiteSpace(periodo.ToString()))
            {
                MessageBox.Show("No pueden habar datos vacios");
                return;
            }

            int p = Convert.ToInt32(padre);
            int h = Convert.ToInt32(hijo);

            E_Nodo obj = new E_Nodo(0,p,h,cant,periodo,"");
            obj.Insert_Nodo(obj);
        }

        public static void update(string id, int cant, int periodo)
        {
            if ( string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("No pueden habar datos vacios");
                return;
            }

            int cod = Convert.ToInt32(id);

            E_Nodo obj = new E_Nodo(cod, 0, 0, cant, periodo, "");
            obj.Update_Nodo(obj);
        }

        public static void delete (string cod)
        {
            if (string.IsNullOrWhiteSpace(cod))
            {
                MessageBox.Show("Error con el Codigo");
                return;
            }

            int id = Convert.ToInt32(cod);

            E_Nodo obj = new E_Nodo();
            obj.Delete_Nodo(id);
        }
    }
}
