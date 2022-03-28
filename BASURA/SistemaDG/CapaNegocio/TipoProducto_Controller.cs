using CapaDatos.Entities;
using System.Data;

namespace CapaNegocio
{
    public class TipoProducto_Controller
    {
        public static void InsertDataTProducto(string nombreTP, string descTP, int modeloTP, string serieTP)
        {
            Tipo_Producto tp = new Tipo_Producto(nombreTP, descTP, modeloTP,  serieTP);
            tp.Insert_TipoProducto(tp);
        }

        public static void UpdateDataTProducto(int id, string nombreTP, string descTP, int modeloTP, string serieTP)
        {
            Tipo_Producto tp = new Tipo_Producto(id, nombreTP, descTP, modeloTP, serieTP);
            tp.Insert_TipoProducto(tp);
        }

        public static void UnsubScribeDataTProducto(int id)
        {
            Tipo_Producto tp = new Tipo_Producto();
            tp.Unsubscribe_TipoProducto(id);
        }

        public static DataTable SearchDataTProducto(string cade)
        {
            Tipo_Producto tp = new Tipo_Producto();
            return tp.Search_TipoProducto(cade);
        }

        public static DataTable ViewDataTProducto()
        {
            Tipo_Producto tp = new Tipo_Producto();
            return tp.View_TipoProducto();
        }

    }
}
