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
    public partial class FrmStock : Form
    {
        private int _row;
        public int id;
        public string nombre;
        public decimal costo;
        public decimal precio;
        public int stock;
        public int stock_s;

        public FrmStock()
        {
            InitializeComponent();
            _row = 0;
        }

        private void txtSearch_P_TextChanged(object sender, EventArgs e)
        {
            dgvProduct.DataSource = null;
            dgvProduct.DataSource = C_Producto.view_search_producto(txtSearch_P.Text);
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                this._row = e.RowIndex;
            }

            if (this._row > 0)
            {
                this.id = Convert.ToInt32(dgvProduct.Rows[_row].Cells["Cod"].Value.ToString());
                this.nombre = dgvProduct.Rows[_row].Cells["Nombre"].Value.ToString();
                this.costo = Convert.ToDecimal(dgvProduct.Rows[_row].Cells["Costo"].Value.ToString());
                this.precio = Convert.ToDecimal(dgvProduct.Rows[_row].Cells["Precio"].Value.ToString());
                this.stock = Convert.ToInt32(dgvProduct.Rows[_row].Cells["Stock"].Value.ToString());
                this.stock_s = Convert.ToInt32(dgvProduct.Rows[_row].Cells["Stock S"].Value.ToString());
            }
        }
        
        private void dgvMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                this._row = e.RowIndex;
            }

            if (this._row > 0)
            {
                this.id = Convert.ToInt32(dgvProduct.Rows[_row].Cells["Cod"].Value.ToString());
                this.nombre = dgvProduct.Rows[_row].Cells["Nombre"].Value.ToString();
                this.costo = Convert.ToDecimal(dgvProduct.Rows[_row].Cells["Costo"].Value.ToString());
                this.stock = Convert.ToInt32(dgvProduct.Rows[_row].Cells["Stock"].Value.ToString());
                this.stock_s = Convert.ToInt32(dgvProduct.Rows[_row].Cells["Stock S"].Value.ToString());
            }
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            dgvProduct.DataSource = null;
            dgvProduct.DataSource = C_Producto.view_search_producto("");

            dgvMaterial.DataSource = null;
            dgvMaterial.DataSource = C_Material.view_search_Material("");
        }

        private void btnAdd_P_Click(object sender, EventArgs e)
        {
            Dialogs.DlgProducto dlg = new Dialogs.DlgProducto(0,"",0,0,0,0,"Guardar");
            dlg.ShowDialog();

            dgvProduct.DataSource = null;
            dgvProduct.DataSource = C_Producto.view_search_producto("");
        }

        private void btnUpdate_P_Click(object sender, EventArgs e)
        {
            Dialogs.DlgProducto dlg = new Dialogs.DlgProducto(id,nombre,costo,precio,stock,stock_s, "Modificar");
            dlg.ShowDialog();

            dgvProduct.DataSource = null;
            dgvProduct.DataSource = C_Producto.view_search_producto("");
        }

        private void btnDesactivar_P_Click(object sender, EventArgs e)
        {
            C_Producto.Unsubscribe_producto(id.ToString());
            dgvProduct.DataSource = null;
            dgvProduct.DataSource = C_Producto.view_search_producto("");
        }

        private void btnAdd_M_Click(object sender, EventArgs e)
        {
            Dialogs.DlgMaterial dlg = new Dialogs.DlgMaterial(0,"",0,0,0, "Guardar");
            dlg.ShowDialog();

            dgvMaterial.DataSource = null;
            dgvMaterial.DataSource = C_Material.view_search_Material("");
        }

        private void btnUpdate_M_Click(object sender, EventArgs e)
        {
            Dialogs.DlgMaterial dlg = new Dialogs.DlgMaterial(id,nombre,costo,stock,stock_s, "Modificar");
            dlg.ShowDialog();

            dgvMaterial.DataSource = null;
            dgvMaterial.DataSource = C_Material.view_search_Material("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            C_Material.Unsubscribe_Material(id.ToString());
            dgvMaterial.DataSource = null;
            dgvMaterial.DataSource = C_Material.view_search_Material("");
        }

        private void txtSearch_M_TextChanged(object sender, EventArgs e)
        {
            dgvMaterial.DataSource = null;
            dgvMaterial.DataSource = C_Material.view_search_Material(txtSearch_M.Text);
        }
    }
}
