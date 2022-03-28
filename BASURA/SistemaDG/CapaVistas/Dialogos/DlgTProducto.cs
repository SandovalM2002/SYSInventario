using System;
using CapaNegocio;
using System.Windows.Forms;

namespace CapaVistas.Dialogos
{
    public partial class DlgTProducto : Form
    {
        private int renglon;
        private string id;
        TextBox text;

        public DlgTProducto(System.Windows.Forms.TextBox txt)
        {
            InitializeComponent();
            this.text = txt;
        }

        private void Tabla()
        {
            dgvTProducto.Columns[0].Width = 300;
            dgvTProducto.Columns[1].Width = 300;
            dgvTProducto.Columns[2].Width = 300;
            dgvTProducto.Columns[3].Width = 300;
            dgvTProducto.Columns[4].Width = 300;
            dgvTProducto.Columns[5].Width = 300;
            dgvTProducto.Columns[6].Width = 300;
        
        }

        private void VerTabla()
        {
           dgvTProducto.DataSource = null;
           dgvTProducto.DataSource = TipoProducto_Controller.ViewDataTProducto();
        }

        private void DlgTProducto_Load(object sender, EventArgs e)
        {

            if (txtId.Text == " ")
            {
                MessageBox.Show("Debe Seleccionar un Id");
                return;
            }
            else {
                this.txtId.Enabled = false;
                VerTabla();
                Tabla();
            }
        }

        private void dgvTProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvTProducto.Rows[renglon].Cells["Id"].Value.ToString();
            txtId.Text = id;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            text.Text = txtId.Text;
            this.Close();
        }

        private void dgvTProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void txtFinder_TextChanged(object sender, EventArgs e)
        {
            dgvTProducto.DataSource = null;
            dgvTProducto.DataSource = TipoProducto_Controller.SearchDataTProducto(txtFinder.Text);

            Tabla();
        }
    }
}
