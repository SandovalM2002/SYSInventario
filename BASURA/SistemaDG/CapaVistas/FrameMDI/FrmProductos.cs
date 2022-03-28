using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using CapaVistas.Dialogos;
using System.Windows.Forms;

namespace CapaVistas.FrameMDI
{
    public partial class FrmProductos : Form
    {
        private DlgTProducto dlgTP;
        int renglon;

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            txtId.Text = " ";
            txtCodigo.Text = " ";
            txtNombreProducto.Text = " ";
            txtMarca.Text = " ";
            txtDescripcion.Text = " ";
            txtId_TipoProducto.Text = " ";
        }
        
        private void VerTabla()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = Producto_Controller.ViewDataProducto();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            VerTabla();
            this.txtId.Enabled = false;
        }

        private void btnAdd_IdTipoProducto_Click(object sender, EventArgs e)
        {
            dlgTP = new DlgTProducto(txtId_TipoProducto);
            dlgTP.ShowDialog();
        }

        //=========================================================================================================//

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, codProd, nombreProd, tipoProd, marcaProd, desProd;

            if (renglon >= 0)
            {
                id = dgvProductos.Rows[renglon].Cells["Id"].Value.ToString();
                txtId.Text = id;

                codProd = dgvProductos.Rows[renglon].Cells["Codigo"].Value.ToString();
                txtCodigo.Text = codProd;

                nombreProd = dgvProductos.Rows[renglon].Cells["Nombre Producto"].Value.ToString();
                txtNombreProducto.Text = nombreProd;

                tipoProd = dgvProductos.Rows[renglon].Cells["Id Tipo Producto"].Value.ToString();
                txtId_TipoProducto.Text = tipoProd;

                marcaProd = dgvProductos.Rows[renglon].Cells["Marca"].Value.ToString();
                txtMarca.Text = marcaProd;

                desProd = dgvProductos.Rows[renglon].Cells["Descripcion"].Value.ToString();
                txtDescripcion.Text = desProd;
            }
            else
            {
                MessageBox.Show("Debe selecccinar una Fila de la Tabla");
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int tipoProd;
            string  codProd, nombreProd, marcaProd, desProd;

            if (txtId_TipoProducto.Text == " " || txtCodigo.Text == " " || txtNombreProducto.Text == " " ||
                txtMarca.Text == " " || txtDescripcion.Text == " "
                )
            {
                MessageBox.Show("Error de Campos");
                return;
            }
            else
            {

                tipoProd = Convert.ToInt32(txtId_TipoProducto.Text);
                codProd = txtCodigo.Text;
                nombreProd = txtNombreProducto.Text;
                marcaProd = txtMarca.Text;
                desProd = txtDescripcion.Text;


                Producto_Controller.InsertDataProducto(codProd, nombreProd, tipoProd, marcaProd, desProd);

                VerTabla();
                Clear();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id, tipoProd;
            string codProd, nombreProd, marcaProd, desProd;

            if (txtId_TipoProducto.Text == " " || txtCodigo.Text == " " || txtNombreProducto.Text == " " ||
                txtMarca.Text == " " || txtDescripcion.Text == " "
                )
            {
                MessageBox.Show("Error de Campos");
                return;
            }

            else
            {
                id = Convert.ToInt32(txtId.Text);
                tipoProd = Convert.ToInt32(txtId_TipoProducto.Text);
                codProd = txtCodigo.Text;
                nombreProd = txtNombreProducto.Text;
                marcaProd = txtMarca.Text;
                desProd = txtDescripcion.Text;

                Producto_Controller.UpdateDataProducto(id, codProd, nombreProd, tipoProd, marcaProd, desProd);

                VerTabla();
                Clear();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(txtId.Text);

            if (txtId.Text == " ")
            {
                MessageBox.Show("Debe seleccionar un Id de Una Tabla");
                return;
            }
            else {

                Producto_Controller.UnsubScribeDataProducto(id);

                VerTabla();
                Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtFinder_TextChanged(object sender, EventArgs e)
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = Producto_Controller.SearchDataProducto(txtFinder.Text);

        }
    }//------------------------------------------------------------
}
