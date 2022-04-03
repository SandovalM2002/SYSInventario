using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Entity
{
    public class E_Producto
    {
        private int id_producto;
        private string nombre_producto;
        private decimal costo_producto;
        private decimal precio_producto;
        private int existencia_producto;
        private string demanda_producto;
        private float tasaM_producto;
        private int stockSeguridad_producto;
        private bool estado_producto;

        public E_Producto(int id_producto, string nombre_producto, decimal costo_producto, decimal precio_producto, int existencia_producto, string demanda_producto, float tasaM_producto, int stockSeguridad_producto, bool stado)
        {
            this.id_producto = id_producto;
            this.nombre_producto = nombre_producto;
            this.costo_producto = costo_producto;
            this.precio_producto = precio_producto;
            this.existencia_producto = existencia_producto;
            this.demanda_producto = demanda_producto;
            this.tasaM_producto = tasaM_producto;
            this.stockSeguridad_producto = stockSeguridad_producto;
            this.estado = stado;
        }

        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public decimal Costo_producto { get => costo_producto; set => costo_producto = value; }
        public decimal Precio_producto { get => precio_producto; set => precio_producto = value; }
        public int Existencia_producto { get => existencia_producto; set => existencia_producto = value; }
        public string Demanda_producto { get => demanda_producto; set => demanda_producto = value; }
        public float TasaM_producto { get => tasaM_producto; set => tasaM_producto = value; }
        public int StockSeguridad_producto { get => stockSeguridad_producto; set => stockSeguridad_producto = value; }
        public bool Stado { get => stado; set => stado = value; }
    
        //METODOS DE LA BASE DE DATOS

    }
}
