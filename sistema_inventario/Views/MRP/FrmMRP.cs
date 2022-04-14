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
        private int _row;
        private string id_padre;
        private string id_hijo;
        private char tipo;
        public DataSet dtsN = null;

        public FrmMRP()
        {
            InitializeComponent();
            dtsN = new DataSet();
            Load_DataTable(2);
        }

        private void FrmMRP_Load(object sender, EventArgs e)
        {
            CargarDataSQL();
            Load_DataTable(3);
        }

        #region "METODOS GENERADOS"
        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this._row = e.RowIndex;
                if (rbtPadre.Checked)
                {
                    this.id_padre = dgvDatos.Rows[_row].Cells["Cod"].Value.ToString();
                    this.txtPadre.Text = dgvDatos.Rows[_row].Cells["Nombre"].Value.ToString();
                }
                else if(rbtHijo.Checked)
                {
                    this.id_hijo = dgvDatos.Rows[_row].Cells["Cod"].Value.ToString();
                    this.txtHijo.Text = dgvDatos.Rows[_row].Cells["Nombre"].Value.ToString();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            C_Nodo.Insert_Nodo("",id_hijo,true);
            Load_DataTable(4);
            Load_DataTable(5);
        }

        private void btnSubAdd_Click(object sender, EventArgs e)
        {
            C_Nodo.Insert_Nodo(id_padre,id_hijo,false);
            Load_DataTable(4);
            Load_DataTable(5);
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
        private void Load_DataTable(int t)
        {
            dgvDatos.DataSource = null;
            switch (t)
            {
                case 1: 
                    dgvDatos.DataSource = C_Material.view_search_Material("");
                    this.tipo = 'M';
                    break;
                case 2:
                    dgvDatos.DataSource = C_Producto.view_search_producto("");
                    this.tipo = 'P';
                    break;
                case 3:
                    dgvMRP.DataSource = null;
                    dgvMRP.DataSource = C_Nodo.View_Nodo();
                    break;
                case 4:
                    CargarDataSQL();
                    dgvMRP.DataSource = null;
                    dgvMRP.DataSource = C_Nodo.View_Nodo();
                    break;
                case 5:
                    ClearTxt();
                    break;
            }
        }

        private void ClearTxt()
        {
            this.txtHijo.Text = "";
            this.txtPadre.Text = "";
            this.id_hijo = "";
            this.id_padre = "";
            this.tipo = 'v';
        }
        #endregion

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Load_DataTable(2);
            this.tipo = 'P';
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            Load_DataTable(1);
            this.tipo = 'M';
        }

        private void tvArbol_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                txtPadre.Text = tvArbol.SelectedNode.Name;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error"+ex);
                return;
            }
        }

    }
}
