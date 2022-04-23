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
        private string id_nodo;
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
            CargarDataSQL();
            Tablas();
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    if (rbtPadre.Checked.Equals(true))
                    {
                        this.id_padre = dgvDatos.Rows[e.RowIndex].Cells["Cod"].Value.ToString();
                        this.txtPadre.Text = dgvDatos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

                    }
                    else if (rbtHijo.Checked.Equals(true))
                    {
                        this.id_hijo = dgvDatos.Rows[e.RowIndex].Cells["Cod"].Value.ToString();
                        this.txtHijo.Text = dgvDatos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void dgvMRP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clear_Box();
            try
            {
                if (e.RowIndex > -1)
                {
                    this.id_mrp = dgvMRP.Rows[e.RowIndex].Cells["Cod"].Value.ToString();
                    this.txtId.Text = dgvMRP.Rows[e.RowIndex].Cells["Cod"].Value.ToString();
                    this.id_hijo = dgvMRP.Rows[e.RowIndex].Cells["Hijo"].Value.ToString();
                    this.txtHijo.Text = dgvMRP.Rows[e.RowIndex].Cells["Descripción"].Value.ToString();
                    this.txtPadre.Text = dgvMRP.Rows[e.RowIndex].Cells["Padre"].Value.ToString();
                    this.txtCant.Value = Convert.ToInt32(dgvMRP.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());
                    this.txtPeriodos.Value = Convert.ToInt32(dgvMRP.Rows[e.RowIndex].Cells["Periodos"].Value.ToString());     
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        #region "METODOS NODO"
        public void CargarDataSQL()
        {
            try
            {
                dtsN = C_Nodo.CargarNodos();
                CrearNodosDelPadre(0, null);
                CrearNodosExplosion(0, null);
                tvArbol.ExpandAll();
                tvExplosion.ExpandAll();
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
            try
            {
                // Crear un DataView con los Nodos que dependen del Nodo padre pasado como parámetro.
                DataView dataViewHijos = new DataView(dtsN.Tables["Nodo"]);
                dataViewHijos.RowFilter = dtsN.Tables["Nodo"].Columns["Padre"].ColumnName + " = " + indicePadre;

                // Agregar al TreeView los nodos Hijos que se han obtenido.
                foreach (DataRowView dataRowCurrent in dataViewHijos)
                {
                    TreeNode nuevoNodo = new TreeNode();
                    nuevoNodo.Text = dataRowCurrent["Descripción"].ToString().Trim();   //Dato a mostrar
                    nuevoNodo.Name = dataRowCurrent["Hijo"].ToString().Trim();  //Valor guardado en le nombre 

                    // si el parámetro nodoPadre es nulo es porque es la primera llamada, son los Nodos
                    // del primer nivel que no dependen de otro nodo.
                    if (nodePadre == null)
                    {
                        tvArbol.Nodes.Add(nuevoNodo);
                    }
                    else
                        nodePadre.Nodes.Add(nuevoNodo); // se añade el nuevo nodo al nodo padre.

                    // Llamada recurrente al mismo método para agregar los Hijos del Nodo recién agregado.
                    CrearNodosDelPadre(Int32.Parse(dataRowCurrent["Hijo"].ToString()), nuevoNodo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        
        private void CrearNodosExplosion(int indicePadre, TreeNode nodePadre)
        {
            try
            {
                // Crear un DataView con los Nodos que dependen del Nodo padre pasado como parámetro.
                DataView dataViewHijos = new DataView(dtsN.Tables["Nodo"]);
                dataViewHijos.RowFilter = dtsN.Tables["Nodo"].Columns["Padre"].ColumnName + " = " + indicePadre;

                // Agregar al TreeView los nodos Hijos que se han obtenido.
                foreach (DataRowView dataRowCurrent in dataViewHijos)
                {
                    TreeNode nuevoNodo = new TreeNode();
                    nuevoNodo.Text = dataRowCurrent["Descripción"].ToString().Trim();   //Dato a mostrar
                    nuevoNodo.Name = dataRowCurrent["Cod"].ToString().Trim();  //Valor guardado en le nombre 

                    // si el parámetro nodoPadre es nulo es porque es la primera llamada, son los Nodos
                    // del primer nivel que no dependen de otro nodo.
                    if (nodePadre == null)
                    {
                        tvExplosion.Nodes.Add(nuevoNodo);
                    }
                    else
                        nodePadre.Nodes.Add(nuevoNodo); // se añade el nuevo nodo al nodo padre.

                    // Llamada recurrente al mismo método para agregar los Hijos del Nodo recién agregado.
                    CrearNodosExplosion(Int32.Parse(dataRowCurrent["Hijo"].ToString()), nuevoNodo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        #endregion
        public static string getFrameName()
        {
            return "MRP";
        }

        public void Tablas()
        {
            dgvDatos.DataSource = null;
            dgvMRP.DataSource = null;

            dgvDatos.DataSource = C_Stock.view_stock("");
            dgvMRP.DataSource = C_Nodo.view();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            C_Nodo.Insert(id_padre, id_hijo,Convert.ToInt32(txtCant.Value),Convert.ToInt32(txtPeriodos.Value));
            Clear_Box();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            C_Nodo.update(id_mrp,Convert.ToInt32(txtCant.Value), Convert.ToInt32(txtPeriodos.Value));
            Clear_Box();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            C_Nodo.delete(txtId.Text);
            Clear_Box();
        }

        private void Clear_Box()
        {
            txtId.Text = "";
            txtPadre.Text = "";
            txtCant.Value = 0;
            txtPeriodos.Value = 0;
            txtHijo.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear_Box();
        }

        private void tvExplosion_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                id_nodo = tvExplosion.SelectedNode.Name;
                txtExplosion.Text = tvExplosion.SelectedNode.Text;
                MessageBox.Show(id_nodo);
            }catch(Exception ex)
            {
                MessageBox.Show("Error"+ex.Message);
                return;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvExplosion.DataSource = null;
            C_Explosion.Insert(Convert.ToInt32(id_nodo));
            dgvExplosion.DataSource = C_Explosion.view(Convert.ToInt32(id_nodo));
        }
    }
}
