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
    public static class C_Explosion
    {
        public static DataTable view(int nodo)
        {
            if (string.IsNullOrWhiteSpace(nodo.ToString()))
            {
                MessageBox.Show("Error");
                return null;
            }

            E_Explosion obj = new E_Explosion();
            return obj.View_Explosion(nodo);
        }
        
        public static void Insert(int nodo )
        {
            if (string.IsNullOrWhiteSpace(nodo.ToString()))
            {
                MessageBox.Show("Error");
                return;
            }

            E_Explosion obj = new E_Explosion();
            obj.Insert_Explosion(nodo);
        }
    }
}
