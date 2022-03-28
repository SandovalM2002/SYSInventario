using System;
using CapaNegocio;
using CapaVistas.Dialogos;
using System.Windows.Forms;

namespace CapaVistas.FrameMDI
{
    public partial class FrmInventario : Form
    {
        private DlgProducto dlgPrd;
        private int renglon;

        public FrmInventario()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            txtId.Text = " ";
            txtId_Producto.Text = " ";
            txtCant.Text = " ";
            txtPrecio.Text = " ";
        }

        private void VerTabla() {
            dgvInventario.DataSource = null;
            dgvInventario.DataSource = Iventario_Controller.ViewDataInventario();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            VerTabla();
            this.txtId.Enabled = false;
        }

        private void btnAdd_IdProducto_Click(object sender, EventArgs e)
        {
            dlgPrd = new DlgProducto(txtId_Producto);
            dlgPrd.ShowDialog();
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void dgvInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, idProd, exist, precioP;

            if (renglon >= 0)
            {

                id = dgvInventario.Rows[renglon].Cells["Id"].Value.ToString();
                txtId.Text = id;
                idProd = dgvInventario.Rows[renglon].Cells["Id Producto"].Value.ToString();
                txtId_Producto.Text = idProd;
                exist = dgvInventario.Rows[renglon].Cells["Existencias"].Value.ToString();
                txtCant.Text = exist;
                precioP = dgvInventario.Rows[renglon].Cells["Precio"].Value.ToString();
                txtPrecio.Text = precioP;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Fila de la Tabla");
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idProd, exist;
            float precioP;

            if (txtId_Producto.Text == " " || txtPrecio.Text == "" || txtCant.Text == " ")
            {
                MessageBox.Show("Error de Campos");
                return;
            }
            else
            {

                idProd = Convert.ToInt32(txtId_Producto.Text);
                exist = Convert.ToInt32(txtCant.Text);
                precioP = Convert.ToSingle(txtPrecio.Text);

                if (exist <= 0)
                {
                    MessageBox.Show("Error al Ingresar La Cantidad");
                    return;
                }
                else
                {
                    if (precioP > 0)
                    {
                        Iventario_Controller.InsertDataInventario(idProd, exist, precioP);
                        VerTabla();
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error al Ingresar El Precio del Producto");
                        return;
                    }
                }
            }

        }//---------------------

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id, idProd, exist;
            float precioP;


            if (txtId_Producto.Text == " " || txtPrecio.Text == "" || txtCant.Text == " ")
            {
                MessageBox.Show("Error de Campos");
                return;
            }
            else
            {
                id = Convert.ToInt32(txtId.Text);
                idProd = Convert.ToInt32(txtId_Producto.Text);
                exist = Convert.ToInt32(txtCant.Text);
                precioP = Convert.ToSingle(txtPrecio.Text);

                if (exist <= 0)
                {
                    MessageBox.Show("Error al Ingresar La Cantidad");
                    return;
                }
                else
                {
                    if (precioP > 0)
                    {
                        Iventario_Controller.UpdateDataInventario(id, idProd, exist, precioP);
                        VerTabla();
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error al Ingresar El Precio del Producto");
                        return;
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(txtId.Text);

            if (txtId.Text == " ")
            {
                MessageBox.Show("Debe seleccionar un Id de la Tabla");
                return;
            }
            else
            {
                Iventario_Controller.UnsubScribeDataInventario(id);

                VerTabla();
                Clear();
            }
        }
        
        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
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
            dgvInventario.DataSource = null;
            dgvInventario.DataSource = Iventario_Controller.SearchDataInventario(txtFinder.Text);

        }

    }//Final de la Clase
}
