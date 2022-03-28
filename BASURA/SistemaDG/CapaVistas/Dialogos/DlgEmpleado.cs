using System;
using CapaNegocio;
using System.Windows.Forms;

namespace CapaVistas.Dialogos
{
    public partial class DlgEmpleado : Form
    {
        string id;
        private int renglon;
        TextBox txtPrueba;

        public DlgEmpleado(System.Windows.Forms.TextBox txt)
        {
            InitializeComponent();
            txtPrueba = txt;
        }

        private void VerTabla()
        {
            dgvEmpleado.DataSource = null;
            dgvEmpleado.DataSource = Empleado_Controller.ViewDataEmpleado();
        }

        private void Tabla()
        {
            dgvEmpleado.Columns[0].Width = 100;
            dgvEmpleado.Columns[1].Width = 250;
            dgvEmpleado.Columns[2].Width = 250;
            dgvEmpleado.Columns[3].Width = 250;
            dgvEmpleado.Columns[4].Width = 250;
            dgvEmpleado.Columns[5].Width = 250;
            dgvEmpleado.Columns[6].Width = 250;
            dgvEmpleado.Columns[7].Width = 250;
            dgvEmpleado.Columns[8].Width = 250;
            dgvEmpleado.Columns[9].Width = 300;
            dgvEmpleado.Columns[10].Width = 250;
            dgvEmpleado.Columns[11].Width = 250;
            dgvEmpleado.Columns[12].Width = 100;
        }

        private void DlgEmpleado_Load(object sender, EventArgs e)
        {
            VerTabla();
            Tabla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == " " || txtId.Text == null)
            {
                MessageBox.Show("Debe Seleccinar un Id");
                return;
            }
            else
            {
                txtPrueba.Text = txtId.Text;
                this.Close();
            }
        }

        private void dgvEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvEmpleado.Rows[renglon].Cells["Id"].Value.ToString();
            txtId.Text = id;
        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void txtFinder_TextChanged(object sender, EventArgs e)
        {
            dgvEmpleado.DataSource = null;
            dgvEmpleado.DataSource = Empleado_Controller.SearchDataEmpleado(txtFinder.Text);

            Tabla();
        }
    }
}
