
using CapaDatos.Entities.R.Compra;
using System;
using System.Data;


namespace CapaNegocio
{
    public class OrdenCompra_Controller
    {


        public static void InsertDataOrdenCompra(string numeroOrden, int idProv, string producto, int cantidadComprada, float precioUnitario, DateTime fechaPedido, DateTime fechaPago, string terminosEntrega, int idEmpleado)
        {
            Orden_de_Compra oc = new Orden_de_Compra(numeroOrden, idProv,  producto,  cantidadComprada,  precioUnitario,  fechaPedido,  fechaPago,  terminosEntrega,  idEmpleado);
            oc.Insert_OrdenCompra(oc);
        }

        public static void UpdateDataOrdenCompra(int id, string numeroOrden, int idProv, string producto, int cantidadComprada, float precioUnitario, DateTime fechaPedido, DateTime fechaPago, string terminosEntrega, int idEmpleado)
        {
            Orden_de_Compra oc = new Orden_de_Compra(id,numeroOrden, idProv, producto, cantidadComprada, precioUnitario, fechaPedido, fechaPago, terminosEntrega, idEmpleado);
            oc.Update_OrdenCompra(oc);
        }

        public static void UnsubScribeDataOrdenCompra(int id)
        {
            Orden_de_Compra oc = new Orden_de_Compra();
            oc.Unsubscribe_OrdenCompra(id);
        }

        public static DataTable SearchDataOrdenCompra(string cadena)
        {
            Orden_de_Compra oc = new Orden_de_Compra();
            return oc.Search_OrdenCompra(cadena);
        }

        public static DataTable ViewDataOrdenCompra()
        {
            Orden_de_Compra oc = new Orden_de_Compra();
            return oc.View_OrdenCompra();
        }
    }
}
