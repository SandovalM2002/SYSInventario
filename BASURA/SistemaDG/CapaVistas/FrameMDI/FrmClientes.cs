using CapaNegocio;
using System.Windows.Forms;
using CapaVistas.Dialogos;
using System.Text.RegularExpressions;
using System;

namespace CapaVistas.FrameMDI
{
    public partial class FrmClientes : Form
    {
        private DlgTCliente dlgcliente;
        private DlgDepartamento dlgdepto;
        private int renglon;
        
        public FrmClientes()
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
            txtDoc.Text = " ";
            txtNEmpresa.Text = " ";
            txtDireccion.Text = " ";
            txtTel.Text = " ";
            txtCorreo.Text = " ";
            txtId_Departamento.Text = " ";
            txtId_TipoCliente.Text = " ";
        }

        private void VerTabla()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = Cliente_Controller.ViewDataCliente();
            
        }
        
        //Tabla
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        
        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, PNombre, SNombre, PApellido, SApellido, Doc, NEmpresa, Direccion, Tel, Correo, Depto, TipoCliente;

            if (renglon >= 0 )
            {
                id = dgvClientes.Rows[renglon].Cells["Id"].Value.ToString();
                txtId.Text = id;

                PNombre = dgvClientes.Rows[renglon].Cells["Primer Nombre"].Value.ToString();
                txtPNombre.Text = PNombre;

                SNombre = dgvClientes.Rows[renglon].Cells["Segundo Nombre"].Value.ToString();
                txtSNombre.Text = SNombre;

                PApellido = dgvClientes.Rows[renglon].Cells["Primer Apellido"].Value.ToString();
                txtPApellido.Text = PApellido;

                SApellido = dgvClientes.Rows[renglon].Cells["Segundo Apellido"].Value.ToString();
                txtSApellido.Text = SApellido;

                Doc = dgvClientes.Rows[renglon].Cells["Documento"].Value.ToString();
                txtDoc.Text = Doc;

                NEmpresa = dgvClientes.Rows[renglon].Cells["Empresa del Cliente"].Value.ToString();
                txtNEmpresa.Text = NEmpresa;

                Direccion = dgvClientes.Rows[renglon].Cells["Direccion"].Value.ToString();
                txtDireccion.Text = Direccion;

                Tel = dgvClientes.Rows[renglon].Cells["Telefono"].Value.ToString();
                txtTel.Text = Tel;

                Correo = dgvClientes.Rows[renglon].Cells["Correo"].Value.ToString();
                txtCorreo.Text = Correo;

                Depto = dgvClientes.Rows[renglon].Cells["Id Departamento"].Value.ToString();
                txtId_Departamento.Text = Depto;

                TipoCliente = dgvClientes.Rows[renglon].Cells["Id Tipo de Cliente"].Value.ToString();
                txtId_TipoCliente.Text = TipoCliente;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Fila de la Tabla");
                return;
            }
        }
        
        //EVENTOS DEL FRAME
        private void FrmClientes_Load(object sender, System.EventArgs e)
        {
            VerTabla();
            //OrdenColumnas();
            this.txtId.Enabled = false;
            //Clear();
        }

        //BOTONES ADD ID
        private void btnAdd_IdDepartamento_Click(object sender, System.EventArgs e)
        {
            dlgdepto = new DlgDepartamento(txtId_Departamento);
            dlgdepto.ShowDialog();
        }

        private void btnAdd_IdTipoCliente_Click(object sender, System.EventArgs e)
        {
            dlgcliente = new DlgTCliente(txtId_TipoCliente);
            dlgcliente.ShowDialog();
        }

        //====================================================================|| METODOS DE GUARDAR ACTUALIZAR Y ELIMINAR

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            int tClient,depto;
            string documento, pNombre, SNombre,PApellido,sApellido, nEmpresa, direccion, correo, telCliente;

            //Nulos solo el correo y Snombre y sapellido

            if (txtId_TipoCliente.Text == " " || txtDoc.Text == " " || txtId_Departamento.Text == " " || txtPNombre.Text == "" || txtPApellido.Text == " " || txtNEmpresa.Text == " " || txtDireccion.Text == " " || txtTel.Text == " ")
            {
                MessageBox.Show("Error de Campo");
                return;
            }
            else
            {

                tClient = Convert.ToInt32(txtId_TipoCliente.Text);
                documento = txtDoc.Text;
                depto = Convert.ToInt32(txtId_Departamento.Text);
                pNombre = txtPNombre.Text;
                SNombre = txtSNombre.Text;
                PApellido = txtPApellido.Text;
                sApellido = txtSApellido.Text;
                nEmpresa = txtNEmpresa.Text;
                direccion = txtDireccion.Text;
                correo = txtCorreo.Text;
                telCliente = txtTel.Text;


                if (telCliente.Substring(1,1) == "2" || telCliente.Substring(1, 1) == "5" || telCliente.Substring(1, 1) == "7" || telCliente.Substring(1, 1) == "8")
                {
                    Cliente_Controller.InsertDataCliente(tClient, documento, pNombre, SNombre, PApellido, sApellido, nEmpresa, depto, direccion, correo, telCliente);
                    VerTabla();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Error con el Telefono \n Los numeros telefonicos deben comenzar con '2','5','7', o '8'");
                    return;
                }
            }
        }//----------------------

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            int id, tClient, depto;
            string documento, pNombre, SNombre, PApellido, sApellido, nEmpresa, direccion, correo, telCliente;

            //Nulos solo el correo y Snombre y sapellido

            if (txtId_TipoCliente.Text == " " || txtDoc.Text == " " || txtId_Departamento.Text == " " || txtPNombre.Text == "" || txtPApellido.Text == " " || txtNEmpresa.Text == " " || txtDireccion.Text == " " || txtTel.Text == " ")
            {
                MessageBox.Show("Error de Campo");
                return;
            }
            else
            {

                id = Convert.ToInt32(txtId.Text);
                tClient = Convert.ToInt32(txtId_TipoCliente.Text);
                documento = txtDoc.Text;
                depto = Convert.ToInt32(txtId_Departamento.Text);
                pNombre = txtPNombre.Text;
                SNombre = txtSNombre.Text;
                PApellido = txtPApellido.Text;
                sApellido = txtSApellido.Text;
                nEmpresa = txtNEmpresa.Text;
                direccion = txtDireccion.Text;
                correo = txtCorreo.Text;
                telCliente = txtTel.Text;


                if (telCliente.Substring(1, 1) == "2" || telCliente.Substring(1, 1) == "5" || telCliente.Substring(1, 1) == "7" || telCliente.Substring(1, 1) == "8")
                {
                    Cliente_Controller.UpdateDataCliente(id, tClient, documento, pNombre, SNombre, PApellido, sApellido, nEmpresa, depto, direccion, correo, telCliente);
                    VerTabla();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Error con el Telefono \n Los numeros telefonicos deben comenzar con '2','5','7', o '8'");
                    return;
                }
            }
        }//---------

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            int id;

            if (txtId.Text == " ")
            {
                MessageBox.Show("Debe seleccionar un id para dar de baja");
                return;
            }
            else
            {
                id = Convert.ToInt32(txtId.Text);

                Cliente_Controller.UnsubScribeDataCliente(id);
                VerTabla();
            }
        }
        
        //=======================================================================|| VALIDACION DE LETRAS
        private void txtPNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtSNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtPApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtSApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtNEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        
        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            //int id;

            //id = Convert.ToInt32(txtBusqueda.Text);

            //Cliente_Controller.SearchDataCliente(id);
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

        private void txtFinder_TextChanged(object sender, EventArgs e)
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource =  Cliente_Controller.SearchDataCliente(txtFinder.Text);
            
        }
    }//Final de la clase
}//Final 
