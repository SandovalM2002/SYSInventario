using CapaDatos.Entities.R.Producto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Iventario_Controller
    {
        public static void InsertDataInventario(int idProd, int exist, float precioP)
        {
            Inventario m = new Inventario(idProd, exist, precioP);
            m.Insert_Inventario(m);
        }

        public static void UpdateDataInventario(int idInv, int idProd, int exist, float precioP)
        {
            Inventario m = new Inventario(idInv, idProd, exist, precioP);
            m.Update_Inventario(m);
        }

        public static void UnsubScribeDataInventario(int id)
        {
            Inventario m = new Inventario();
            m.Unsubscribe_Inventario(id);
        }

        public static DataTable SearchDataInventario(string cadena)
        {
            Inventario m = new Inventario();
            return m.Search_Inventario(cadena);
        }

        public static DataTable ViewDataInventario()
        {
            Inventario m = new Inventario();
            return m.View_Inventario();
        }
    }
}
