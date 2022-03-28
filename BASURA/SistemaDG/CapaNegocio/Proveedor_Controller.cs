using CapaDatos.Entities;
using System.Data;

namespace CapaNegocio
{
    public class Proveedor_Controller
    {
        public static void InsertDataProveedor(string nombre, string documento, string numeroDocumento, int ubicacion, string direccion, string telefono, string correo)
        {
            Proveedor p = new Proveedor(nombre,documento,numeroDocumento, ubicacion, direccion, telefono, correo);
            p.Insert_Proveedor(p);
        }

        public static void UpdateDataProveedor(int id, string nombre, string documento, string numeroDocumento, int ubicacion, string direccion, string telefono, string correo)
        {
            Proveedor p = new Proveedor(id, nombre, documento, numeroDocumento, ubicacion, direccion, telefono, correo);
            p.Update_Proveedor(p);
        }

        public static void UnsubScribeDataProveedor(int id)
        {
            Proveedor p = new Proveedor();
            p.Unsubscribe_Proveedor(id);
        }

        public static DataTable SearchDataProveedor(string cade)
        {
            Proveedor p = new Proveedor();
            return p.Search_Proveedor(cade);
        }

        public static DataTable ViewDataProveedor()
        {
            Proveedor p = new Proveedor();
            return p.View_Proveedor();
        }
    }
}
