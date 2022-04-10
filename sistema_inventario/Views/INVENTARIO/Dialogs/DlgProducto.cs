using DataAcces.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.INVENTARIO.Dialogs
{
    public partial class DlgProducto : Form
    {
        
        public DlgProducto(int id, string nombre, decimal costo, decimal precio, int stock, int stock_s, string Titulo)
        {
            InitializeComponent();
            this.txtId.Text = id.ToString();
            this.txtNombre.Text = nombre;
            this.txtCosto.Text = costo.ToString();
            this.txtPrecio.Text = precio.ToString();
            this.txtStock.Value = stock;
            this.txtStock_S.Value = stock_s;
            this.btnOk.Text = "";
            this.btnOk.Text = Titulo;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (btnOk.Text == "Guardar")
            {
                C_Producto.insertar_producto(txtNombre.Text,txtCosto.Text,txtPrecio.Text,txtStock.Value.ToString(), txtStock_S.Value.ToString());
                this.btnOk.Text = "";
                this.Close();
            } else if(btnOk.Text == "Modificar")
            {
                C_Producto.update_producto(txtId.Text,txtNombre.Text, txtCosto.Text, txtPrecio.Text, txtStock.Value.ToString(), txtStock_S.Value.ToString());
                this.btnOk.Text = "";
                this.Close();
            }
        }
    }
}
