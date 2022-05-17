using DataAcces.Controller;
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
    public partial class FrmGestion : Form
    {

        public FrmGestion()
        {
            InitializeComponent();
            Graficar(500, 30);
            gbPrecios1.Enabled = false;
            gbPrecios2.Enabled = false;
        }

        //Validar solo numeros enteros
        private void validarNumerosEnteros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //Validar solo numeros decimales
        private void validarNumerosDecimales(object sender, KeyPressEventArgs e)
        {
            TextBox txt = new TextBox();
            txt = (TextBox)sender;

            ValidacionesNumericas.validarNumerosDecimales(e, txt.Text);
        }

        private void Graficar(double eoq, double rop)
        {
            GraficaEOQ.Series["ModeloQ"].Points.Clear();
            GraficaEOQ.Series["ROP"].Points.Clear();
            double cantidad = eoq / 10;
            double x = 0;
            for (double i = 0; i <=4; i++)
            {
                for (double j = 0; j <= eoq; j+=cantidad)
                {
                    GraficaEOQ.Series["ModeloQ"].Points.AddXY(x, j);
                    GraficaEOQ.Series["ROP"].Points.AddXY(x, rop);
                }
                
                for (double j = eoq; j >= 0; j -= cantidad)
                {
                    GraficaEOQ.Series["ModeloQ"].Points.AddXY(x, j);
                    GraficaEOQ.Series["ROP"].Points.AddXY(x, rop);
                    x++;
                }
                x--;
            }
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
            LoadABC();
        }

        public void LoadABC()
        {
            dgvABC.DataSource = null;
            dgvABC.DataSource = C_ModeloABC.view_ABC();

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
            try
            {
                if (string.IsNullOrWhiteSpace(txtDemanda.Text) || string.IsNullOrWhiteSpace(txtCostoPedido.Text)
                         || string.IsNullOrWhiteSpace(txtCostoProd.Text) || string.IsNullOrWhiteSpace(txtPlazoEnt.Text)
                          || string.IsNullOrWhiteSpace(txtDiasH.Text))
                {
                    MessageBox.Show("No debe dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txtCostoMant.Enabled == true && string.IsNullOrWhiteSpace(txtCostoMant.Text))
                {
                    MessageBox.Show("No debe dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txtTasaMant.Enabled == true && string.IsNullOrWhiteSpace(txtTasaMant.Text))
                {
                    MessageBox.Show("No debe dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!rbCostoMant.Checked && !rbTasaMan.Checked)
                {
                    MessageBox.Show("Debe elegir la tasa o el costo de mantener", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double diasHabiles = double.Parse(txtDiasH.Text);
                double multiplicadorDemanda = cbDemanda.SelectedIndex == 0 ? 1 : cbDemanda.SelectedIndex == 1 ? 12 : cbDemanda.SelectedIndex == 2 ? 52 : diasHabiles;
                double multiplicadorTasa = cbTasaMan.SelectedIndex == 0 ? 1 : cbTasaMan.SelectedIndex == 1 ? 12 : cbTasaMan.SelectedIndex == 2 ? 52 : cbTasaMan.SelectedIndex == 3 ? diasHabiles : 1;
                double multiplicadorCostoM = cbCostoMant.SelectedIndex == 0 ? 1 : cbCostoMant.SelectedIndex == 1 ? 12 : cbCostoMant.SelectedIndex == 2 ? 52 : cbCostoMant.SelectedIndex == 3 ? diasHabiles : 1;

                double tasaMant = txtTasaMant.Enabled == true ? double.Parse(txtTasaMant.Text) / 100 * multiplicadorTasa : 1;
                double demanda = double.Parse(txtDemanda.Text) * multiplicadorDemanda;
                double costoPedir = double.Parse(txtCostoPedido.Text);
                double costoProd = double.Parse(txtCostoProd.Text);
                double costoMantener = txtCostoMant.Enabled == true ? double.Parse(txtCostoMant.Text) * multiplicadorCostoM : costoProd * tasaMant;
                double plazoEntrega = double.Parse(txtPlazoEnt.Text);

                double eoq = Math.Sqrt((2 * demanda * costoPedir) / costoMantener);
                lblEQO.Text = "Q optimo:" + Math.Floor(eoq).ToString();

                double rop = demanda / diasHabiles * plazoEntrega;
                lblRop.Text = "ROP: " + Math.Floor(rop).ToString();

                double costoT = ((demanda * costoPedir) / eoq) + ((eoq * costoMantener) / 2) + (demanda * costoProd);
                lblCostoT.Text = "Costo Total:" + Math.Round(costoT).ToString();

                Graficar(eoq, rop);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbCostoMant_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnCalcularPU_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtDesvPU.Text)
                    || string.IsNullOrWhiteSpace(txtDemPU.Text))
                {
                    MessageBox.Show("No debe dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (!rbPrecios1.Checked && !rbPrecios2.Checked)
                {
                    MessageBox.Show("Seleccione el metodo de precio dados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                double precioC = 0;
                double precioV = 0;
                double precioRV = 0;
                double excedente = 0;
                double faltante = 0;

                if (rbPrecios1.Checked)
                {
                    if (string.IsNullOrWhiteSpace(txtPrCompra.Text) || string.IsNullOrWhiteSpace(txtPrVenta.Text)
                    || string.IsNullOrWhiteSpace(txtPrReventa.Text))
                    {
                        MessageBox.Show("No debe dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        precioC = double.Parse(txtPrCompra.Text);
                        precioV = double.Parse(txtPrVenta.Text);
                        precioRV = double.Parse(txtPrReventa.Text);

                        excedente = precioC - precioRV;
                        faltante = precioV - precioC;
                    }
                }else if (rbPrecios2.Checked)
                {

                    if (string.IsNullOrWhiteSpace(txtFaltante.Text) || string.IsNullOrWhiteSpace(txtSobrante.Text))
                    {
                        MessageBox.Show("No debe dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        excedente = double.Parse(txtSobrante.Text);
                        faltante = double.Parse(txtFaltante.Text);
                    }

                    
                }

                double desviacion = double.Parse(txtDesvPU.Text);
                double demanda = double.Parse(txtDemPU.Text);
                double probabilidad = faltante / (faltante + excedente);

                Chart mychart = new Chart();
                double z = mychart.DataManipulator.Statistics.InverseNormalDistribution(probabilidad);

                double resultado = demanda + (z * desviacion);

                lblPF.Text = "Precio del faltante es: " + faltante.ToString();
                lblPS.Text = "Precio del sobrante es: " + excedente.ToString();
                lblCOPU.Text = "Cantidad Optima a pedir: " + Math.Round(resultado, 0).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurido un error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerarTabla_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCantDatos.Text))
                {
                    MessageBox.Show("No debe dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dgvDatosAM.ColumnCount = 2;
                dgvDatosAM.Columns[0].Name = "Demanda";
                dgvDatosAM.Columns[1].Name = "Probabilidad";
                dgvDatosAM.RowCount = int.Parse(txtCantDatos.Text);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurido un error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAM_Click(object sender, EventArgs e)
        {

            //LLAMAR VALIDACION DE TABLA NULA
            if (ValidateGrid().Equals(true))
            {
                MessageBox.Show("Debe ingresar datos a la tabla, debe poner ceros si no hay dato");
                return;
            }

            try
            {
                if (string.IsNullOrWhiteSpace(txtPFAM.Text) || string.IsNullOrWhiteSpace(txtPSAM.Text))
                {
                    MessageBox.Show("No debe dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                #region Variables
                double suma = 0;
                double demanda = 0;
                double faltante = double.Parse(txtPFAM.Text);
                double excedente = double.Parse(txtPSAM.Text);
                double probabilidad = faltante / (faltante + excedente);
                #endregion

                #region calculo produccion optima
                for (int fila = 0; fila < dgvDatosAM.Rows.Count; fila++)
                {
                    if (suma > probabilidad)
                    {
                        lblAm.Text = "Cantidad Optima a Producir es de: " + demanda.ToString();
                        break;
                    }

                    for (int col = 0; col < dgvDatosAM.Rows[fila].Cells.Count; col++)
                    {
                        if (col == 0)
                        {
                            string d = dgvDatosAM.Rows[fila].Cells[col].Value.ToString();
                            demanda = double.Parse(d);
                        }
                        else
                        {
                            string valor = dgvDatosAM.Rows[fila].Cells[col].Value.ToString();
                            suma += double.Parse(valor);
                        }


                    }
                }
                #endregion

                #region calculo AM
                int cantidad = int.Parse(txtCantDatos.Text);
                dgvAM.ColumnCount = cantidad;
                dgvAM.RowCount = cantidad + 1;
                for (int i = 0; i < cantidad; i++)
                {
                    dgvAM.Columns[i].Name = dgvDatosAM.Rows[i].Cells[0].Value.ToString();
                }

                double auxEx = excedente;
                double auxFal = faltante;
                for (int fila = 0; fila < dgvAM.Rows.Count - 1; fila++)
                {
                    auxEx = excedente;
                    auxFal = faltante * fila;
                    for (int col = 0; col < dgvAM.Rows[fila].Cells.Count; col++)
                    {
                        if (fila == col)
                        {
                            dgvAM.Rows[fila].Cells[col].Value = 0;
                        }
                        else if (fila < col)
                        {
                            dgvAM.Rows[fila].Cells[col].Value = auxEx;
                            auxEx += excedente;
                        }
                        else if (fila > col)
                        {
                            dgvAM.Rows[fila].Cells[col].Value = auxFal;
                            auxFal -= faltante;
                        }
                    }
                }

                int pos = 0;
                for (int fila = dgvAM.Rows.Count - 1; fila < dgvAM.Rows.Count; fila++)
                {
                    for (int col = 0; col < dgvAM.Rows[fila].Cells.Count; col++)
                    {
                        double costo = 0;

                        for (int i = 0; i < cantidad; i++)
                        {
                            double a = double.Parse(dgvDatosAM.Rows[i].Cells[1].Value.ToString());
                            double b = double.Parse(dgvAM.Rows[i].Cells[pos].Value.ToString());
                            costo += (a * b);
                        }
                        pos++;
                        dgvAM.Rows[fila].Cells[col].Value = costo;
                        dgvAM.Rows[fila].Cells[col].Style.ForeColor = Color.Red;
                    }
                }

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurido un error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string getFrameName()
        {
            return "EOQ";
        }

        private bool ValidateGrid()
        {
            for (int i = 0; i < dgvDatosAM.RowCount - 1; i++)
            {
                for (int j = 0; j < dgvDatosAM.ColumnCount; j++)
                {
                    if (dgvDatosAM.Rows[i].Cells[j].Value == null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void rbPrecios1_CheckedChanged(object sender, EventArgs e)
        {
            gbPrecios1.Enabled = true;
            gbPrecios2.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gbPrecios1.Enabled = false;
            gbPrecios2.Enabled = true;
        }
    }
}
