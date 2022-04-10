using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAcces.Controller
{
    public class C_Material
    {
        public static void insertar_Material(string nombre, string costo, string existencias, string stock_se)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(costo) || string.IsNullOrWhiteSpace(existencias) || string.IsNullOrWhiteSpace(stock_se))
            {
                MessageBox.Show("No se Permiten Valores Nulos");
                return;
            }

            decimal c = Convert.ToDecimal(costo);
            int s = Convert.ToInt32(existencias);
            int ss = Convert.ToInt32(stock_se);

            if (c > 0 && s > 0 && ss >= 0)
            {
                Entity.E_Material obj = new Entity.E_Material(0,nombre,c,s,ss,false);
                obj.Insert_Material(obj);
            }
            else
            {
                MessageBox.Show("Error con los datos digitados en las cantidades");
                return;
            }
        }

        public static void update_Material(string id, string nombre, string costo, string existencias, string stock_se)
        {
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(costo) || string.IsNullOrWhiteSpace(existencias) || string.IsNullOrWhiteSpace(stock_se))
            {
                MessageBox.Show("No se Permiten Valores Nulos");
                return;
            }
            int i = Convert.ToInt32(id);
            decimal c = Convert.ToDecimal(costo);
            int s = Convert.ToInt32(existencias);
            int ss = Convert.ToInt32(stock_se);

            if (c >  0 && s > 0 && ss >= 0 && i > 0)
            {
                Entity.E_Material entity = new Entity.E_Material(i, nombre, c, s, ss, false);
                entity.Update_Material(entity);
            }
            else
            {
                MessageBox.Show("Error con los datos digitados en las cantidades");
                return;
            }
        }

        public static void Unsubscribe_Material(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("El Identificador No puede estar Vacio!");
                return;
            }
            else
            {
                int identificador = Convert.ToInt32(id);
                if (identificador > 0)
                {
                    Entity.E_Material obj = new Entity.E_Material();
                    obj.Unsubscribe_Material(identificador);
                }
                else
                {
                    MessageBox.Show("Error con el Id");
                    return;
                }
            }
        }

        public static DataTable view_search_Material(string buscado)
        {
            Entity.E_Material obj = new Entity.E_Material();
            return obj.Search_View_Material(buscado);
        }
    }
}
