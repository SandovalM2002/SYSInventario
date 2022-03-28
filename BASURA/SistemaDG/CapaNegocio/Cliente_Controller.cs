using System.Data;
using CapaDatos.Entities.R.Cliente;

namespace CapaNegocio
{
    public class Cliente_Controller
    {
        
        public static void InsertDataCliente(int tipoCliente, string documento, string pNombre, string sNombre, string pApellido, string sApellido, string nEmpresa, int depto, string direccion, string correo, string telCliente)
        {
            Cliente c = new Cliente(tipoCliente, documento,pNombre,sNombre, pApellido, sApellido,nEmpresa, depto, direccion, correo,telCliente);
            c.Insert_Cliente(c);
        }

        public static void UpdateDataCliente(int idCliente, int tipoCliente, string documento, string pNombre, string sNombre, string pApellido, string sApellido, string nEmpresa, int depto, string direccion, string correo, string telCliente)
        {
            Cliente c = new Cliente(idCliente, tipoCliente, documento, pNombre, sNombre, pApellido, sApellido, nEmpresa, depto, direccion, correo, telCliente);
            c.Update_Cliente(c);
        }

        public static void UnsubScribeDataCliente(int id)
        {
            Cliente c = new Cliente();
            c.Unsubscribe_Cliente(id);
        }

        public static DataTable SearchDataCliente(string cadena)
        {
            Cliente c = new Cliente();
            return c.Search_Cliente(cadena);
        }

        public static DataTable ViewDataCliente()
        {
            Cliente c = new Cliente();
            return c.View_Cliente();
        }
    }
}
