using System;
using CapaNegocio;
using System.Windows.Forms;

namespace CapaVistas.FrameMDI
{
    public partial class FrmConfiguracion : Form
    {

        public FrmConfiguracion()
        {
            InitializeComponent();
        }
        
        //||==============================================|| METODOS DE PARA VACIAR LOS TEXTOS
        private void ClearGestionCliente()
        {
            txtIdTC.Text = "";
            txtTipoCliente.Text = " ";
            txtDescripcion.Text = " ";
        }
        
        private void ClearGestionUbicacion()
        {
            txtIdD.Text = " ";
            txtIdP.Text = " ";
            txtDepartamento.Text = " ";
            txtpais.Text = " ";
            txtEstado.Text = " ";
        }

        public void ClearGestionProducto()
        {
            txtIdModelo.Text = " ";
            txtTipoProducto.Text = " "; 
            txtNModelo.Text = " ";
            txtIdTProductos.Text = " ";
            txtDescripcion_TP.Text = " ";
            txtNSerie.Text = " ";
        }

        //||==============================================|| METODOS PARA LAS TABLAS
        private void MostrarTablas()
        {
            dgvDepartamento.DataSource = null;
            dgvDepartamento.DataSource = Departamento_Controller.ViewDataDepartamento();

            dgvUbicacion.DataSource = null;
            dgvUbicacion.DataSource = Ubicacion_Controller.ViewDataUbicacion();

            dgvTCliente.DataSource = null;
            dgvTCliente.DataSource =  TipoCliente_Controller.ViewDataTipoCliente();

            dgvTipoProducto.DataSource = null;
            dgvTipoProducto.DataSource = TipoProducto_Controller.ViewDataTProducto();

            dgvModelo.DataSource = null;
            dgvModelo.DataSource = Modelo_Controller.ViewDataModelo();
        }
        
        private void TblProd()
        {
            dgvTipoProducto.DataSource = null;
            dgvTipoProducto.DataSource = TipoProducto_Controller.ViewDataTProducto();
        }

        private void TblDepto()
        {
            dgvDepartamento.DataSource = null;
            dgvDepartamento.DataSource = Departamento_Controller.ViewDataDepartamento();
        }

        public void TblUbicacion()
        {
            dgvUbicacion.DataSource = null;
            dgvUbicacion.DataSource = Ubicacion_Controller.ViewDataUbicacion();
        }

        private void TblModelo()
        {
            dgvModelo.DataSource = null;
            dgvModelo.DataSource = Modelo_Controller.ViewDataModelo();
        }

        private void TblTCliente()
        {
            dgvTCliente.DataSource = null;
            dgvTCliente.DataSource = TipoCliente_Controller.ViewDataTipoCliente();
        }

        //====================================|| LOAD
        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            MostrarTablas();
            
            txtIdD.Enabled = false;
            txtIdTC.Enabled = false;
            txtIdP.Enabled = false;
            txtIdModelo.Enabled = false;
            txtIdTProductos.Enabled = false;
        }

        //||==============================================|| METODOS PARA EL DOBLE CLICK DE LAS TALAS

        private void dgvDepartamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            string ndepto;

            if (e.RowIndex >= 0)
            {
                id = dgvDepartamento.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtIdD.Text = id;

                ndepto = dgvDepartamento.Rows[e.RowIndex].Cells["Departamento"].Value.ToString();
                txtDepartamento.Text = ndepto;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Fila de la Tabla");
                return;
            }
            
        }

        private void dgvUbicacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id,pais,provincia;

            if (e.RowIndex >= 0) {
                id = dgvUbicacion.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtIdP.Text = id;

                pais = dgvUbicacion.Rows[e.RowIndex].Cells["Pais"].Value.ToString();
                txtpais.Text = pais;

                provincia = dgvUbicacion.Rows[e.RowIndex].Cells["Departamento"].Value.ToString();
                txtEstado.Text = provincia;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Fila de la Tabla");
                return;
            }
        }

        private void dgvTCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, tcliente, desc;

            if (e.RowIndex >= 0)
            {
                id = dgvTCliente.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtIdTC.Text = id;

                tcliente = dgvTCliente.Rows[e.RowIndex].Cells["Tipo de Cliente"].Value.ToString();
                txtTipoCliente.Text = tcliente;

                desc = dgvTCliente.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                txtDescripcion.Text = desc;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Fila de la Tabla");
                return;
            }
        }

        private void dgvModelo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, modelo;
            if (e.RowIndex >= 0) {
                id = dgvModelo.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtIdModelo.Text = id;

                modelo = dgvModelo.Rows[e.RowIndex].Cells["Numero del Modelo"].Value.ToString();
                txtNModelo.Text = modelo;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Fila de la Tabla");
                return;
            }

        }

        private void dgvTipoProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, TipoProd, Descrip, idModel, serie;

            if (e.RowIndex >= 0)
            {
                id = dgvTipoProducto.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtIdTProductos.Text = id;

                TipoProd = dgvTipoProducto.Rows[e.RowIndex].Cells["Tipo de Producto"].Value.ToString();
                txtTipoProducto.Text = TipoProd;

                Descrip = dgvTipoProducto.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                txtDescripcion_TP.Text = Descrip;

                idModel = dgvTipoProducto.Rows[e.RowIndex].Cells["Id Modelo"].Value.ToString();
                txtModeloTP.Text = idModel;

                serie = dgvTipoProducto.Rows[e.RowIndex].Cells["Serie"].Value.ToString();
                txtNSerie.Text = serie;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una Fila de la Tabla");
                return;
            }
        }

        //================================================|| METODOS DE GUADAR, EDITAR, Y DAR DE BAJA ======================||

            //TIPO DE CLIENTE
        private void btnGuardar_TipoCliente_Click(object sender, EventArgs e)
        {
            string tCliente; 
            string Desc;

            if (txtTipoCliente.Text == " " || txtTipoCliente.Text == null)
            {
                MessageBox.Show("Error de Campo");
                return;
            }
            else
            {
                tCliente = txtTipoCliente.Text;
                Desc = txtDescripcion.Text;

                TipoCliente_Controller.InsertDataTipoCliente(tCliente, Desc);

                TblTCliente();
                ClearGestionCliente();
            }
        }

        private void btnEditar_TipoCliente_Click(object sender, EventArgs e)
        {
            int id;
            string tCliente;
            string Desc;

            if (txtTipoCliente.Text == " " || txtTipoCliente.Text == null)
            {
                MessageBox.Show("Error de Campo");
                return;
            }
            else
            {
                id = Convert.ToInt32(txtIdTC.Text);
                tCliente = txtTipoCliente.Text;
                Desc = txtDescripcion.Text;

                TipoCliente_Controller.UpdateDataTipoCliente(id, tCliente, Desc);

                TblTCliente();
                ClearGestionCliente();
            }
        }

        private void btnEliminar_TipoCliente_Click(object sender, EventArgs e)
        {
            int id;

            if (txtIdTC.Text == " ")
            {
                MessageBox.Show("Debe seleccionar un Id de la tabla");
                return;
            }
            else
            {
                id = Convert.ToInt32(txtIdTC.Text);
                TipoCliente_Controller.UnsubScribeTipoCliente(id);

                TblTCliente();
                ClearGestionCliente();
            }
        }

        //DEPARTAMENTO
        private void btnGuardar_Deptos_Click(object sender, EventArgs e)
        {
            string depto;
            if (txtDepartamento.Text == " " || txtDepartamento.Text == null)
            {
                MessageBox.Show("Error de Campo");
                return;
            }
            else
            {
                depto = txtDepartamento.Text;

                Departamento_Controller.InsertDataDepartamento(depto);

                TblDepto();
                ClearGestionUbicacion();
            }
        }

        private void btnEditar_Deptos_Click(object sender, EventArgs e)
        {
            int id;
            string depto;

            if (txtDepartamento.Text == " " || txtDepartamento.Text == null)
            {
                MessageBox.Show("Error de Campo");
                return;
            }
            else
            {
                id = Convert.ToInt32(txtIdD.Text);
                depto = txtDepartamento.Text;

                Departamento_Controller.UpdateDataDepartamento(id, depto);

                TblDepto();
                ClearGestionUbicacion();
            }
        }

        private void btnDelete_Deptos_Click(object sender, EventArgs e)
        {
            int id;

            if (txtIdD.Text == " ")
            {
                MessageBox.Show("Debe seleccionar un Id de la tabla");
                return;
            }
            else
            {
                id = Convert.ToInt32(txtIdD.Text);
                Departamento_Controller.UnsubScribeDataDepartamento(id);

                TblDepto();
                ClearGestionUbicacion();
            }
        }

        // UBICACIONES
        private void btnGuardar_Ubicacion_Click(object sender, EventArgs e)
        {
            string pais, estado;

            if (txtpais.Text == " " || txtpais.Text == " " || txtEstado.Text == " " || txtEstado.Text == null)
            {
                MessageBox.Show("Error de Campo");
                return;
            }
            else
            {
                pais = txtpais.Text;
                estado = txtEstado.Text;

                Ubicacion_Controller.InsertDataUbicacion(pais, estado);

                TblUbicacion();
                ClearGestionUbicacion();
            }
        }

        private void btnEditar_Ubicacion_Click(object sender, EventArgs e)
        {
            int id;
            string pais, estado;

            if (txtpais.Text == " " || txtpais.Text == " " || txtEstado.Text == " " || txtEstado.Text == null)
            {
                MessageBox.Show("Error de Campo");
                return;
            }
            else
            {
                id = Convert.ToInt32(txtIdP.Text);
                pais = txtpais.Text;
                estado = txtEstado.Text;

                Ubicacion_Controller.UpdateDataUbicacion(id, pais, estado);

                TblUbicacion();
                ClearGestionUbicacion();
            }
        }

        private void btnEliminar_Ubicacion_Click(object sender, EventArgs e)
        {
            int id;
            

            if (txtIdP.Text == " ")
            {
                MessageBox.Show("Debe seleccionar un Id de la tabla");
                return;
            }
            else
            {
                id = Convert.ToInt32(txtIdP.Text);

                Ubicacion_Controller.UnsubScribeDataUbicacion(id);

                TblUbicacion();
                ClearGestionUbicacion();
            }
        }

        //MODELO
        private void btnGuardar_Modelo_Click(object sender, EventArgs e)
        {
            string NModelo;
            if (txtNModelo.Text == " " || txtNModelo.Text == null)
            {
                MessageBox.Show("Error de Campos");
                return;
            }
            else
            {
                NModelo = txtNModelo.Text;

                Modelo_Controller.InsertDataModelo(NModelo);
                TblModelo();
                ClearGestionProducto();
            }
        }

        private void btnEditar_Modelo_Click(object sender, EventArgs e)
        {
            int id;
            string NModelo;

            if (txtNModelo.Text == " " || txtNModelo.Text == null)
            {
                MessageBox.Show("Error de Campos");
                return;
            }
            else
            {
                id = Convert.ToInt32(txtIdModelo.Text);
                NModelo = txtNModelo.Text;

                Modelo_Controller.UpdateDataModelo(id, NModelo);
                TblModelo();
                ClearGestionProducto();
            }
        }

        private void btnEliminar_Modelo_Click(object sender, EventArgs e)
        {
            int id;

            if (txtIdModelo.Text == " ")
            {
                MessageBox.Show("Debe seleccionar un Id de la tabla");
                return;
            }
            else
            {
                id = Convert.ToInt32(txtIdModelo.Text);
                Modelo_Controller.UnsubScribeDataModelo(id);

                TblModelo();
                ClearGestionProducto();
            }
        }

        //TIPO DE PRODUCTO
        private void btnGuardar_TipoProducto_Click(object sender, EventArgs e)
        {
            string Tprod, desc, serie;
            int id_Model;

            if (txtTipoProducto.Text == " " || txtTipoProducto.Text == null || txtNSerie.Text == " " || txtNSerie.Text == null || txtModeloTP.Text == " " || txtModeloTP.Text == null)
            {
                MessageBox.Show("Error de Campos");
                return;
            }
            else
            {
                Tprod = txtTipoProducto.Text;
                desc = txtDescripcion_TP.Text;
                serie = txtNSerie.Text;
                id_Model = Convert.ToInt32(txtModeloTP.Text);

                TipoProducto_Controller.InsertDataTProducto(Tprod, desc, id_Model, serie);

                TblProd();
                ClearGestionProducto();
            }
        }

        private void btnEditar_TipoProducto_Click(object sender, EventArgs e)
        {
            string Tprod, desc, serie;
            int id_Model,id;

            if (txtTipoProducto.Text == " " || txtTipoProducto.Text == null || txtNSerie.Text == " " || txtNSerie.Text == null || txtModeloTP.Text == " " || txtModeloTP.Text == null)
            {
                MessageBox.Show("Error de Campos");
                return;
            }
            else
            {
                id = Convert.ToInt32(txtIdTProductos.Text);
                Tprod = txtTipoProducto.Text;
                desc = txtDescripcion_TP.Text;
                serie = txtNSerie.Text;
                id_Model = Convert.ToInt32(txtModeloTP.Text);

                TipoProducto_Controller.UpdateDataTProducto(id, Tprod, desc, id_Model, serie);

                TblProd();
                ClearGestionProducto();
            }
        }

        private void btnEliminar_TipoProducto_Click(object sender, EventArgs e)
        {
            int id;

            if (txtIdTProductos.Text == " ")
            {
                MessageBox.Show("Debe seleccionar un Id de la tabla");
                return;
            }
            else
            {
                id = Convert.ToInt32(txtIdTProductos.Text);
                TipoProducto_Controller.UnsubScribeDataTProducto(id);

                ClearGestionProducto();
                TblProd();
            }
        }

        private void txtTipoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtpais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtTipoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtDescripcion_TP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtModeloTP_KeyPress(object sender, KeyPressEventArgs e)
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
    }//----------------------------------
}//----------------------------------
