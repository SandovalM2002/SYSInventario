using CapaDatos.Entities;
using System.Data;


namespace CapaNegocio
{
    public class Empleado_Controller
    {
        public static void InsertDataEmpleado(string pNombre, string sNombre, string pApellido, string sApellido, string documento, string nuDocumento, string cargo, int departameto, string direccion, string telEmpleado, string correo)
        {
            Empleado e = new Empleado(pNombre, sNombre, pApellido, sApellido, documento, nuDocumento, cargo, departameto, direccion, telEmpleado, correo);
            e.Insert_Empleado(e);
        }

        public static void UpdateDataEmpleado(int id, string pNombre, string sNombre, string pApellido, string sApellido, string documento, string nuDocumento, string cargo, int departameto, string direccion, string telEmpleado, string correo)
        {
            Empleado e = new Empleado(id,pNombre, sNombre,  pApellido, sApellido,  documento,  nuDocumento,  cargo, departameto,  direccion, telEmpleado,  correo);
            e.Update_Empleado(e);
        }

        public static void UnsubScribeDataEmpleado(int id)
        {
            Empleado e = new Empleado();
            e.Unsubscribe_Empleado(id);
        }

        public static DataTable SearchDataEmpleado(string cadena)
        {
            Empleado e = new Empleado();
            return e.Search_Empleado(cadena);
        }

        public static DataTable ViewDataEmpleado()
        {
            Empleado e = new Empleado();
            return e.View_Empleado();
        }
    }
}
