using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;

using System.Windows.Forms;

namespace CapaVistas.Dialogos
{
    public partial class DlgProveedor : Form
    {
        private int renglon;
        private string id;
        TextBox textbox;

        public DlgProveedor(System.Windows.Forms.TextBox txt)
        {
            InitializeComponent();
            this.textbox = txt;
        }
        
        private void VerTabla()
        {
            dgvProveedor.DataSource = null;
            dgvProveedor.DataSource = Proveedor_Controller.ViewDataProveedor();
        }

        private void Tabla()
        {
            dgvProveedor.Columns[0].Width = 100;
            dgvProveedor.Columns[1].Width = 300;
            dgvProveedor.Columns[2].Width = 300;
            dgvProveedor.Columns[3].Width = 300;
            dgvProveedor.Columns[4].Width = 300;
            dgvProveedor.Columns[5].Width = 300;
            dgvProveedor.Columns[6].Width = 300;
            dgvProveedor.Columns[7].Width = 300;
            dgvProveedor.Columns[8].Width = 300;
            dgvProveedor.Columns[9].Width = 300;
        }
        
        private void DlgProveedor_Load(object sender, EventArgs e)
        {
            VerTabla();
            Tabla();
        }

        private void dgvProductoAgregado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvProveedor.Rows[renglon].Cells["Id"].Value.ToString();
            txtId.Text = id;
        }

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == " ")
            {
                MessageBox.Show("Debe Seleccionar un Id");
                return;
            }
            else
            {
                textbox.Text = txtId.Text;
                this.Close();
            }
        }

        private void txtFinder_TextChanged(object sender, EventArgs e)
        {
            dgvProveedor.DataSource = null;
            dgvProveedor.DataSource = Proveedor_Controller.SearchDataProveedor(txtFinder.Text);

            Tabla(); 
        }
    }
}
