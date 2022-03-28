using System;
using CapaNegocio;
using System.Windows.Forms;

namespace CapaVistas.Dialogos
{
    public partial class DlgDepartamento : Form
    {
        private int renglon;
        private string id;
        TextBox texto;

        public DlgDepartamento(System.Windows.Forms.TextBox txt)
        {
            InitializeComponent();
            this.texto = txt;
        }

        private void VerTabla()
        {
            dgvDepartamento.DataSource = null;
            dgvDepartamento.DataSource = Departamento_Controller.ViewDataDepartamento();
        }

        private void DlgDepartamento_Load(object sender, EventArgs e)
        {
            VerTabla();
        }

        private void dgvDepartamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvDepartamento.Rows[renglon].Cells["Id"].Value.ToString();
            txtId.Text = id;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == " " || txtId.Text == null)
            {
                MessageBox.Show("Debe seleccionar un Id");
                return;
            }
            else
            {
                texto.Text = txtId.Text;
                this.Close();
            }
        }

        private void dgvDepartamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }
    }
}
