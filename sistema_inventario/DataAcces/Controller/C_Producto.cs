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
    public static class C_Producto
    {
        public static void insertar_producto(string nombre, string costo, string precio, string existencias, string stock_se)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(costo) || string.IsNullOrWhiteSpace(precio) ||
                string.IsNullOrWhiteSpace(existencias) || string.IsNullOrWhiteSpace(stock_se))
            {
                MessageBox.Show("No se Permiten Valores Nulos");
                return;
            }

            decimal c = Convert.ToDecimal(costo);
            decimal p = Convert.ToDecimal(precio);
            int s = Convert.ToInt32(existencias);
            int ss = Convert.ToInt32(stock_se);

            if(c > 0 && p > 0 && s > 0 && ss >= 0)
            {
                E_Producto entity = new E_Producto(0,nombre,c,p,s,ss,false);
                entity.Insert_product(entity);
            }
            else
            {
                MessageBox.Show("Error con los datos digitados en las cantidades");
                return;
            }
        }

        public static void update_producto(string id,string nombre, string costo, string precio, string existencias, string stock_se)
        {
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(costo) || string.IsNullOrWhiteSpace(precio) ||
                string.IsNullOrWhiteSpace(existencias) || string.IsNullOrWhiteSpace(stock_se))
            {
                MessageBox.Show("No se Permiten Valores Nulos");
                return;
            }
            int i = Convert.ToInt32(id);
            decimal c = Convert.ToDecimal(costo);
            decimal p = Convert.ToDecimal(precio);
            int s = Convert.ToInt32(existencias);
            int ss = Convert.ToInt32(stock_se);

            if (c > 0 && p > 0 && s > 0 && ss >= 0 && i > 0)
            {
                E_Producto entity = new E_Producto(i, nombre, c, p, s, ss, false);
                entity.Update_producto(entity);
            }
            else
            {
                MessageBox.Show("Error con los datos digitados en las cantidades");
                return;
            }
        }

        public static void Unsubscribe_producto(string id)
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
                    E_Producto obj = new E_Producto();
                    obj.Unsubscribe_producto(identificador);
                }
                else
                {
                    MessageBox.Show("Error con el Id");
                    return;
                }
            }
        }

        public static DataTable view_search_producto (string buscado)
        {
            E_Producto obj = new E_Producto();
            return obj.Search_product(buscado);
        }
    
    }
}
