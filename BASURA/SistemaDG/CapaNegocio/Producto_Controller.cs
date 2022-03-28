using CapaDatos.Entities;
using System.Data;

namespace CapaNegocio
{
    public class Producto_Controller
    {
        public static void InsertDataProducto(string codProd, string nombreProd, int tipoProd, string marcaProd, string desProd)
        {
            Producto p = new Producto(codProd,  nombreProd,  tipoProd,  marcaProd, desProd);
            p.Insert_Producto(p);
        }

        public static void UpdateDataProducto(int id, string codProd, string nombreProd, int tipoProd, string marcaProd, string desProd)
        {
            Producto p = new Producto(id ,codProd, nombreProd, tipoProd, marcaProd, desProd);
            p.Update_Producto(p);
        }

        public static void UnsubScribeDataProducto(int id)
        {
            Producto p = new Producto();
            p.Unsubscribe_Producto(id);
        }

        public static DataTable SearchDataProducto(string cade)
        {
            Producto p = new Producto();
            return p.Search_Producto(cade);
        }

        public static DataTable ViewDataProducto()
        {
            Producto p = new Producto();
            return p.View_Producto();
        }
    }
}
