using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class SumaryHome_Controller
    {
        public static void TotalHome()
        {
            TotalData a = new TotalData();
            a.ShowTotal(a);
        }
    }
}
