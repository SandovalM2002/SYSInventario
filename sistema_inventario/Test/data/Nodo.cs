using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.data
{
    public class Nodo
    {
        private int id_Nodo;
        private int id_Producto_Nodo;
        private int id_Material_Nodo;
        private int cantidad_Nodo;
        private int plazo_Nodo;

        public Nodo(int id_Nodo, int id_Producto_Nodo, int id_Material_Nodo, int cantidad_Nodo, int plazo_Nodo)
        {
            this.id_Nodo = id_Nodo;
            this.id_Producto_Nodo = id_Producto_Nodo;
            this.id_Material_Nodo = id_Material_Nodo;
            this.cantidad_Nodo = cantidad_Nodo;
            this.plazo_Nodo = plazo_Nodo;
        }

        public int Id_Nodo { get => id_Nodo; set => id_Nodo = value; }
        public int Id_Producto_Nodo { get => id_Producto_Nodo; set => id_Producto_Nodo = value; }
        public int Id_Material_Nodo { get => id_Material_Nodo; set => id_Material_Nodo = value; }
        public int Cantidad_Nodo { get => cantidad_Nodo; set => cantidad_Nodo = value; }
        public int Plazo_Nodo { get => plazo_Nodo; set => plazo_Nodo = value; }
    }
}
