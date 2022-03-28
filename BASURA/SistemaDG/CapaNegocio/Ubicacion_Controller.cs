using CapaDatos;
using CapaDatos.Entities;
using System.Data;

namespace CapaNegocio
{
    public class Ubicacion_Controller
    {

        public static void InsertDataUbicacion(string nombrePais, string deptoPais)
        {
            Ubicacion u = new Ubicacion(nombrePais, deptoPais);
            u.Insert_Ubicacion(u);
        }

        public static void UpdateDataUbicacion(int idUbicacion, string nombrePais, string deptoPais)
        {
            Ubicacion u = new Ubicacion(idUbicacion, nombrePais, deptoPais);
            u.Update_Ubicacion(u);
        }

        public static void UnsubScribeDataUbicacion(int id)
        {
            Ubicacion u = new Ubicacion();
            u.Unsubscribe_Ubicacion(id);
        }

        public static DataTable SearchDataUbicacion(string cade)
        {
            Ubicacion u = new Ubicacion();
            return u.Search_Ubicacion(cade);
        }

        public static DataTable ViewDataUbicacion()
        {
            Ubicacion u = new Ubicacion();
            return u.View_Ubicacion();
        }
    }
}
