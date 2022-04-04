using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Controller
{
    public class C_ModeloABC
    {
        public static DataTable view_ABC()
        {
            E_ModeloABC obj = new E_ModeloABC();
            return obj.ABC();
        }
    }
}
