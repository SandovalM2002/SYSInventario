using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistas.Dialogos;
using CapaNegocio;

namespace CapaVistas.FrameMDI
{
    public partial class FrmCompra : Form
    {
        private DlgProducto dlgprod;
        private DlgEmpleado dlgEmpl;
        private int renglon;

        public FrmCompra()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            txtId.Text = " ";
            txtId_Empleado.Text = " ";
            txtId_Producto.Text = " ";
            txtCantidadComprada.Text = " ";
            txtMonto.Text = " ";
        }

        private void VerTabla()
        {
            dgvCompra.DataSource = null;
            dgvCompra.DataSource = Compra_Controller.ViewDataCompra();
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            this.txtId.Enabled = false;
            VerTabla();
        }
        
        //BOTONES PARA AGREGAR UN ID
        private void btnAdd_IdProducto_Click(object sender, EventArgs e)
        {
            dlgprod = new DlgProducto(txtId_Producto);
            dlgprod.ShowDialog();
        }

        private void btnAdd_IdEmpleado_Click(object sender, EventArgs e)
        {
            dlgEmpl = new DlgEmpleado(txtId_Empleado);
            dlgEmpl.ShowDialog();
        }

        private void dgvCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, idProd,cantComprada, precioCompra, idEmpleado, fechaCompra;

            if (renglon >= 0) {
                id = dgvCompra.Rows[renglon].Cells["Id"].Value.ToString();
                txtId.Text = id;

                cantComprada = dgvCompra.Rows[renglon].Cells["Cantidad Comprada"].Value.ToString();
                txtCantidadComprada.Text = cantComprada;

                precioCompra = dgvCompra.Rows[renglon].Cells["Monto Compra"].Value.ToString();
                txtMonto.Text = precioCompra;

                idEmpleado = dgvCompra.Rows[renglon].Cells["Id Empleado"].Value.ToString();
                txtId_Empleado.Text = idEmpleado;

                idProd = dgvCompra.Rows[renglon].Cells["Id Producto"].Value.ToString();
                txtId_Producto.Text = idProd;

                fechaCompra = dgvCompra.Rows[renglon].Cells["Fecha de Compra"].Value.ToString();
                cmbFechaCompra.Text = fechaCompra;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Fila de la Tabla");
                return;
            }
        }

        private void dgvCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idProd, idEmpleado, cantComprada;
            float precioCompra;
            DateTime fechaCompra;

            if (txtId_Producto.Text == " " || txtId_Empleado.Text == " " || txtCantidadComprada.Text == " " || txtMonto.Text == " " || cmbFechaCompra.Text == " ")
            {
                MessageBox.Show("Error de Campos");
                return;
            }
            else
            {
                idProd = Convert.ToInt32(txtId_Producto.Text);
                idEmpleado = Convert.ToInt32(txtId_Empleado.Text);
                cantComprada = Convert.ToInt32(txtCantidadComprada.Text);
                precioCompra = Convert.ToSingle(txtMonto.Text);
                fechaCompra = cmbFechaCompra.Value;

                if (cantComprada <= 0)
                {
                    MessageBox.Show("Error al ingresar la Cantidad de Productos");
                    return;
                }

                if (precioCompra <= 0)
                {
                    MessageBox.Show("Error al ingresar  el Precio de Compra");
                    return;
                }

                Compra_Controller.InsertDataCompra(idProd, cantComprada, precioCompra, idEmpleado, fechaCompra);
                VerTabla();
                Clear();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id, idProd, idEmpleado, cantComprada;
            float precioCompra;
            DateTime fechaCompra;

            if (txtId_Producto.Text == " " || txtId_Empleado.Text == " " || txtCantidadComprada.Text == "" ||
              txtMonto.Text == " " || cmbFechaCompra.Text == ""
              )
            {
                MessageBox.Show("Error de Campos");
                return;
            }
            else
            {

                id = Convert.ToInt32(txtId.Text);
                idProd = Convert.ToInt32(txtId_Producto.Text);
                idEmpleado = Convert.ToInt32(txtId_Empleado.Text);
                cantComprada = Convert.ToInt32(txtCantidadComprada.Text);
                precioCompra = Convert.ToSingle(txtMonto.Text);
                fechaCompra = cmbFechaCompra.Value;

                if (cantComprada <= 0)
                {
                    MessageBox.Show("Error al ingresar la Cantidad de Productos");
                    return;
                }

                if (precioCompra <= 0)
                {
                    MessageBox.Show("Error al ingresar  el Precio de Compra");
                    return;
                }

                Compra_Controller.UpdateDataCompra(id, idProd, cantComprada, precioCompra, idEmpleado, fechaCompra);
                VerTabla();
                Clear();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id;
            if (txtId.Text == " ")
            {
                MessageBox.Show("Debe Seleccionar un Id de la Tabla");
                return;
            }
            else
            {
                id = Convert.ToInt32(txtId.Text);
                Compra_Controller.UnsubScribeDataCompra(id);

                VerTabla();
                Clear();
            }
        }

        //Validar Los Campos
        private void txtCantidadComprada_KeyPress(object sender, KeyPressEventArgs e)
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
            dgvCompra.DataSource = null;
            dgvCompra.DataSource = Compra_Controller.SearchDataCompra(txtFinder.Text);
        }
    }
}
