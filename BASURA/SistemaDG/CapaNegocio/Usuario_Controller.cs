using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Entities.R.Login;

namespace CapaNegocio
{
    public class Usuario_Controller
    {
        public static void InsertDataUsuario(string user, string contra, int rol)
        {
            Usuario u = new Usuario(user,contra,rol);
            u.Insert_Usurio(u);
        }

        public static void UpdateDataUsuario(int id, string user, string contra, int rol)
        {
            Usuario u = new Usuario(id,user,contra,rol);
            u.Update_Usuario(u);
        }

        public static void UnsubScribeDataUsuario(int id)
        {
            Usuario u = new Usuario();
            u.Unsubscribe_Usuario(id);
        }

        public static DataTable SearchDataUsuario(int id)
        {
            Usuario u = new Usuario();
            return u.Search_Usuario(id);
        }

        public static DataTable ViewDataUsuario()
        {
            Usuario u = new Usuario();
            return u.View_Usuario();
        }
    }
}
