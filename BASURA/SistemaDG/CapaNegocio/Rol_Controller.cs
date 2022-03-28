using CapaDatos.Entities;
using System.Data;

namespace CapaNegocio
{
    public class Rol_Controller
    {

        public static void InsertDataRol(string nombreRol)
        {
            Rol r = new Rol(nombreRol);
            r.Insert_Rol(r);
        }

        public static void UpdateDataRol(int idRol, string nombreRol)
        {
            Rol r = new Rol(idRol,nombreRol);
            r.Update_Rol(r);
        }

        public static void UnsubScribeDataRol(int id)
        {
            Rol r = new Rol();
            r.Unsubscribe_Rol(id);
        }

        public static DataTable SearchDataRol(int id)
        {
            Rol r = new Rol();
            return r.Search_Rol(id);
        }

        public static DataTable ViewDataRol()
        {
            Rol r = new Rol();
            return r.View_Rol();
        }
    }
}
