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

        public static void Insert_Nodo(string nodo_padre, string nodo_hijo, bool bandera, string cant)
        {
            int c = Convert.ToInt32(cant);
            if (bandera.Equals(true))
            {
                if (string.IsNullOrWhiteSpace(nodo_hijo))
                {
                    MessageBox.Show("Error");
                    return;
                }

                E_Nodo obj = new E_Nodo(0,0,Convert.ToInt32(nodo_hijo),"",c);
                obj.Insert_Nodo(obj);

            } else if (bandera.Equals(false))
            {
                if (string.IsNullOrWhiteSpace(nodo_padre) || string.IsNullOrWhiteSpace(nodo_hijo))
                {
                    MessageBox.Show("Error");
                    return;

                }
                E_Nodo obj = new E_Nodo(0, Convert.ToInt32(nodo_padre), Convert.ToInt32(nodo_hijo), "", c);
                obj.Insert_Sub_Nodo(obj);
            }
        }

        public static void update_Nodo(string id, string cant)
        {
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(cant))
            {
                MessageBox.Show("Error Campos Vacios");
                return;
            }

            Entity.E_Nodo obj = new E_Nodo(Convert.ToInt32(id),0,0,"",Convert.ToInt32(cant));
            obj.Update_Nodo(obj);
        }

        public static void delete_Nodo (string nodo_id, int t)
        {
            if (string.IsNullOrWhiteSpace(nodo_id))
            {
                MessageBox.Show("Error con el identificador");
                return;
            }

            int id = Convert.ToInt32(nodo_id);

            Entity.E_Nodo obj = new E_Nodo();
            obj.Unsubscribe_Nodo(id, t);
        }
    }
}
