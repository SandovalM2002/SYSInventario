using CapaDatos.Entities;
using System.Data;


namespace CapaNegocio
{
    public class Modelo_Controller
    {

        public static void InsertDataModelo(string numeroModelo)
        {
            Modelo m = new Modelo(numeroModelo);
            m.Insert_Modelo(m);
        }

        public static void UpdateDataModelo(int idModelo, string numeroModelo)
        {
            Modelo m = new Modelo(idModelo,numeroModelo);
            m.Update_Modelo(m);
        }

        public static void UnsubScribeDataModelo(int id)
        {
            Modelo m = new Modelo();
            m.Unsubscribe_Modelo(id);
        }

        public static DataTable SearchDataModelo(int id)
        {
            Modelo m = new Modelo();
            return m.Search_Modelo(id);
        }

        public static DataTable ViewDataModelo()
        {
            Modelo m = new Modelo();
            return m.View_Modelo();
        }
    }
}
