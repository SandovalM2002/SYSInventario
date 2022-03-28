using CapaDatos.Entities;
using CapaDatos.Entities.R.Cliente;
using System.Data;

namespace CapaNegocio
{
    public class TipoCliente_Controller
    {
        public static void InsertDataTipoCliente(string nombreTC, string descrTC)
        {
            Tipo_Cliente tc = new Tipo_Cliente(nombreTC,descrTC);
            tc.Insert_TipoCliente(tc);

        }

        public static void UpdateDataTipoCliente(int idTC, string nombreTC, string descrTC)
        {
            Tipo_Cliente tc = new Tipo_Cliente(idTC, nombreTC, descrTC);
            tc.Update_TipoCliente(tc);
        }

        public static void UnsubScribeTipoCliente(int id)
        {
            Tipo_Cliente tc = new Tipo_Cliente();
            tc.Unsubscribe_TipoCliente(id);
        }

        public static DataTable SearchDataTipoCliente(string Cade)
        {
            Tipo_Cliente tc = new Tipo_Cliente();
            return tc.Search_TipoCliente(Cade);
        }

        public static DataTable ViewDataTipoCliente()
        {
            Tipo_Cliente tc = new Tipo_Cliente();
            return tc.View_TipoCliente();
        }
    }
}
