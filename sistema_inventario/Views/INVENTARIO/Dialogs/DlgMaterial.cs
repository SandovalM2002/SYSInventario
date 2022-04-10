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
    public partial class DlgMaterial : Form
    {
        public DlgMaterial(int id, string nombre, decimal costo, int stock, int stock_s, string Titulo)
        {
            InitializeComponent();

            this.btnOk.Text = "";
            this.btnOk.Text = Titulo;
            if (btnOk.Text == "Modificar")
            {
                this.txtId.Text = id.ToString();
                this.txtNombre.Text = nombre;
                this.txtCosto.Text = costo.ToString();
                this.txtStock.Value = stock;
                this.txtStock_S.Value = stock_s;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (btnOk.Text == "Guardar")
            {
                C_Material.insertar_Material(txtNombre.Text, txtCosto.Text, txtStock.Value.ToString(), txtStock_S.Value.ToString());
                this.btnOk.Text = "";
                this.Close();
            }
            else if (btnOk.Text == "Modificar")
            {
                C_Material.update_Material(txtId.Text, txtNombre.Text, txtCosto.Text,txtStock.Value.ToString(), txtStock_S.Value.ToString());
                this.btnOk.Text = "";
                this.Close();
            }
        }
    }
}
