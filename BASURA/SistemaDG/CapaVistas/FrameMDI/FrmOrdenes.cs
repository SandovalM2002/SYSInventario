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
    public partial class FrmOrdenes : Form
    {
        DlgTCliente dlgCliente;
        DlgEmpleado dlgEmpl;
        DlgProveedor dlgProv;

        public FrmOrdenes()
        {
            InitializeComponent();
        }
        //=========================================================================================================================================//

        //MEOTODOS CLEAR
        private void ClearOrdenCompra()
        {
            txtId_OC.Text = " ";
            txtNumeroOrden_OC.Text = " ";
            txtDescripcion_OC.Text = " ";
            txtCant_OC.Text = "";
            txtMonto_OC.Text = " ";
            txtTerminosEntrega_OC.Text = " ";
            txtId_Empleado_OC.Text = " ";
            txtId_Proveedor_OC.Text = " ";
        }

        private void ClearDevOrdenCompra()
        {
            txtId_Dev.Text = " ";
            txtId_OrdenCompra_Dev.Text = " ";
            txtCanDev_Dev.Text = " ";
            txtObservacion_Dev.Text = " ";
        }

        private void ClearOrdenTrabajo()
        {
            txtId_OT.Text = " ";
            txtId_Cliente_OT.Text = " ";
            txtProducto_OT.Text = " ";
            txtSerie_OT.Text = " ";
            txtMarca_OT.Text = " ";
            txtModelo_OT.Text = " ";
            txtObservaciones_OT.Text = " ";
            txtTrabajoRealizado_OT.Text = " ";
        }
        
        //METODOS DE VER TABLAS
        private void VerTablas()
        {
            dgvDevOrdenCompra.DataSource = null;
            dgvDevOrdenCompra.DataSource = DevOrdenCompra_Controller.ViewDataDevOrdenCompra();
            
            dgvOrdenCompra.DataSource = null;
            dgvOrdenCompra.DataSource = OrdenCompra_Controller.ViewDataOrdenCompra();

            dgvOrdenTrabajo.DataSource = null;
            dgvOrdenTrabajo.DataSource = OrdenTrabajo_Controller.ViewDataOrdenTrabajo();
        }

        private void VerOrdenTrabajo()
        {
            dgvOrdenTrabajo.DataSource = null;
            dgvOrdenTrabajo.DataSource = OrdenTrabajo_Controller.ViewDataOrdenTrabajo();
        }

        private void VerOrdenCompra()
        {
            dgvOrdenCompra.DataSource = null;
            dgvOrdenCompra.DataSource = OrdenCompra_Controller.ViewDataOrdenCompra();
            
        }
        

        private void VerDevOrdeneCompra()
        {
            dgvDevOrdenCompra.DataSource = null;
            dgvDevOrdenCompra.DataSource = DevOrdenCompra_Controller.ViewDataDevOrdenCompra();

        }

        //=========================================================================================================================================//
        //LOAD
        private void FrmOrdenes_Load(object sender, EventArgs e)
        {
            VerTablas();
            this.txtId_OC.Enabled = false;
            this.txtId_Dev.Enabled = false;
            this.txtId_OT.Enabled = false;
        }
        
        //BOTONES PARA AGREGAR ID
        private void btnAdd_IdCliente_OT_Click(object sender, EventArgs e)
        {
            dlgCliente = new DlgTCliente(txtId_Cliente_OT);
            dlgCliente.ShowDialog();
        }

        private void btnAdd_Empleado_OC_Click(object sender, EventArgs e)
        {
            dlgEmpl = new DlgEmpleado(txtId_Empleado_OC);
            dlgEmpl.ShowDialog();
        }

        private void btnAdd_Proveedor_OC_Click(object sender, EventArgs e)
        {
            dlgProv = new DlgProveedor(txtId_Proveedor_OC);
            dlgProv.ShowDialog();
        }
        //=========================================================================================================================================//
        
        private void dgvOrdenCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, numeroOrden, idProv, producto, cantidadComprada, precioUnitario, fechaPedido, fechaPago, terminosEntrega, idEmpleado;

            if (e.RowIndex >= 0)
            {
                id = dgvOrdenCompra.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtId_OC.Text = id;

                numeroOrden = dgvOrdenCompra.Rows[e.RowIndex].Cells["Numero de Orden"].Value.ToString();
                txtNumeroOrden_OC.Text = numeroOrden;

                idProv = dgvOrdenCompra.Rows[e.RowIndex].Cells["Id Proveedor"].Value.ToString();
                txtId_Proveedor_OC.Text = idProv;

                producto = dgvOrdenCompra.Rows[e.RowIndex].Cells["Producto"].Value.ToString();
                txtDescripcion_OC.Text = producto;

                cantidadComprada = dgvOrdenCompra.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString();
                txtCant_OC.Text = cantidadComprada;

                precioUnitario = dgvOrdenCompra.Rows[e.RowIndex].Cells["Monto"].Value.ToString();
                txtMonto_OC.Text = precioUnitario;

                fechaPedido = dgvOrdenCompra.Rows[e.RowIndex].Cells["Fecha del Pedido"].Value.ToString();
                cmbFechaPeido_OC.Text = fechaPedido;

                fechaPago = dgvOrdenCompra.Rows[e.RowIndex].Cells["Fecha de Entrega"].Value.ToString();
                cmbFechaEntrega_OC.Text = fechaPago;

                terminosEntrega = dgvOrdenCompra.Rows[e.RowIndex].Cells["Terminos de Entrega"].Value.ToString();
                txtTerminosEntrega_OC.Text = terminosEntrega;

                idEmpleado = dgvOrdenCompra.Rows[e.RowIndex].Cells["Id Empleado"].Value.ToString();
                txtId_Empleado_OC.Text = idEmpleado;
            }
            else
            {
                MessageBox.Show("Debe selccionar una Fila de la Tabla");
                return;
            }
        }

        private void dgvDevOrdenCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, idOrden, cantidadDev, observacion, fechaDev;

            if (e.RowIndex >= 0) {
                id = dgvDevOrdenCompra.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtId_Dev.Text = id;

                idOrden = dgvDevOrdenCompra.Rows[e.RowIndex].Cells["Id Orden de Compra"].Value.ToString();
                txtId_OrdenCompra_Dev.Text = idOrden;

                cantidadDev = dgvDevOrdenCompra.Rows[e.RowIndex].Cells["Cantidad Devuelta"].Value.ToString();
                txtCanDev_Dev.Text = cantidadDev;

                observacion = dgvDevOrdenCompra.Rows[e.RowIndex].Cells["Observaciones"].Value.ToString();
                txtObservacion_Dev.Text = observacion;

                fechaDev = dgvDevOrdenCompra.Rows[e.RowIndex].Cells["Fecha Devolucion"].Value.ToString();
                cmbFechaDev_Dev.Text = fechaDev;
            }
            else
            {
                MessageBox.Show("Debe selccionar una Fila de la Tabla");
                return;
            }
        }

        private void dgvOrdenTrabajo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, idCliente, producto, marcaProd, serieProd, modeloProd, fechaOrden, trabajoRealizado, observaciones;
            string num;

            if (e.RowIndex >= 0)
            {
                id = dgvOrdenTrabajo.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtId_OT.Text = id;

                idCliente = dgvOrdenTrabajo.Rows[e.RowIndex].Cells["Id Cliente"].Value.ToString();
                txtId_Cliente_OT.Text = idCliente;

                producto = dgvOrdenTrabajo.Rows[e.RowIndex].Cells["Producto"].Value.ToString();
                txtProducto_OT.Text = producto;

                marcaProd = dgvOrdenTrabajo.Rows[e.RowIndex].Cells["Marca"].Value.ToString();
                txtMarca_OT.Text = marcaProd;

                serieProd = dgvOrdenTrabajo.Rows[e.RowIndex].Cells["Serie"].Value.ToString();
                txtSerie_OT.Text = serieProd;

                modeloProd = dgvOrdenTrabajo.Rows[e.RowIndex].Cells["Modelo"].Value.ToString();
                txtModelo_OT.Text = modeloProd;

                fechaOrden = dgvOrdenTrabajo.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
                cmbFechaOrden_OT.Text = fechaOrden;

                trabajoRealizado = dgvOrdenTrabajo.Rows[e.RowIndex].Cells["Trabajo Realizado"].Value.ToString();
                txtTrabajoRealizado_OT.Text = trabajoRealizado;

                observaciones = dgvOrdenTrabajo.Rows[e.RowIndex].Cells["Observaciones"].Value.ToString();
                txtObservaciones_OT.Text = observaciones;

                num = dgvOrdenTrabajo.Rows[e.RowIndex].Cells["Numero de Orden"].Value.ToString();
                txtNumOrden.Text = num;
            }
            else
            {
                MessageBox.Show("Debe selccionar una Fila de la Tabla");
                return;
            }
        }

        //=====================================================================================================================================================//
        private void btnGuardar_OC_Click(object sender, EventArgs e)
        {
            int idProv, cantidadComprada, idEmpleado;
            float precioUnitario;
            string numeroOrden, producto, terminosEntrega;
            DateTime fechaPedido, fechaPago;

            //solo los terminos de entrega puede ser nulos
            if (txtId_Proveedor_OC.Text == " " || txtNumeroOrden_OC.Text == " " || txtCant_OC.Text == " " ||
                txtMonto_OC.Text == " " || cmbFechaPeido_OC.Text == " " || cmbFechaEntrega_OC.Text == " " ||
                txtId_Empleado_OC.Text == " " || txtDescripcion_OC.Text == ""
                )
            {
                MessageBox.Show("Error en los Campos");
                return;
            }
            else
            {
                idProv = Convert.ToInt32(txtId_Proveedor_OC.Text);
                numeroOrden = txtNumeroOrden_OC.Text;
                producto = txtDescripcion_OC.Text;
                cantidadComprada = Convert.ToInt32(txtCant_OC.Text);
                idEmpleado = Convert.ToInt32(txtId_Empleado_OC.Text);
                precioUnitario = Convert.ToSingle(txtMonto_OC.Text);
                fechaPedido = cmbFechaPeido_OC.Value;
                fechaPago = cmbFechaEntrega_OC.Value;
                terminosEntrega = txtTerminosEntrega_OC.Text;

                if (cantidadComprada <= 0)
                {
                    MessageBox.Show("Error al Ingresar la Cantidad");
                    return;
                }

                if (precioUnitario <= 0)
                {
                    MessageBox.Show("Error al Ingresar el Precio");
                    return;
                }

                OrdenCompra_Controller.InsertDataOrdenCompra(numeroOrden, idProv, producto, cantidadComprada, precioUnitario, fechaPedido, fechaPago, terminosEntrega, idEmpleado);

                VerOrdenCompra();
                ClearOrdenCompra();
            }
        }


        private void btnEliminar_OC_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(txtId_OC.Text);

            if (txtId_OC.Text == " ")
            {
                MessageBox.Show("Debe selccionar un Id de la Tabla");
                return;
            }
            else
            {
                OrdenCompra_Controller.UnsubScribeDataOrdenCompra(id);

                VerOrdenCompra();
                ClearOrdenCompra();

            }
        }
        private void btnEditar_OC_Click(object sender, EventArgs e)
        {
            int id;
            int idProv, cantidadComprada, idEmpleado;
            float precioUnitario;
            string numeroOrden, producto,  terminosEntrega;
            DateTime fechaPedido, fechaPago;

            //solo los terminos de entrega puede ser nulos
            if (txtId_Proveedor_OC.Text == " " || txtNumeroOrden_OC.Text == " " || txtCant_OC.Text == " " ||
                txtMonto_OC.Text == " " || cmbFechaPeido_OC.Text == " " || cmbFechaEntrega_OC.Text == " " ||
                txtId_Empleado_OC.Text == " " || txtDescripcion_OC.Text == ""
                )
            {
                MessageBox.Show("Error en los Campos");
                return;
            }
            else
            {

                id = Convert.ToInt32(txtId_OC.Text);
                idProv = Convert.ToInt32(txtId_Proveedor_OC.Text);
                numeroOrden = txtNumeroOrden_OC.Text;
                producto = txtDescripcion_OC.Text;
                cantidadComprada = Convert.ToInt32(txtCant_OC.Text);
                idEmpleado = Convert.ToInt32(txtId_Empleado_OC.Text);
                precioUnitario = Convert.ToSingle(txtMonto_OC.Text);
                fechaPedido = cmbFechaPeido_OC.Value;
                fechaPago = cmbFechaEntrega_OC.Value;
                terminosEntrega = txtTerminosEntrega_OC.Text;

                if (cantidadComprada <= 0)
                {
                    MessageBox.Show("Error al Ingresar la Cantidad");
                    return;
                }

                if (precioUnitario <= 0)
                {
                    MessageBox.Show("Error al Ingresar el Precio");
                    return;
                }

                OrdenCompra_Controller.UpdateDataOrdenCompra(id, numeroOrden, idProv, producto, cantidadComprada, precioUnitario, fechaPedido, fechaPago, terminosEntrega, idEmpleado);
                VerOrdenCompra();
                ClearOrdenCompra();
            }
        }

        //=====================================================================================================================================================//
        private void btnGuardar_Dev_Click(object sender, EventArgs e)
        {
            int idOrden, cantidadDev;
            string observacion;
            DateTime fechaDev;

            if (txtId_OrdenCompra_Dev.Text == " " || txtCanDev_Dev.Text == " " || txtObservacion_Dev.Text == " " || cmbFechaDev_Dev.Text == " ")
            {
                MessageBox.Show("Error de Campos");
                return;
            }
            else
            {
                idOrden = Convert.ToInt32(txtId_OrdenCompra_Dev.Text);
                cantidadDev = Convert.ToInt32(txtCanDev_Dev.Text);
                observacion = txtObservacion_Dev.Text;
                fechaDev = cmbFechaDev_Dev.Value;

                if (cantidadDev <= 0)
                {
                    MessageBox.Show("Error al Ingresar la Cantidad Devuelta");
                    return;
                }
                else
                {
                    DevOrdenCompra_Controller.InsertDataDevOrdenCompra(idOrden, cantidadDev, observacion, fechaDev);

                    VerDevOrdeneCompra();
                    ClearDevOrdenCompra();
                }
            }
        }

        private void btnEditar_Dev_Click(object sender, EventArgs e)
        {
            int id;
            int idOrden, cantidadDev;
            string observacion;
            DateTime fechaDev;

            if (txtId_OrdenCompra_Dev.Text == " " || txtCanDev_Dev.Text == " " || txtObservacion_Dev.Text == " " || cmbFechaDev_Dev.Text == " ")
            {
                MessageBox.Show("Error de Campos");
                return;
            }
            else
            {

                id = Convert.ToInt32(txtId_Dev.Text);
                idOrden = Convert.ToInt32(txtId_OrdenCompra_Dev.Text);
                cantidadDev = Convert.ToInt32(txtCanDev_Dev.Text);
                observacion = txtObservacion_Dev.Text;
                fechaDev = cmbFechaDev_Dev.Value;

                if (cantidadDev <= 0)
                {
                    MessageBox.Show("Error al Ingresar la Cantidad Devuelta");
                    return;
                }

                DevOrdenCompra_Controller.UpdateDataDevOrdenCompra(id, idOrden, cantidadDev, observacion, fechaDev);
                VerDevOrdeneCompra();
                ClearDevOrdenCompra();
            }
        }

        private void btnEliminar_Dev_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(txtId_Dev.Text);

            if (txtId_Dev.Text == " ")
            {
                MessageBox.Show("Debe Seleccionar un Id de la Tabla");
                return;
            }
            else
            {

                DevOrdenCompra_Controller.UnsubScribeDataDevOrdenCompra(id);

                VerDevOrdeneCompra();
                ClearDevOrdenCompra();
            }
        }

        //=====================================================================================================================================================//
        private void btnGuardar_OT_Click(object sender, EventArgs e)
        {
            int idCliente, NumeroOrden;
            string producto, marcaProd, serieProd, modeloProd,  trabajoRealizado, observacione;
            DateTime fechaOrden;

            //SOLO LAS OBSERVACIONES PUEDEN SER NULAS
            if (txtId_Cliente_OT.Text == " " || txtProducto_OT.Text == " " || txtMarca_OT.Text == "" || txtModelo_OT.Text == "" || txtSerie_OT.Text == " " || cmbFechaOrden_OT.Text == " " || txtTrabajoRealizado_OT.Text == " " || txtNumOrden.Text == " ")
            {
                MessageBox.Show("Error de Campo");
                return;
            }
            else
            {
                idCliente = Convert.ToInt32(txtId_Cliente_OT.Text);
                producto = txtProducto_OT.Text;
                marcaProd = txtMarca_OT.Text;
                serieProd = txtSerie_OT.Text;
                modeloProd = txtModelo_OT.Text;
                fechaOrden = cmbFechaOrden_OT.Value;
                trabajoRealizado = txtTrabajoRealizado_OT.Text;
                observacione = txtObservaciones_OT.Text;
                NumeroOrden = Convert.ToInt32(txtNumOrden.Text);

                OrdenTrabajo_Controller.InsertDataOrdenTrabajo(NumeroOrden, idCliente, producto, marcaProd, serieProd, modeloProd, fechaOrden, trabajoRealizado, observacione);

                VerOrdenTrabajo();
                ClearOrdenTrabajo();
            }
        }

        private void btnEditar_OT_Click(object sender, EventArgs e)
        {
            int id;
            int idCliente,NumeroOrden;
            string producto, marcaProd, serieProd, modeloProd,  trabajoRealizado, observacione;
            DateTime fechaOrden;

            //SOLO LAS OBSERVACIONES PUEDEN SER NULAS
            if (txtId_Cliente_OT.Text == " " || txtProducto_OT.Text == " " || txtMarca_OT.Text == "" || txtModelo_OT.Text == "" || txtSerie_OT.Text == " " || cmbFechaOrden_OT.Text == " " || txtTrabajoRealizado_OT.Text == " " || txtNumOrden.Text == " ")
            {
                MessageBox.Show("Error de Campo");
                return;
            }
            else
            {
                id = Convert.ToInt32(txtId_OT.Text);
                idCliente = Convert.ToInt32(txtId_Cliente_OT.Text);
                producto = txtProducto_OT.Text;
                marcaProd = txtMarca_OT.Text;
                serieProd = txtSerie_OT.Text;
                modeloProd = txtModelo_OT.Text;
                fechaOrden = cmbFechaOrden_OT.Value;
                trabajoRealizado = txtTrabajoRealizado_OT.Text;
                observacione = txtObservaciones_OT.Text;
                NumeroOrden = Convert.ToInt32(txtNumOrden.Text);

                OrdenTrabajo_Controller.UpdateDataOrdenTrabajo(id, NumeroOrden, idCliente, producto, marcaProd, serieProd, modeloProd, fechaOrden, trabajoRealizado, observacione);
                VerOrdenTrabajo();
                ClearOrdenTrabajo();
            }
        }

        private void btnEliminar_OT_Click(object sender, EventArgs e)
        {
            int id;
            if (txtId_OT.Text == " ")
            {
                MessageBox.Show("Debe seleccionar un Id de la Tabla");
                return;
            }
            else
            {
                id = Convert.ToInt32(txtId_OT.Text);
                OrdenTrabajo_Controller.UnsubScribeDataOrdenTrabajo(id);

                VerOrdenTrabajo();
                ClearOrdenTrabajo();
            }
        }

        private void txtNumeroOrden_OC_KeyPress(object sender, KeyPressEventArgs e)
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
        //================================================================//
        private void button1_Click(object sender, EventArgs e)
        {
            ClearOrdenCompra();
        }

        private void btnClear_DevCompra_Click(object sender, EventArgs e)
        {
            ClearDevOrdenCompra();
        }

        private void btnClear_OrT_Click(object sender, EventArgs e)
        {
            ClearOrdenTrabajo();
        }

        private void txtCanDev_Dev_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtFinder_OC_TextChanged(object sender, EventArgs e)
        {
            dgvOrdenCompra.DataSource = null;
            dgvOrdenCompra.DataSource = OrdenCompra_Controller.SearchDataOrdenCompra(txtFinder_OC.Text);
        }

        private void txtFinder_Dev_TextChanged(object sender, EventArgs e)
        {
            dgvDevOrdenCompra.DataSource = null;
            dgvDevOrdenCompra.DataSource = DevOrdenCompra_Controller.SearchDataDevOrdenCompra(txtFinder_Dev.Text);
        }

        private void txtFinder_OT_TextChanged(object sender, EventArgs e)
        {
            dgvOrdenTrabajo.DataSource = null;
            dgvOrdenTrabajo.DataSource = OrdenTrabajo_Controller.SearchDataOrdenTrabajo(txtFinder_OT.Text);
        }

    }//------------------------------
}
