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

        public static DataTable View_Nodo()
        {
            Entity.E_Nodo obj = new E_Nodo();
            return obj.View_Nodo();
        }

        public static void Insert_Nodo(string nodo_padre, string nodo_hijo, bool bandera)
        {
            if (bandera.Equals(true))
            {
                if (string.IsNullOrWhiteSpace(nodo_hijo))
                {
                    MessageBox.Show("Error");
                    return;
                }
                E_Nodo obj = new E_Nodo(0,0,Convert.ToInt32(nodo_hijo),"");
                obj.Insert_Nodo(obj);

            } else if (bandera.Equals(false))
            {
                if (string.IsNullOrWhiteSpace(nodo_padre) || string.IsNullOrWhiteSpace(nodo_hijo))
                {
                    MessageBox.Show("Error");
                    return;

                }
                E_Nodo obj = new E_Nodo(0, Convert.ToInt32(nodo_padre), Convert.ToInt32(nodo_hijo), "");
                obj.Insert_Sub_Nodo(obj);
            }
        }

        public static void update_Nodo(string nodo_id,string nodo_padre, string nodo_hijo, char tipo)
        {
            if (string.IsNullOrWhiteSpace(nodo_id) || string.IsNullOrWhiteSpace(nodo_hijo) || char.IsWhiteSpace(tipo))
            {
                MessageBox.Show("Error Campos Vacios");
                return;
            }
            int id = Convert.ToInt32(nodo_id);
            int padre = Convert.ToInt32(nodo_padre);
            int hijo = Convert.ToInt32(nodo_hijo);

            Entity.E_Nodo obj = new E_Nodo(id, padre, hijo, "");
            obj.Update_Nodo(obj, tipo);
        }

        public static void delete_Nodo (string nodo_id)
        {
            if (string.IsNullOrWhiteSpace(nodo_id))
            {
                MessageBox.Show("Error con el identificador");
                return;
            }

            int id = Convert.ToInt32(nodo_id);

            Entity.E_Nodo obj = new E_Nodo();
            obj.Unsubscribe_Nodo(id);
        }
    }
}
