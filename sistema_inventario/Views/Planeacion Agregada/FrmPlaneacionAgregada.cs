using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.Planeacion_Agregada
{
    public partial class FrmPlaneacionAgregada : Form
    {
        public FrmPlaneacionAgregada()
        {
            InitializeComponent();
            gbPersecucion.Enabled = false;
            gbFuerzaN.Enabled = false;
            gbOutS.Enabled = false;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int periodos = int.Parse(txtPeriodos.Text);
            dgvDYD.RowCount = 2;
            dgvDYD.ColumnCount = periodos;

            dgvDYD.Rows[0].HeaderCell.Value = "Demanda";
            dgvDYD.Rows[1].HeaderCell.Value = "Dias Habiles";

            for (int i = 0; i < periodos; i++)
            {
                dgvDYD.Columns[i].Name = "Periodo " + (i + 1);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //llamar metodo para calcular por medio de la estrategia de persecucion
            if (rbPersecucion.Checked)
            {
                estrategiaPersecucion();
            }else if (rbFuerzaNiv.Checked)
            {
                estrategiaFuerzaNivelada();
            }else if (rbOutS.Checked)
            {
                estrategiaOutS();
            }
            
        }

        private void estrategiaPersecucion()
        {
            int invInicial = int.Parse(txtInvIni.Text);
            double stockS = double.Parse(txtSS.Text) / 100;
            string[] nombres = {"Inventario Inicial", "Pronóstico de la demanda", "Inventario de seguridad",
                "Requerimiento de producción","Inventario final","Horas de producción requeridas","Días hábiles por mes",
            "Horas al mes por trabajador","Trabajadores requeridos","Nuevos trabajadores contratados","Costo de contratación",
            "Despido de trabajadores","Costo de despido ","Costo del tiempo normal"};
            int periodos = int.Parse(txtPeriodos.Text);
            int horas = int.Parse(txtHoras.Text);
            int trabajadores = int.Parse(txtTrabajadores.Text);
            double costoContratar = double.Parse(txtContratar.Text);
            double costoDespedir = double.Parse(txtDespedir.Text);
            double valorHora = double.Parse(txtValorHora.Text);
            double costoTotal = 0;

            dgvPlanificacion.RowCount = 14;
            dgvPlanificacion.ColumnCount = periodos;

            for (int i = 0; i < periodos; i++)
            {
                dgvPlanificacion.Columns[i].Name = "Periodo " + (i + 1);
            }

            for (int col = 0; col < periodos; col++)
            {
                int demanda = int.Parse(dgvDYD.Rows[0].Cells[col].Value.ToString());
                int invS = (int)((int)demanda * stockS);
                int reqProd = demanda - invInicial + invS;
                double horasReq = horas * reqProd;
                int diasH = int.Parse(dgvDYD.Rows[1].Cells[col].Value.ToString());
                double horasMesTrabajador = diasH * 8;
                double trabaReq = horasReq / horasMesTrabajador;
                trabaReq = Math.Round(trabaReq);
                int contratados = 0;
                int despedidos = 0;

                if (trabaReq > trabajadores)
                {
                    contratados = (int)(trabaReq - trabajadores);
                    trabajadores += contratados;
                }
                else if (trabaReq < trabajadores)
                {
                    despedidos = (int)(trabajadores - trabaReq);
                    trabajadores -= despedidos;
                }

                for (int fila = 0; fila < dgvPlanificacion.RowCount; fila++)
                {


                    dgvPlanificacion.Rows[fila].HeaderCell.Value = nombres[fila];

                    switch (fila)
                    {
                        case 0:
                            dgvPlanificacion.Rows[fila].Cells[col].Value = invInicial;
                            break;
                        case 1:
                            dgvPlanificacion.Rows[fila].Cells[col].Value = demanda;
                            break;
                        case 2:
                            dgvPlanificacion.Rows[fila].Cells[col].Value = invS;
                            break;
                        case 3:
                            dgvPlanificacion.Rows[fila].Cells[col].Style.ForeColor = Color.Green;
                            dgvPlanificacion.Rows[fila].Cells[col].Value = reqProd;
                            break;
                        case 4:
                            invInicial = invInicial - demanda + reqProd;
                            dgvPlanificacion.Rows[fila].Cells[col].Style.ForeColor = Color.Black;
                            dgvPlanificacion.Rows[fila].Cells[col].Value = invInicial;
                            break;
                        case 5:
                            dgvPlanificacion.Rows[fila].Cells[col].Value = horasReq;
                            break;
                        case 6:
                            dgvPlanificacion.Rows[fila].Cells[col].Value = diasH;
                            break;
                        case 7:
                            dgvPlanificacion.Rows[fila].Cells[col].Value = horasMesTrabajador;
                            break;
                        case 8:
                            dgvPlanificacion.Rows[fila].Cells[col].Value = trabaReq;
                            break;
                        case 9:
                            dgvPlanificacion.Rows[fila].Cells[col].Value = contratados;
                            break;
                        case 10:
                            costoTotal += contratados * costoContratar;
                            dgvPlanificacion.Rows[fila].Cells[col].Style.ForeColor = Color.Red;
                            dgvPlanificacion.Rows[fila].Cells[col].Value = contratados * costoContratar;
                            break;
                        case 11:
                            dgvPlanificacion.Rows[fila].Cells[col].Style.ForeColor = Color.Black;
                            dgvPlanificacion.Rows[fila].Cells[col].Value = despedidos;
                            break;
                        case 12:
                            costoTotal += despedidos * costoDespedir;
                            dgvPlanificacion.Rows[fila].Cells[col].Style.ForeColor = Color.Red;
                            dgvPlanificacion.Rows[fila].Cells[col].Value = despedidos * costoDespedir;
                            break;
                        case 13:
                            costoTotal += horasReq * valorHora;
                            dgvPlanificacion.Rows[fila].Cells[col].Style.ForeColor = Color.Red;
                            dgvPlanificacion.Rows[fila].Cells[col].Value = horasReq * valorHora;
                            break;
                    }
                }
            }
            lblCosto.Text = "Costo Total: " + costoTotal;
        }

        private void estrategiaFuerzaNivelada()
        {
            int invInicial = int.Parse(txtInvIni.Text);
            double stockS = double.Parse(txtSS.Text) / 100;
            string[] nombres = {"Inventario Inicial", "Días hábiles por mes", "Horas de producción disponibles",
                "Producción real","Pronóstico de la demanda","Inventario final","Costo de escasez",
            "Inventario de seguridad","Unidades en exceso","Costo de inventarios","Costo del tiempo normal"};
            int periodos = int.Parse(txtPeriodos.Text);
            int horas = int.Parse(txtHoras.Text);
            double costoEscasez = double.Parse(txtEscasez.Text);
            double costoMantener = double.Parse(txtMantener.Text);
            double valorHora = double.Parse(txtValorHora.Text);
            double costoTotal = 0;

            dgvPlanificacion.RowCount = 11;
            dgvPlanificacion.ColumnCount = periodos;

            for (int i = 0; i < periodos; i++)
            {
                dgvPlanificacion.Columns[i].Name = "Periodo " + (i + 1);
            }

            int trabajadores = 0;
            int totalDemanda=0, totalDias=0;
            for (int i = 0; i < periodos; i++)
            {
                totalDemanda += int.Parse(dgvDYD.Rows[0].Cells[i].Value.ToString());
                totalDias += int.Parse(dgvDYD.Rows[1].Cells[i].Value.ToString());
            }
            trabajadores = (totalDemanda * horas) / (totalDias * 8);

            for (int col = 0; col < periodos; col++)
            {

                int diasH = int.Parse(dgvDYD.Rows[1].Cells[col].Value.ToString());
                int horasDisponibles = diasH * 8 * trabajadores;
                int produccionReal = horasDisponibles / horas;
                int demanda = int.Parse(dgvDYD.Rows[0].Cells[col].Value.ToString());
                double costoEsc = 0;
                int invS = (int)((int)demanda * stockS);
                int unidadesExc = 0;
                

                for (int fila = 0; fila < dgvPlanificacion.RowCount; fila++)
                {
                    dgvPlanificacion.Rows[fila].HeaderCell.Value = nombres[fila];

                    switch (fila)
                    {
                        case 0:
                            dgvPlanificacion.Rows[fila].Cells[col].Value = invInicial;
                            break;
                        case 1:
                            dgvPlanificacion.Rows[fila].Cells[col].Value = diasH;
                            break;
                        case 2:
                            dgvPlanificacion.Rows[fila].Cells[col].Value = horasDisponibles;
                            break;
                        case 3:
                            dgvPlanificacion.Rows[fila].Cells[col].Value = produccionReal;
                            break;
                        case 4:
                            dgvPlanificacion.Rows[fila].Cells[col].Value = demanda;
                            break;
                        case 5:
                            invInicial = invInicial + produccionReal - demanda;
                            dgvPlanificacion.Rows[fila].Cells[col].Value = invInicial;
                            break;
                        case 6:
                            if (invInicial < 0)
                            {
                                costoEsc = (-invInicial * costoEscasez);
                            }
                            dgvPlanificacion.Rows[fila].Cells[col].Style.ForeColor = Color.Red;
                            dgvPlanificacion.Rows[fila].Cells[col].Value = costoEsc;
                            costoTotal += costoEsc;
                            break;
                        case 7:
                            dgvPlanificacion.Rows[fila].Cells[col].Style.ForeColor = Color.Black;
                            dgvPlanificacion.Rows[fila].Cells[col].Value = invS;
                            break;
                        case 8:
                            if((invInicial - invS) > 0)
                            {
                                unidadesExc = invInicial - invS;
                            }
                            else
                            {
                                unidadesExc = 0;
                            }
                           
                            dgvPlanificacion.Rows[fila].Cells[col].Value = unidadesExc;
                            break;
                        case 9:
                            dgvPlanificacion.Rows[fila].Cells[col].Style.ForeColor = Color.Red;
                            dgvPlanificacion.Rows[fila].Cells[col].Value = Math.Round(unidadesExc * costoMantener);
                            costoTotal += Math.Round(unidadesExc * costoMantener);
                            break;
                        case 10:
                            dgvPlanificacion.Rows[fila].Cells[col].Style.ForeColor = Color.Red;
                            dgvPlanificacion.Rows[fila].Cells[col].Value = Math.Round(horasDisponibles * valorHora);
                            costoTotal += Math.Round(horasDisponibles * valorHora);
                            break;

                    }
                }
            }
            lblCosto.Text = "Costo Total: " + costoTotal;
        }

        private void estrategiaOutS()
        {
            int invInicial = int.Parse(txtInvIni.Text);
            double stockS = double.Parse(txtSS.Text) / 100;
            string[] nombres = {"Requerimiento de producción", "Días hábiles por mes", "Horas de producción disponibles",
                "Producción real","Unidades subcontratadas","Costo de la subcontratación","Costo del tiempo normal"};
            int periodos = int.Parse(txtPeriodos.Text);
            int horas = int.Parse(txtHoras.Text);
            double valorHora = double.Parse(txtValorHora.Text);
            double costoOut = double.Parse(txtOutS.Text);
            double costoTotal = 0;


            dgvPlanificacion.RowCount = 7;
            dgvPlanificacion.ColumnCount = periodos;

            for (int i = 0; i < periodos; i++)
            {
                dgvPlanificacion.Columns[i].Name = "Periodo " + (i + 1);
            }

            int trabajadores = 0;
            int min=1000;
            for (int i = 0; i < periodos; i++)
            {
                int demanda = int.Parse(dgvDYD.Rows[0].Cells[i].Value.ToString());
                int dias = int.Parse(dgvDYD.Rows[1].Cells[i].Value.ToString());
                int invS = (int)((int)demanda * stockS);
                int reqProd = demanda - invInicial + invS;
                invInicial = invInicial - demanda + reqProd;

                if (min > reqProd)
                {
                    min = reqProd;
                    trabajadores = (min * horas) / (dias * 8);
                    MessageBox.Show(trabajadores.ToString());
                }
            }

            invInicial = int.Parse(txtInvIni.Text);
            for (int col = 0; col < periodos; col++)
            {

                int demanda = int.Parse(dgvDYD.Rows[0].Cells[col].Value.ToString());
                int invS = (int)((int)demanda * stockS);
                int reqProd = demanda - invInicial + invS;
                invInicial = invInicial - demanda + reqProd;

                int diasH = int.Parse(dgvDYD.Rows[1].Cells[col].Value.ToString());
                int horasDisponibles = diasH * 8 * trabajadores;
                int produccionReal = horasDisponibles / horas;
                int unidSub = reqProd - produccionReal;

                for (int fila = 0; fila < dgvPlanificacion.RowCount; fila++)
                {
                    dgvPlanificacion.Rows[fila].HeaderCell.Value = nombres[fila];

                    switch (fila)
                    {
                        case 0:
                            dgvPlanificacion.Rows[fila].Cells[col].Value = reqProd;
                            break;
                        case 1:
                            dgvPlanificacion.Rows[fila].Cells[col].Value = diasH;
                            break;
                        case 2:
                            dgvPlanificacion.Rows[fila].Cells[col].Value = horasDisponibles;
                            break;
                        case 3:
                            dgvPlanificacion.Rows[fila].Cells[col].Value = produccionReal;
                            break;
                        case 4:
                            dgvPlanificacion.Rows[fila].Cells[col].Value = unidSub;
                            break;
                        case 5:
                            dgvPlanificacion.Rows[fila].Cells[col].Style.ForeColor = Color.Red;
                            dgvPlanificacion.Rows[fila].Cells[col].Value = unidSub*costoOut;
                            costoTotal += unidSub * costoOut;
                            break;
                        case 6:
                            dgvPlanificacion.Rows[fila].Cells[col].Style.ForeColor = Color.Red;
                            dgvPlanificacion.Rows[fila].Cells[col].Value = Math.Round(horasDisponibles * valorHora);
                            costoTotal += Math.Round(horasDisponibles * valorHora);
                            break;

                    }
                }
            }
            lblCosto.Text = "Costo Total: " + costoTotal;




        }

        private void rbPersecucion_CheckedChanged(object sender, EventArgs e)
        {
            gbPersecucion.Enabled = true;
            gbFuerzaN.Enabled = false;
            gbOutS.Enabled = false;
        }

        private void rbFuerzaNiv_CheckedChanged(object sender, EventArgs e)
        {
            gbPersecucion.Enabled = false;
            gbFuerzaN.Enabled = true;
            gbOutS.Enabled = false;
        }

        private void rbOutS_CheckedChanged(object sender, EventArgs e)
        {
            gbOutS.Enabled = true;
            gbFuerzaN.Enabled = false;
            gbPersecucion.Enabled = false;
        }
    }
}
