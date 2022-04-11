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

namespace Views.MRP
{
    public partial class FrmMRP : Form
    {
        private int _row;
        private string _nombre_nodo;

        public FrmMRP()
        {
            InitializeComponent();
        }

        private void FrmMRP_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = null;
            if (rbtProducto.Checked.Equals(true))
            {
                dgvDatos.DataSource = C_Producto.view_search_producto("");
            }
            else
            {
                dgvDatos.DataSource = C_Material.view_search_Material("");
            }
        }

        private void rbtProducto_CheckedChanged(object sender, EventArgs e)
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = C_Producto.view_search_producto("");
        }

        private void rbtMaterial_CheckedChanged(object sender, EventArgs e)
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = C_Material.view_search_Material("");
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this._row = e.RowIndex;
                this._nombre_nodo = dgvDatos.Rows[_row].Cells["Nombre"].Value.ToString();
                txtSelect.Text = this._nombre_nodo;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode node = new TreeNode(this._nombre_nodo);
                tvArbol.Nodes.Add(node);
                this._nombre_nodo = "";
                txtSelect.Text = "";
            }catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                return;
            }
        }

        private void btnAdd_sub_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode node = new TreeNode(this._nombre_nodo);
                tvArbol.SelectedNode.Nodes.Add(node);
                this._nombre_nodo = "";
                txtSelect.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error"+ex.Message);
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                tvArbol.SelectedNode.Text = txtSelect.Text;
                txtSelect.Text = "";
            }catch(Exception ex)
            {
                MessageBox.Show("Error"+ex.Message);
                return;
            }
        }

        private void tvArbol_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                // get selected node text
                txtSelect.Text = tvArbol.SelectedNode.Text;

                // get selected node name
                txtSelect.Text = txtSelect.Text + tvArbol.SelectedNode.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                tvArbol.SelectedNode.Remove();
                txtSelect.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
