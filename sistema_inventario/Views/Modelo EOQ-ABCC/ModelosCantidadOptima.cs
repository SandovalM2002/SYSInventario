using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Views.Modelo_EOQ_ABCC
{
    public partial class ModelosCantidadOptima : Form
    {
        public ModelosCantidadOptima()
        {
            InitializeComponent();
        }

        private void ModelosCantidadOptima_Load(object sender, EventArgs e)
        {
            this.cbDemanda.SelectedIndex = 0;
            this.GraficaEOQ.Titles.Clear();

            this.GraficaEOQ.Titles.Add("Modelo EOQ");
            for (int i = 0; i < 10; i++)
            {
                Series series = this.GraficaEOQ.Series[0];
                series.Points.Add(i);
            }
        }

      

        private void rbCostoMant_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTasaMant.Enabled==true)
            {
                txtTasaMant.Text = "";
                txtTasaMant.Enabled = false;
                cbTasaMan.Enabled = false;
            }
            txtCostoMant.Enabled = true;
            cbCostoMant.Enabled = true;
            cbCostoMant.SelectedIndex = 0;
        }

        private void rbTasaMan_CheckedChanged(object sender, EventArgs e)
        {
            if (txtCostoMant.Enabled == true)
            {
                txtCostoMant.Text = "";
                txtCostoMant.Enabled = false;
                cbCostoMant.Enabled = false;
            }
            txtTasaMant.Enabled = true; 
            cbTasaMan.Enabled = true;
            cbTasaMan.SelectedIndex = 0;
        }

        private void txtCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDemanda.Text) || string.IsNullOrWhiteSpace(txtCostoPedido.Text)
                 || string.IsNullOrWhiteSpace(txtCostoProd.Text) || string.IsNullOrWhiteSpace(txtPlazoEnt.Text)
                  || string.IsNullOrWhiteSpace(txtDiasH.Text))
            {
                errorProvider1.SetError(txtDemanda, "Debe ingresar la demanda");
                MessageBox.Show("No debe dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtCostoMant.Enabled==true && string.IsNullOrWhiteSpace(txtCostoMant.Text))
            {
                MessageBox.Show("No debe dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTasaMant.Enabled == true && string.IsNullOrWhiteSpace(txtTasaMant.Text))
            {
                MessageBox.Show("No debe dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                errorProvider1.Clear();
            }

            double diasHabiles = double.Parse(txtDiasH.Text);
            double multiplicadorDemanda = cbDemanda.SelectedIndex == 0 ? 1 : cbDemanda.SelectedIndex==1 ? 12: cbDemanda.SelectedIndex==2 ? 52 : diasHabiles;
            double multiplicadorTasa = cbTasaMan.SelectedIndex == 0 ? 1 : cbTasaMan.SelectedIndex==1 ? 12: cbTasaMan.SelectedIndex==2 ? 52 : cbTasaMan.SelectedIndex==3 ? diasHabiles : 1;
            double multiplicadorCostoM = cbCostoMant.SelectedIndex == 0 ? 1 : cbCostoMant.SelectedIndex == 1 ? 12 : cbCostoMant.SelectedIndex == 2 ? 52 : cbCostoMant.SelectedIndex == 3 ? diasHabiles : 1;

            double tasaMant = txtTasaMant.Enabled==true ? double.Parse(txtTasaMant.Text)/100*multiplicadorTasa : 1;
            double demanda = double.Parse(txtDemanda.Text)*multiplicadorDemanda;
            double costoPedir = double.Parse(txtCostoPedido.Text);
            double costoProd = double.Parse(txtCostoProd.Text);
            double costoMantener = txtCostoMant.Enabled==true ? double.Parse(txtCostoMant.Text)*multiplicadorCostoM: costoProd*tasaMant;
            double plazoEntrega = double.Parse(txtPlazoEnt.Text);

            double eoq = Math.Sqrt((2*demanda*costoPedir)/costoMantener);
            lblEQO.Text = "Q optimo:" + Math.Round(eoq).ToString();

            double rop = demanda / diasHabiles * plazoEntrega;
            lblRop.Text = "ROP: " + rop.ToString();

            double costoT = (demanda*costoPedir)/eoq+(eoq*costoMantener)/2+demanda*costoProd;
            lblCostoT.Text = "Costo Total:" + costoT.ToString();


        }


        private void cbCostoMant_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
