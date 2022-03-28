using System;
using CapaNegocio;
using CapaVistas.Dialogos;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CapaVistas.FrameMDI
{
    public partial class FrmEmpleado : Form
    {
        private int renglon;
        private DlgDepartamento depart;

        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            txtId.Text = " ";
            txtPNombre.Text = " ";
            txtSNombre.Text = " ";
            txtPApellido.Text = "";
            txtSApellido.Text = " ";
            txtDireccion.Text = " ";
            txtDocumento.Text = " ";
            txtTel.Text = " ";
            txtCorreo.Text = " ";
            txtId_Departamento.Text = " ";
        }


        private void VerTabla()
        {
            dgvEmpleado.DataSource = null;
            dgvEmpleado.DataSource = Empleado_Controller.ViewDataEmpleado();
        }
        
        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            VerTabla();
            this.txtId.Enabled = false;
        }

        private void btnAdd_IdDepartamento_Click(object sender, EventArgs e)
        {
            depart = new DlgDepartamento(txtId_Departamento);
            depart.ShowDialog();
        }

        private void dgvEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            string pNombre, sNombre, pApellido, sApellido, documento, nuDocumento, cargo, departameto, direccion, telEmpleado, correo;

            if (renglon >= 0)
            {

                id = dgvEmpleado.Rows[renglon].Cells["Id"].Value.ToString();
                txtId.Text = id;

                pNombre = dgvEmpleado.Rows[renglon].Cells["Primer Nombre"].Value.ToString();
                txtPNombre.Text = pNombre;

                sNombre = dgvEmpleado.Rows[renglon].Cells["Segundo Nombre"].Value.ToString();
                txtSNombre.Text = sNombre;

                pApellido = dgvEmpleado.Rows[renglon].Cells["Primer Apellido"].Value.ToString();
                txtPApellido.Text = pApellido;

                sApellido = dgvEmpleado.Rows[renglon].Cells["Segundo Apellido"].Value.ToString();
                txtSApellido.Text = sApellido;

                documento = dgvEmpleado.Rows[renglon].Cells["Documento"].Value.ToString();
                cmbTipoDocumento.Text = documento;

                nuDocumento = dgvEmpleado.Rows[renglon].Cells["Numero Documento"].Value.ToString();
                txtDocumento.Text = nuDocumento;

                cargo = dgvEmpleado.Rows[renglon].Cells["Cargo"].Value.ToString();
                cmbCargo.Text = cargo;

                departameto = dgvEmpleado.Rows[renglon].Cells["Id Departamento"].Value.ToString();
                txtId_Departamento.Text = departameto;

                direccion = dgvEmpleado.Rows[renglon].Cells["Direccion"].Value.ToString();
                txtDireccion.Text = direccion;

                telEmpleado = dgvEmpleado.Rows[renglon].Cells["Telefono"].Value.ToString();
                txtTel.Text = telEmpleado;

                correo = dgvEmpleado.Rows[renglon].Cells["Correo"].Value.ToString();
                txtCorreo.Text = correo;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Fila de la Tabla");
                return;
            }
        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }
        
        //========================================================|| MEOTDOS DE GUARDAR, EDITAR Y ELIMINAR
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int depto;
            string pNombre, sNombre, pApellido, sApellido, documento, nuDocumento, cargo, direccion, telEmpleado, correo;

            //Solo el segundo nombre y apellido, y el correo son pueden ser nulos
            if (
                txtPNombre.Text == " " || txtPApellido.Text == " " || txtDocumento.Text == " " || txtId_Departamento.Text == " " ||
                cmbCargo.Text == " " || cmbTipoDocumento.Text == " " || txtDireccion.Text == " " || txtTel.Text == " "
                )
            {
                MessageBox.Show("Error en los Campos");
                return;
            }
            else
            {

                pNombre = txtPNombre.Text;
                sNombre = txtSNombre.Text;
                pApellido = txtPApellido.Text;
                sApellido = txtSApellido.Text;
                documento = cmbTipoDocumento.Text;
                nuDocumento = txtDocumento.Text;
                cargo = cmbCargo.Text;
                depto = Convert.ToInt32(txtId_Departamento.Text);
                direccion = txtDireccion.Text;
                telEmpleado = txtTel.Text;
                correo = txtCorreo.Text;

                if (telEmpleado.Substring(1, 1) == "2" || telEmpleado.Substring(1, 1) == "5" || telEmpleado.Substring(1, 1) == "7" || telEmpleado.Substring(1, 1) == "8")
                {
                    Empleado_Controller.InsertDataEmpleado(pNombre, sNombre, pApellido, sApellido, documento, nuDocumento, cargo, depto, direccion, telEmpleado, correo);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id, depto;
            string pNombre, sNombre, pApellido, sApellido, documento, nuDocumento, cargo, direccion, telEmpleado, correo;

            //Solo el segundo nombre y apellido, y el correo son pueden ser nulos
            if (
                txtPNombre.Text == " " || txtPApellido.Text == " " || txtDocumento.Text == " " || txtId_Departamento.Text == " " ||
                cmbCargo.Text == " " || cmbTipoDocumento.Text == " " || txtDireccion.Text == " " || txtTel.Text == " "
                )
            {
                MessageBox.Show("Error en los Campos");
                return;
            }
            else
            {
                id = Convert.ToInt32(txtId.Text);
                pNombre = txtPNombre.Text;
                sNombre = txtSNombre.Text;
                pApellido = txtPApellido.Text;
                sApellido = txtSApellido.Text;
                documento = cmbTipoDocumento.Text;
                nuDocumento = txtDocumento.Text;
                cargo = cmbCargo.Text;
                depto = Convert.ToInt32(txtId_Departamento.Text);
                direccion = txtDireccion.Text;
                telEmpleado = txtTel.Text;
                correo = txtCorreo.Text;

                if (telEmpleado.Substring(1, 1) == "2" || telEmpleado.Substring(1, 1) == "5" || telEmpleado.Substring(1, 1) == "7" || telEmpleado.Substring(1, 1) == "8")
                {
                    Empleado_Controller.UpdateDataEmpleado(id, pNombre, sNombre, pApellido, sApellido, documento, nuDocumento, cargo, depto, direccion, telEmpleado, correo);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id;

            if (txtId.Text == " " || txtId.Text == null)
            {
                MessageBox.Show("Debe seleccionar un id para dar de baja");
                return;
            }
            else
            {
                id = Convert.ToInt32(txtId.Text);

                Empleado_Controller.UnsubScribeDataEmpleado(id);

                VerTabla();
                Clear();
            }
            
        }

        private void txtPNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        
        private void txtFinder_TextChanged(object sender, EventArgs e)
        {
            dgvEmpleado.DataSource = null;
            dgvEmpleado.DataSource = Empleado_Controller.SearchDataEmpleado(txtFinder.Text);
        }
    }
}
