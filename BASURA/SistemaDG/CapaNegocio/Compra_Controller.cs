using CapaDatos.Entities.R.Compra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace CapaNegocio
{
    public class Compra_Controller
    {
        public static void InsertDataCompra(int idProd, int cantComprada, float precioCompra, int idEmpleado, DateTime fechaCompra)
        {
            Compra c = new Compra(idProd,cantComprada, precioCompra, idEmpleado, fechaCompra);
            c.Insert_Compra(c);
        }

        public static void UpdateDataCompra(int idC, int idProd, int cantComprada, float precioCompra, int idEmpleado, DateTime fechaCompra)
        {
            Compra c = new Compra(idC,idProd, cantComprada, precioCompra, idEmpleado, fechaCompra);
            c.Update_Compra(c);
        }

        public static void UnsubScribeDataCompra(int id)
        {
            Compra c = new Compra();
            c.Unsubscribe_Compra(id);
        }

        public static DataTable SearchDataCompra(string cadena)
        {
            Compra c = new Compra();
            return c.Search_Compra(cadena);
        }

        public static DataTable ViewDataCompra()
        {
            Compra c = new Compra();
            return c.View_Compra();
        }
    }
}
