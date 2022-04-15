using DataAcces;
using DataAcces.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.MRP
{
    public partial class FrmMRP : Form 
    {
        private string id_padre;
        private string id_hijo;
        public DataSet dtsN = null;
        private string id_mrp;

        public FrmMRP()
        {
            InitializeComponent();
            dtsN = new DataSet();
        }
        
        private void FrmMRP_Load(object sender, EventArgs e)
        {
            //CargarDataSQL();
            Load_DataTable("T");
            if (tvArbol.Nodes.Count <= 0)
            {
                btnSubAdd.Enabled = false;
            }
        }

        #region "METODOS GENERADOS"
        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this.id_hijo = dgvDatos.Rows[e.RowIndex].Cells["Cod"].Value.ToString();
                this.txtHijo.Text = dgvDatos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            C_Nodo.Insert_Nodo("",id_hijo,true,txtCant.Value.ToString());
            Load_DataTable("T");
            CargaDataTreeView();

            if (tvArbol.Nodes.Count <= 0)
            {
                MessageBox.Show("Debe Ingresar un Nodo Para poder Agregar un Sub Nodo");
                return;
            }
            else
            {
                btnSubAdd.Enabled = true;
            }
        }

        private void btnSubAdd_Click(object sender, EventArgs e)
        {
            C_Nodo.Insert_Nodo(id_padre, id_hijo, false, txtCant.Value.ToString());
            Load_DataTable("T");
            CargaDataTreeView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        #endregion
        #region "METODOS NODO"
        public void CargarDataSQL()
        {
            try
            {
                dtsN = C_Nodo.CargarNodos();
                CrearNodosDelPadre(0, null);
                tvArbol.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en cargaDatosSQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        /// <summary>
        /// Este método lo utilizamos cuando hacemos la carga desde una base de datos SQL
        /// </summary>
        /// <param name="indicePadre"></param>
        /// <param name="nodePadre"></param>
        private void CrearNodosDelPadre(int indicePadre, TreeNode nodePadre)
        {
            // Crear un DataView con los Nodos que dependen del Nodo padre pasado como parámetro.
            DataView dataViewHijos = new DataView(dtsN.Tables["Nodo"]);
            dataViewHijos.RowFilter = dtsN.Tables["Nodo"].Columns["nodo_padre"].ColumnName + " = " + indicePadre;

            // Agregar al TreeView los nodos Hijos que se han obtenido.
            foreach (DataRowView dataRowCurrent in dataViewHijos)
            {
                TreeNode nuevoNodo = new TreeNode();
                nuevoNodo.Text = dataRowCurrent["des_nodo"].ToString().Trim();   //Dato a mostrar
                nuevoNodo.Name = dataRowCurrent["nodo_hijo"].ToString().Trim();  //Valor guardado en le nombre 

                // si el parámetro nodoPadre es nulo es porque es la primera llamada, son los Nodos
                // del primer nivel que no dependen de otro nodo.
                if (nodePadre == null)
                    tvArbol.Nodes.Add(nuevoNodo);
                else
                    nodePadre.Nodes.Add(nuevoNodo); // se añade el nuevo nodo al nodo padre.

                // Llamada recurrente al mismo método para agregar los Hijos del Nodo recién agregado.
                CrearNodosDelPadre(Int32.Parse(dataRowCurrent["nodo_hijo"].ToString()), nuevoNodo);
            }
        }
        #endregion
        #region "METODOS CREADOS"
        private void Load_DataTable(string tipo)
        {
            if (tipo.Equals("P")) //PRODUCTOS
            {
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = C_Producto.view_search_producto("");
            }
            else if (tipo.Equals("M")) //MATERIALES
            {
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = C_Material.view_search_Material("");
            }
            else if (tipo.Equals("MRP"))
            {
                dgvMRP.DataSource = null;
                dgvMRP.DataSource = C_Nodo.View_Nodo();
            }
            else if (tipo.Equals("T"))
            {
                dgvMRP.DataSource = null;
                dgvMRP.DataSource = C_Nodo.View_Nodo();
                if (rbtProducto.Checked.Equals(true))
                {
                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = C_Producto.view_search_producto("");
                }
                else
                {
                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = C_Material.view_search_Material("");
                }
            }
        }

        private void CargaDataTreeView()
        {
            tvArbol.Nodes.Clear();
            CargarDataSQL();
            ClearTxt();
        }

        private void ClearTxt()
        {
            this.txtHijo.Text = "";
            this.txtPadre.Text = "";
            this.id_hijo = "";
            this.id_padre = "";
        }
        #endregion

        private void rbtProducto_CheckedChanged(object sender, EventArgs e)
        {
            Load_DataTable("P");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Load_DataTable("M");
        }

        private void dgvMRP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this.id_mrp = dgvMRP.Rows[e.RowIndex].Cells["id_nodo"].Value.ToString();
                this.id_padre = dgvMRP.Rows[e.RowIndex].Cells["nodo_hijo"].Value.ToString();
                this.txtPadre.Text = dgvMRP.Rows[e.RowIndex].Cells["des_nodo"].Value.ToString();
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            C_Nodo.update_Nodo(id_mrp,txtCant.Value.ToString());
            Load_DataTable("T");
            CargaDataTreeView();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            C_Nodo.delete_Nodo(id_mrp,0);
            Load_DataTable("T");
            CargaDataTreeView();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            C_Nodo.delete_Nodo(id_mrp, 1);
            Load_DataTable("T");
            CargaDataTreeView();
        }
    }
}
