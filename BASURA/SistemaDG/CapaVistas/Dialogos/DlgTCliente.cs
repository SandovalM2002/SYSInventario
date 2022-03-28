using System;
using CapaNegocio;
using CapaVistas.FrameMDI;
using System.Windows.Forms;

namespace CapaVistas.Dialogos
{
    public partial class DlgTCliente : Form
    {
        int renglon;
        string id;
        TextBox texto;

        public DlgTCliente(System.Windows.Forms.TextBox txt)
        {
            InitializeComponent();
            this.texto = txt;
        }
        
        private void VerTabla()
        {
            dgvTCliente.DataSource = null;
            dgvTCliente.DataSource = TipoCliente_Controller.ViewDataTipoCliente();
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
                this.Close();
                texto.Text = txtId.Text;
            }
        }

        private void DlgTCliente_Load(object sender, EventArgs e)
        {
            VerTabla();
        }

        private void dgvTCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvTCliente.Rows[renglon].Cells["Id"].Value.ToString();
            txtId.Text = id;
        }

        private void dgvTCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void txtFinder_TextChanged(object sender, EventArgs e)
        {
            dgvTCliente.DataSource = null;
            dgvTCliente.DataSource = TipoCliente_Controller.SearchDataTipoCliente(txtFinder.Text);
            
        }
    }
}
