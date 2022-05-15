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
        }
        
        private void load_Table(string param)
        {
            dgvStock.DataSource = null;
            dgvStock.DataSource = C_Stock.view_stock(param);

            cmbNodo_PM.DataSource = C_Nodo.view();
            cmbNodo_PM.DisplayMember = "Descripción";
            cmbNodo_PM.ValueMember = "Cod";
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

    }
}
