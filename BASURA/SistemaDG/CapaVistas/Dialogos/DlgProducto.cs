using System;
using CapaNegocio;
using System.Windows.Forms;

namespace CapaVistas.Dialogos
{
    public partial class DlgProducto : Form
    {
        private int renglon;
        private string id;
        TextBox tex;

        public DlgProducto(System.Windows.Forms.TextBox txt)
        {
            InitializeComponent();
            tex = txt;
        }

        private void VerTabla()
        {
            dgvProducto.DataSource = null;
            dgvProducto.DataSource = Producto_Controller.ViewDataProducto();
        }

        private void Tabla()
        {
            dgvProducto.Columns[0].Width = 300;
            dgvProducto.Columns[1].Width = 300;
            dgvProducto.Columns[2].Width = 300;
            dgvProducto.Columns[3].Width = 300;
            dgvProducto.Columns[4].Width = 300;
            dgvProducto.Columns[5].Width = 300;
            dgvProducto.Columns[6].Width = 300;
            dgvProducto.Columns[7].Width = 300;
            dgvProducto.Columns[8].Width = 300;
        }

        private void dgvProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvProducto.Rows[renglon].Cells["Id"].Value.ToString();
            txtId.Text = id;
        }

        private void DlgProducto_Load(object sender, EventArgs e)
        {
            VerTabla();
            Tabla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == " ")
            {
                MessageBox.Show("Debe seleccionar Un Id");
                return;
            }
            else
            {
                this.Close();
                tex.Text = txtId.Text;
            }
        }

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void txtFinder_TextChanged(object sender, EventArgs e)
        {
            dgvProducto.DataSource = null;
            dgvProducto.DataSource = Producto_Controller.SearchDataProducto(txtFinder.Text);

            Tabla();
        }

    }
}
