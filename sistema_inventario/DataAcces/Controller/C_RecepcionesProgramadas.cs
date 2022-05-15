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
    public class C_RecepcionesProgramadas
    {
        public static DataTable view_recepciones_programdas()
        {
            E_RepecionProgramada obj = new E_RepecionProgramada();
            return obj.View_Recepciones_Programadas();
        }

        public static void insert_recepciones_programadas(string nodo, string cantidad, string periodo)
        {

            if (string.IsNullOrWhiteSpace(nodo) || string.IsNullOrWhiteSpace(cantidad.ToString()) || string.IsNullOrWhiteSpace(periodo.ToString()))
            {
                MessageBox.Show("Campos Vacios");
                return;
            }

            int cant = Convert.ToInt32(cantidad);
            int perd = Convert.ToInt32(periodo);
            int nod = Convert.ToInt32(nodo);
            if (cant > 0 && perd > 0)
            {
                E_RepecionProgramada obj = new E_RepecionProgramada(0, nod, cant, perd);
                obj.Insert_Recepciones_Programadas(obj);
            }
        }


        public static void update_recepciones_programadas(string id, string nodo, string cantidad, string periodo)
        {

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(nodo) || string.IsNullOrWhiteSpace(cantidad.ToString()) || string.IsNullOrWhiteSpace(periodo.ToString()))
            {
                MessageBox.Show("Campos Vacios");
                return;
            }


            int cant = Convert.ToInt32(cantidad);
            int perd = Convert.ToInt32(periodo);
            int nod = Convert.ToInt32(nodo);
            if (cant > 0 && perd > 0)
            {
                E_RepecionProgramada obj = new E_RepecionProgramada(Convert.ToInt32(id), nod, cant, perd);
                obj.Update_Recepciones_Programadas(obj);
            }
        }

        public static void delete_recepciones_programadas(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Error con el ID,, seleccione un item de la tabla");
                return;
            }

            E_RepecionProgramada obj = new E_RepecionProgramada();
            obj.Unsubscribe_Recepciones_Programadas(Convert.ToInt32(id));
        }
    }
}