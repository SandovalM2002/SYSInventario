using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAcces.Controller
{
    public class C_PlanMaestro
    {
        public static DataTable view_Plan_Maestro()
        {
            E_PlanMaestro obj = new E_PlanMaestro();
            return obj.View_Plan_Maestro();
        }

        public static void Insert_Plan_Maestro(string nodo, string demanda, string periodo)
        {
            if(string.IsNullOrWhiteSpace(nodo) || string.IsNullOrWhiteSpace(demanda) || string.IsNullOrWhiteSpace(periodo))
            {
                MessageBox.Show("NO SE PERMITEN VALORES NULOS");
                return;
            }

            if (Convert.ToInt32(demanda) > 0 && Convert.ToInt32(periodo) > 0)
            {
                E_PlanMaestro obj = new E_PlanMaestro(0,Convert.ToInt32(nodo),Convert.ToInt32(demanda),Convert.ToInt32(periodo));
                obj.Insert_Plan_Maestro(obj);
            }
        }

        public static void Update_Plan_Maestro(string id,string nodo, string demanda, string periodo)
        {
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(demanda) || string.IsNullOrWhiteSpace(periodo))
            {
                MessageBox.Show("NO SE PERMITEN VALORES NULOS");
                return;
            }

            if (Convert.ToInt32(demanda) > 0 && Convert.ToInt32(periodo) > 0)
            {
                E_PlanMaestro obj = new E_PlanMaestro(Convert.ToInt32(id), Convert.ToInt32(nodo), Convert.ToInt32(demanda), Convert.ToInt32(periodo));
                obj.Update_Plan_Maestro(obj);
            }
        }

        public static void Delete_Plan_Maestro(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Error con el ID,, seleccione un item de la tabla");
                return;
            }

            E_PlanMaestro obj = new E_PlanMaestro();
            obj.Delete_Plan_Maestro(Convert.ToInt32(id));
        }
    }
}
