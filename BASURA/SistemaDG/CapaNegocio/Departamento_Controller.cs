using CapaDatos.Entities;
using System.Data;


namespace CapaNegocio
{
    public class Departamento_Controller
    {
        public static void InsertDataDepartamento(string nombreDepto)
        {
            Departamento d = new Departamento(nombreDepto);
            d.Insert_Departamento(d);
        }

        public static void UpdateDataDepartamento(int idDepto, string nombreDepto)
        {
            Departamento d = new Departamento(idDepto, nombreDepto);
            d.Update_Departamento(d);
        }

        public static void UnsubScribeDataDepartamento(int id)
        {
            Departamento d = new Departamento();
            d.Unsubscribe_Departamento(id);
        }

        public static DataTable SearchDataDepartamento(int id)
        {
            Departamento d = new Departamento();
            return d.Search_Departamento(id);
        }

        public static DataTable ViewDataDepartamento()
        {
            Departamento d = new Departamento();
            return d.View_Departamento();
        }
    }
}
