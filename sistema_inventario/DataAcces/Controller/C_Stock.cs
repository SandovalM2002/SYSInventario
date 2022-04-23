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
    public static class C_Stock
    {
        public static DataTable view_stock(string dato)
        {
            E_Stock obj = new E_Stock();
            return obj.View_Stock(dato);
        }

        public static void insert_stock(string nombre, bool tipo, decimal costo, decimal precio, int stock, int stock_s) {
            
            if (string.IsNullOrWhiteSpace(nombre) ||string.IsNullOrWhiteSpace(tipo.ToString()) || string.IsNullOrWhiteSpace(costo.ToString()) || string.IsNullOrWhiteSpace(stock.ToString()))
            {
                MessageBox.Show("Campos Vacios");
                return;
            }

            if (stock > 0)
            {
                E_Stock obj = new E_Stock(0, nombre, tipo, costo, precio, stock, stock_s, 0, true);
                obj.Insert_Stock(obj);
            }
        }


        public static void update_stock(string id ,string nombre, bool tipo, decimal costo, decimal precio, int stock, int stock_s)
        {

            if ( string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(tipo.ToString()) || string.IsNullOrWhiteSpace(costo.ToString()) || string.IsNullOrWhiteSpace(stock.ToString()))
            {
                MessageBox.Show("Campos Vacios");
                return;
            }

            if (stock > 0)
            {
                E_Stock obj = new E_Stock(Convert.ToInt32(id), nombre, tipo, costo, precio, stock, stock_s, 0, true);
                obj.Update_Stock(obj);
            }
        }

        public static void delete_stock(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Error con el ID,, seleccione un item de la tabla");
                return;
            }

            E_Stock obj = new E_Stock();
            obj.Unsubscribe_Stock(Convert.ToInt32(id));
        }
    }
}
