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

namespace Views.INVENTARIO
{
    public partial class FrmStockProducto : Form
    {
        public FrmStockProducto()
        {
            InitializeComponent();
        }


        public void LoadProduct()
        {
            dgvStock.DataSource = null;
            dgvStock.DataSource = C_Producto.view_search_producto("");
         
        }


        private void FrmStockProducto_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void txtFinder_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgvStock.DataSource = null;
            dgvStock.DataSource = C_Producto.view_search_producto(txtFinder.Text);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }
    }
}
