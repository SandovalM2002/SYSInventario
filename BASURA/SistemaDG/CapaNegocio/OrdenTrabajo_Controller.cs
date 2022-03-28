
using CapaDatos.Entities.R.OrdenTrabajo;
using System;
using System.Data;


namespace CapaNegocio
{
    public class OrdenTrabajo_Controller
    {
        public static void InsertDataOrdenTrabajo( int NumOrden,int idCliente, string producto, string marcaProd, string serieProd, string modeloProd, DateTime fechaOrden, string trabajoRealizado, string observaciones)
        {
            Orden_Trabajo ot = new Orden_Trabajo(NumOrden, idCliente,producto,marcaProd,serieProd,modeloProd,fechaOrden,trabajoRealizado,observaciones);
            ot.Insert_OrdenTrabajo(ot);
        }

        public static void UpdateDataOrdenTrabajo(int id, int NumOrden, int idCliente, string producto, string marcaProd, string serieProd, string modeloProd, DateTime fechaOrden, string trabajoRealizado, string observaciones)
        {
            Orden_Trabajo ot = new Orden_Trabajo(id,NumOrden ,idCliente, producto, marcaProd, serieProd, modeloProd, fechaOrden, trabajoRealizado, observaciones);
            ot.Update_OrdenTrabajo(ot);
        }

        public static void UnsubScribeDataOrdenTrabajo(int id)
        {
            Orden_Trabajo ot = new Orden_Trabajo();
            ot.Unsubscribe_OrdenTrabajo(id);
        }

        public static DataTable SearchDataOrdenTrabajo(string cadena)
        {
            Orden_Trabajo ot = new Orden_Trabajo();
            return ot.Search_OrdenTrabajo(cadena);
        }

        public static DataTable ViewDataOrdenTrabajo()
        {
            Orden_Trabajo ot = new Orden_Trabajo();
            return ot.View_OrdenTrabajo();
        }
    }
}
