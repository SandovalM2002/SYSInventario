using System;
using CapaVistas.Dialogos;
using CapaNegocio;
using System.Windows.Forms;

namespace CapaVistas.FrameMDI
{
    public partial class FrmProveedor : Form
    {
        private DlgUbicacion ubi;
        private int renglon;

        public FrmProveedor()
        {
            InitializeComponent();
        }
        
        private void Clear()
        {
            txtId.Text = " ";
            txtNombre.Text = " ";
            txtNDocumento.Text = " ";
            txtDireccion.Text = " ";
            txtTelefono.Text = " ";
            txtCorreo.Text = " ";
            cmbTipoDoc.Text = " ";
            txtId_Ubicacion.Text = " ";
        }

        private void VerTabla()
        {
            dgvProveedor.DataSource = null;
            dgvProveedor.DataSource = Proveedor_Controller.ViewDataProveedor();
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            VerTabla();
            this.txtId.Enabled = false;
        }

        private void btnAdd_IdUbicacion_Click(object sender, EventArgs e)
        {
            ubi = new DlgUbicacion(txtId_Ubicacion);
            ubi.ShowDialog();
        }


        //DATAGRID VIEW
        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void dgvProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id ,nombre, documento, numeroDocumento, ubicacion, direccion, telefono, correo;

            id = dgvProveedor.Rows[renglon].Cells["Id"].Value.ToString();
            txtId.Text = id;

            nombre = dgvProveedor.Rows[renglon].Cells["Proveedor"].Value.ToString();
            txtNombre.Text = nombre;

            documento = dgvProveedor.Rows[renglon].Cells["Tipo de Documento"].Value.ToString();
            cmbTipoDoc.Text = documento;

            numeroDocumento = dgvProveedor.Rows[renglon].Cells["Numero del Documento"].Value.ToString();
            txtNDocumento.Text = numeroDocumento;

            ubicacion = dgvProveedor.Rows[renglon].Cells["Id Ubicacion"].Value.ToString();
            txtId_Ubicacion.Text = ubicacion;

            direccion = dgvProveedor.Rows[renglon].Cells["Direccion"].Value.ToString();
            txtDireccion.Text = direccion;

            telefono = dgvProveedor.Rows[renglon].Cells["Telefono"].Value.ToString();
            txtTelefono.Text = telefono;

            correo = dgvProveedor.Rows[renglon].Cells["Correo"].Value.ToString();
            txtCorreo.Text = correo;

        }


        //=======================================================================|| GUARDAR, EDITAR Y ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id;

            if (txtId.Text == " ")
            {
                MessageBox.Show("Debe seleccionar un Id");
                return;
            }
            else
            {
                id = Convert.ToInt32(txtId.Text);

                Proveedor_Controller.UnsubScribeDataProveedor(id);
                VerTabla();
                Clear();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id, idUbi;
            string nombre, documento, numeroDocumento, direccion, telefono, correo;

            if (txtId_Ubicacion.Text == " " || txtNombre.Text == " " || txtTelefono.Text == " ")
            {
                MessageBox.Show("Error de Campo");
                return;
            }
            else
            {
                id = Convert.ToInt32(txtId.Text);
                nombre = txtNombre.Text;
                documento = cmbTipoDoc.Text;
                numeroDocumento = txtNDocumento.Text;
                direccion = txtDireccion.Text;
                telefono = txtTelefono.Text;
                correo = txtCorreo.Text;
                idUbi = Convert.ToInt32(txtId_Ubicacion.Text);

                if (telefono.Substring(1, 1) == "2" || telefono.Substring(1, 1) == "5" || telefono.Substring(1, 1) == "7" || telefono.Substring(1, 1) == "8")
                {
                    Proveedor_Controller.UpdateDataProveedor(id, nombre, documento, numeroDocumento, idUbi, direccion, telefono, correo);
                    VerTabla();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Error con el Telefono \n Los numeros telefonicos deben comenzar con '2','5','7', o '8'");
                    return;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int  idUbi; 
            string nombre, documento, numeroDocumento, direccion, telefono, correo;

            if (txtId_Ubicacion.Text == " " || txtNombre.Text == " " || txtTelefono.Text == " ")
            {
                MessageBox.Show("Error de Campo");
                return;
            }
            else
            {
                nombre = txtNombre.Text;
                documento = cmbTipoDoc.Text;
                numeroDocumento = txtNDocumento.Text;
                direccion = txtDireccion.Text;
                telefono = txtTelefono.Text;
                correo = txtCorreo.Text;
                idUbi = Convert.ToInt32(txtId_Ubicacion.Text);

                if (telefono.Substring(1, 1) == "2" || telefono.Substring(1, 1) == "5" || telefono.Substring(1, 1) == "7" || telefono.Substring(1, 1) == "8")
                {
                    Proveedor_Controller.InsertDataProveedor(nombre, documento, numeroDocumento, idUbi, direccion, telefono, correo);

                    VerTabla();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Error con el Telefono \n Los numeros telefonicos deben comenzar con '2','5','7', o '8'");
                    return;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtFinder_TextChanged(object sender, EventArgs e)
        {
            dgvProveedor.DataSource = null;
            dgvProveedor.DataSource = Proveedor_Controller.SearchDataProveedor(txtFinder.Text);
        }
    }
}
