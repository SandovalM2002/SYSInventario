using CapaDatos.Entities.R.Compra;
using System;
using System.Data;


namespace CapaNegocio
{
    public class DevOrdenCompra_Controller
    {

        public static void InsertDataDevOrdenCompra(int idOrden, int cantidadDev, string observacion, DateTime fechaDev)
        {
            DevOrden_Compra dev = new DevOrden_Compra(idOrden,cantidadDev,observacion,fechaDev);
            dev.Insert_DevOrdenCompra(dev);
        }

        public static void UpdateDataDevOrdenCompra(int idDev, int idOrden, int cantidadDev, string observacion, DateTime fechaDev)
        {
            DevOrden_Compra dev = new DevOrden_Compra(idDev,idOrden, cantidadDev, observacion, fechaDev);
            dev.Insert_DevOrdenCompra(dev);
        }

        public static void UnsubScribeDataDevOrdenCompra(int id)
        {
            DevOrden_Compra dev = new DevOrden_Compra();
            dev.Unsubscribe_DevOrdenCompra(id);
        }

        public static DataTable SearchDataDevOrdenCompra(string caden)
        {
            DevOrden_Compra dev = new DevOrden_Compra();
            return dev.Search_DevOrdenCompra(caden);
        }

        public static DataTable ViewDataDevOrdenCompra()
        {
            DevOrden_Compra dev = new DevOrden_Compra();
            return dev.View_DevOrdenCompra();
        }
    }
}
