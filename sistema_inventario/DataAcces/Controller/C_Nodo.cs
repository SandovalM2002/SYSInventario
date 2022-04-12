using DataAcces.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Controller
{
    public class C_Nodo
    {
        public static DataSet CargarNodos()
        {
            E_Nodo obj = new E_Nodo();
            return obj.cargaNodosSQL();
        }
    }
}
