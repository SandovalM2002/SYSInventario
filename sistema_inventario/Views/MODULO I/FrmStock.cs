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

namespace Views.INVENTARIO
{
    public partial class FrmStock : Form
    {
        private static string id_frm = "STOCK";

        public FrmStock()
        {
            InitializeComponent();
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            load_Table("");
            load_table_PM_RP();
        }
        
        private void load_Table(string param)
        {
            dgvStock.DataSource = null;
            dgvStock.DataSource = C_Stock.view_stock(param);

            cmbNodo_PM.DataSource = C_Nodo.view();
            cmbNodo_PM.DisplayMember = "Descripción";
            cmbNodo_PM.ValueMember = "Cod";

            cmbNodo_RP.DataSource = C_Nodo.view();
            cmbNodo_RP.DisplayMember = "Descripción";
            cmbNodo_RP.ValueMember = "Cod";

        }

        private void load_table_PM_RP()
        {
            dgvPlan_Maestro.DataSource = null;
            dgvPlan_Maestro.DataSource = C_PlanMaestro.view_Plan_Maestro();

            dgvRP.DataSource = null;
            dgvRP.DataSource = C_RecepcionesProgramadas.view_recepciones_programdas();
        }

        public static string getFrameName()
        {
            return id_frm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool tipo;

                if (cmbTipo.SelectedItem.ToString().Equals("Producto"))
                {
                    tipo = true;
                }
                else
                {
                    tipo = false;
                }

                C_Stock.insert_stock(txtNombre.Text,tipo,Convert.ToDecimal(txtCosto.Value), Convert.ToDecimal(txtPrecio.Value),Convert.ToInt32(txtExistencia.Value),Convert.ToInt32(txtSS.Value));
                load_Table("");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            load_Table(txtFinder.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool tipo;

                if (cmbTipo.SelectedItem.ToString().Equals("Producto"))
                {
                    tipo = true;
                }
                else
                {
                    tipo = false;
                }

                C_Stock.update_stock(txtCod.Text,txtNombre.Text, tipo, Convert.ToDecimal(txtCosto.Value), Convert.ToDecimal(txtPrecio.Value), Convert.ToInt32(txtExistencia.Value), Convert.ToInt32(txtSS.Value));
                load_Table("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                C_Stock.delete_stock(txtCod.Text);
                load_Table("");
            }
            catch(Exception)
            {
                return;
            }
        }

        private void dgvStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    txtCod.Text = dgvStock.Rows[e.RowIndex].Cells["Cod"].Value.ToString();
                    txtNombre.Text = dgvStock.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    if (dgvStock.Rows[e.RowIndex].Cells["Tipo"].Value.ToString() == "MATERIAL")
                    {
                        cmbTipo.Text = "MATERIAL";
                    }
                    else { cmbTipo.Text = "PRODUCTO"; }
                    txtCosto.Value = Convert.ToDecimal(dgvStock.Rows[e.RowIndex].Cells["Costo"].Value.ToString());
                    txtPrecio.Value = Convert.ToDecimal(dgvStock.Rows[e.RowIndex].Cells["Precio"].Value.ToString());
                    txtExistencia.Value = Convert.ToInt32(dgvStock.Rows[e.RowIndex].Cells["Inventario"].Value.ToString());
                    txtSS.Value = Convert.ToInt32(dgvStock.Rows[e.RowIndex].Cells["Stock Seguridad"].Value.ToString());
                }
            }
            catch (Exception)
            {
                return;
            }
        }


        /*Plan maestro*/
        private void btnAdd_PM_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbNodo_PM.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccion un nodo, en caso de no existir, agregue uno");
                    return;
                }


                C_PlanMaestro.Insert_Plan_Maestro(cmbNodo_PM.SelectedValue.ToString(), txtDemanda_MP.Value.ToString(),txtPeriodo_PM.Value.ToString());
                load_table_PM_RP();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_PM_Click(object sender, EventArgs e)
        {
            try
            {
                C_PlanMaestro.Update_Plan_Maestro(txtId_PM.Text, cmbNodo_PM.SelectedValue.ToString(), txtDemanda_MP.Value.ToString(), txtPeriodo_PM.Value.ToString());
                load_table_PM_RP();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_PM_Click(object sender, EventArgs e)
        {
            try
            {
                C_PlanMaestro.Delete_Plan_Maestro(txtId_PM.Text);
                load_table_PM_RP();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dgvPlan_Maestro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    txtId_PM.Text = dgvPlan_Maestro.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                    cmbNodo_PM.SelectedValue = dgvPlan_Maestro.Rows[e.RowIndex].Cells["Nodo"].Value; 

                    txtDemanda_MP.Value = Convert.ToDecimal(dgvPlan_Maestro.Rows[e.RowIndex].Cells["Demanda"].Value.ToString());
                    txtPeriodo_PM.Value = Convert.ToDecimal(dgvPlan_Maestro.Rows[e.RowIndex].Cells["Periodo"].Value.ToString());
                }
            }
            catch (Exception)
            {
                return;
            }
        }


        /*Recepcion Programada*/
        private void btnAdd_RP_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbNodo_RP.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccion un nodo, en caso de no existir, agregue uno");
                    return;
                }

                C_RecepcionesProgramadas.insert_recepciones_programadas(cmbNodo_RP.SelectedValue.ToString(), txtCantidad_RP.Value.ToString(), txtPeriodo_RP.Value.ToString());
                load_table_PM_RP();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_RP_Click(object sender, EventArgs e)
        {
            try
            {
                C_RecepcionesProgramadas.update_recepciones_programadas(txtId_RP.Text, cmbNodo_RP.SelectedValue.ToString(), txtCantidad_RP.Value.ToString(), txtPeriodo_RP.Value.ToString());
                load_table_PM_RP();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_RP_Click(object sender, EventArgs e)
        {
            try
            {
                C_RecepcionesProgramadas.delete_recepciones_programadas(txtId_RP.Text);
                load_table_PM_RP();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dgvRP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    txtId_RP.Text = dgvRP.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                    cmbNodo_RP.SelectedValue = dgvRP.Rows[e.RowIndex].Cells["Nodo"].Value;

                    txtCantidad_RP.Value = Convert.ToDecimal(dgvRP.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());
                    txtPeriodo_RP.Value = Convert.ToDecimal(dgvRP.Rows[e.RowIndex].Cells["Periodo"].Value.ToString());
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
