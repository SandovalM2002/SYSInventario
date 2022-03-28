using System;
using CapaNegocio;
using System.Windows.Forms;



namespace CapaVistas.Dialogos
{
    public partial class DlgUbicacion : Form
    {
        private string id;
        private int renglon;
        TextBox texto;

        public DlgUbicacion(System.Windows.Forms.TextBox txt)
        {
            InitializeComponent();
            this.texto = txt;
        }
        
        private void VerTabla()
        {
            dgvUbicion.DataSource = null;
            dgvUbicion.DataSource = Ubicacion_Controller.ViewDataUbicacion();
        }
        
        private void DlgUbicacion_Load(object sender, EventArgs e)
        {
            VerTabla();
        }

        private void dgvUbicion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvUbicion.Rows[renglon].Cells["Id"].Value.ToString();
            txtId.Text = id;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == " " || txtId.Text == null)
            {
                MessageBox.Show("No ha Ingresado un Id");
                return;
            }
            else
            {
                texto.Text = txtId.Text;

                this.Close();
            }
        }

        private void dgvUbicion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void txtFinder_TextChanged(object sender, EventArgs e)
        {
            dgvUbicion.DataSource = null;
            dgvUbicion.DataSource = Ubicacion_Controller.SearchDataUbicacion(txtFinder.Text);
        }
    }
}
