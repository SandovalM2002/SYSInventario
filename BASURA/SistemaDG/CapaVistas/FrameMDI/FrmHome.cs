using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using CapaDatos;
using System.Windows.Forms;

namespace CapaVistas.FrameMDI
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void DesignTabla()
        {
            dgvOrdenesCompra.Columns[0].Width = 100;
            dgvOrdenesCompra.Columns[1].Width = 170;
            dgvOrdenesCompra.Columns[2].Width = 170;
            dgvOrdenesCompra.Columns[3].Width = 170;
            dgvOrdenesCompra.Columns[4].Width = 170;
            dgvOrdenesCompra.Columns[5].Width = 170;
            dgvOrdenesCompra.Columns[6].Width = 170;
            dgvOrdenesCompra.Columns[7].Width = 170;
            dgvOrdenesCompra.Columns[8].Width = 170;
            dgvOrdenesCompra.Columns[9].Width = 170;
            dgvOrdenesCompra.Columns[10].Width = 170;
            dgvOrdenesCompra.Columns[11].Width = 170;
            dgvOrdenesCompra.Columns[12].Width = 170;
            dgvOrdenesCompra.Columns[13].Width = 170;
        }

        private void VerTabla()
        {
           dgvOrdenesCompra.DataSource = null;
           dgvOrdenesCompra.DataSource = OrdenCompra_Controller.ViewDataOrdenCompra();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            VerTabla();
            DesignTabla();
            
        }

        private void txtFinder_TextChanged(object sender, EventArgs e)
        {
            dgvOrdenesCompra.DataSource = null;
            dgvOrdenesCompra.DataSource = OrdenCompra_Controller.SearchDataOrdenCompra(txtFinder.Text);

            DesignTabla();
        }

        private void ShowTotales()
        {
            TotalData td = new TotalData();
            SumaryHome_Controller.TotalHome();
            lblNClientes.Text = td.Total_Clientes;
            lblNInventario.Text = td.Total_Inventarios;
            lblNOrdenesCompra.Text = td.Total_OrdenCompra;
            lblNOrdenesTrabajo.Text = td.Total_OrdenTrabajo;
        }
    }
}
