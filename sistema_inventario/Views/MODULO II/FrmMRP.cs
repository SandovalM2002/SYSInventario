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
                tvArbol.Nodes.Clear();
                tvExplosion.Nodes.Clear();

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
            if (id_padre == id_hijo)
            {
                MessageBox.Show("Error");
                return;
            }

            C_Nodo.Insert(id_padre, id_hijo,Convert.ToInt32(txtCant.Value),Convert.ToInt32(txtPeriodos.Value));
            Clear_Box();
            Tablas();
            CargarDataSQL();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            C_Nodo.update(id_mrp,Convert.ToInt32(txtCant.Value), Convert.ToInt32(txtPeriodos.Value));
            Clear_Box();
            Tablas();
            CargarDataSQL();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            C_Nodo.delete(txtId.Text);
            Clear_Box();
            Tablas();
            CargarDataSQL();
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
            try
            {
                dgvExplosion.DataSource = null;
                C_Explosion.Insert(Convert.ToInt32(id_nodo));
                dgvExplosion.DataSource = C_Explosion.view(Convert.ToInt32(id_nodo));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGenerar_Periodos_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPeriodo_TL.Text))
                {
                    MessageBox.Show("No debe dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                int periodos = int.Parse(txtPeriodo_TL.Text);
                dgvTL_Datos.RowCount = 1;
                dgvTL_Datos.ColumnCount = periodos;

                dgvTL_Datos.Rows[0].HeaderCell.Value = "Demanda";

                for (int i = 0; i < periodos; i++)
                {
                    dgvTL_Datos.Columns[i].Name = "Periodo " + (i + 1);
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Ha ocurido un error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurido un error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateGrid()
        {
            for (int i = 0; i < dgvTL_Datos.RowCount - 1; i++)
            {
                for (int j = 0; j < dgvTL_Datos.ColumnCount; j++)
                {
                    if (dgvTL_Datos.Rows[i].Cells[j].Value == null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void txtCalcular_TamanoLote_Click(object sender, EventArgs e)
        {
            if (ValidateGrid().Equals(true))
            {
                MessageBox.Show("Debe ingresar datos a la tabla, debe poner ceros si no hay dato");
                return;
            }

            Lote_Lote(float.Parse(txtCosto_Producto.Text),Costo_H(),float.Parse(txtS.Text));
            EOQ(float.Parse(txtCosto_Producto.Text), Costo_H(), float.Parse(txtS.Text));
        }

        private void Lote_Lote(float costo, float H, float S)
        {
            //PERIODO  DEMANDA PRODUCCION INV.F H S CT

            double CostoT = 0;

            dgvLxL.ColumnCount = 7;
            dgvLxL.RowCount = dgvTL_Datos.Columns.Count;


            dgvLxL.Columns[0].Name = "Periodo";
            dgvLxL.Columns[1].Name = "Demanda";
            dgvLxL.Columns[2].Name = "Producción";
            dgvLxL.Columns[3].Name = "Inv.Final";
            dgvLxL.Columns[4].Name = "H";
            dgvLxL.Columns[5].Name = "S";
            dgvLxL.Columns[6].Name = "CT";

            for (int i = 0; i < dgvTL_Datos.Columns.Count; i++)
            {
                dgvLxL.Rows[i].Cells[0].Value = i + 1;
                dgvLxL.Rows[i].Cells[1].Value = dgvTL_Datos.Rows[0].Cells[i].Value;
                dgvLxL.Rows[i].Cells[2].Value = dgvTL_Datos.Rows[0].Cells[i].Value;
                dgvLxL.Rows[i].Cells[3].Value = 0;
                dgvLxL.Rows[i].Cells[4].Value = 0;
                dgvLxL.Rows[i].Cells[5].Value = S;
                
                if (i != 0)
                {
                    dgvLxL.Rows[i].Cells[6].Value = S + float.Parse(dgvLxL.Rows[i-1].Cells[6].Value.ToString());
                }
                else if(i == 0) {
                    dgvLxL.Rows[i].Cells[6].Value = S;
                }
            }
            CostoT =  double.Parse( dgvLxL.Rows[dgvTL_Datos.Columns.Count - 1].Cells[6].Value.ToString());
        }

        private void EOQ(float costo, float H, float S)
        {
            float acumulada = 0;

            for (int i = 0; i < dgvTL_Datos.Columns.Count; i++)
            {
                acumulada += int.Parse(dgvTL_Datos.Rows[0].Cells[i].Value.ToString());
            }

            float D = Demanda_Anual(acumulada)/ dgvTL_Datos.Columns.Count;

            double EOQ = Math.Sqrt((2*D*S)/(Cantidad_H(H)));

            dgvEOQ.ColumnCount = 7;
            dgvEOQ.RowCount = dgvTL_Datos.Columns.Count;

            dgvEOQ.Columns[0].Name = "Periodo";
            dgvEOQ.Columns[1].Name = "Demanda";
            dgvEOQ.Columns[2].Name = "Producción";
            dgvEOQ.Columns[3].Name = "Inv.Final";
            dgvEOQ.Columns[4].Name = "H";
            dgvEOQ.Columns[5].Name = "S";
            dgvEOQ.Columns[6].Name = "CT";

            for (int i = 0; i < dgvTL_Datos.Columns.Count; i++)
            {
                dgvEOQ.Rows[i].Cells[0].Value = i + 1;//PERIODO
                dgvEOQ.Rows[i].Cells[1].Value = dgvTL_Datos.Rows[0].Cells[i].Value;//DEMANDA

                if (i != 0)
                {
                    int IF_A = int.Parse(dgvEOQ.Rows[i-1].Cells[3].Value.ToString());
                    int Demanda = int.Parse(dgvEOQ.Rows[i].Cells[1].Value.ToString());
                    float CT = 0;

                    if (IF_A < Demanda ) 
                    {
                        dgvEOQ.Rows[i].Cells[2].Value = Convert.ToInt32(EOQ); //PRODUCCION
                        dgvEOQ.Rows[i].Cells[3].Value = IF_A + Convert.ToInt32(EOQ) - Demanda;//INV FINAL
                        dgvEOQ.Rows[i].Cells[5].Value = S; //S
                        CT += S;
                    }
                    else if(IF_A >= Demanda)
                    {
                        dgvEOQ.Rows[i].Cells[2].Value = 0; //PRODUCCION
                        dgvEOQ.Rows[i].Cells[3].Value = IF_A - Demanda; // INV FINAL
                        dgvEOQ.Rows[i].Cells[5].Value = 0; //S
                        CT += 0;
                    }
                    
                    float CH = H * float.Parse(dgvEOQ.Rows[i].Cells[3].Value.ToString());
                    dgvEOQ.Rows[i].Cells[4].Value = CH; // H

                    CT += CH;

                    dgvEOQ.Rows[i].Cells[6].Value = float.Parse(dgvEOQ.Rows[i - 1].Cells[6].Value.ToString()) + CT;
                }
                else if (i == 0)
                {
                    dgvEOQ.Rows[i].Cells[2].Value = Convert.ToInt32(EOQ); //PRODUCCION
                    dgvEOQ.Rows[i].Cells[3].Value = Convert.ToInt32(EOQ) -  int.Parse(dgvTL_Datos.Rows[0].Cells[i].Value.ToString()); // INV FINAL
                    dgvEOQ.Rows[i].Cells[4].Value = H * float.Parse(dgvEOQ.Rows[i].Cells[3].Value.ToString()); // H
                    dgvEOQ.Rows[i].Cells[5].Value = S; //S
                    dgvEOQ.Rows[i].Cells[6].Value = float.Parse(dgvEOQ.Rows[i].Cells[4].Value.ToString()) + float.Parse(dgvEOQ.Rows[i].Cells[5].Value.ToString()); //CT
                }
            }
        }

        private float Demanda_Anual(float acumulada) 
        {
           float result = 0;
           //semanal
            if(cmbCH.SelectedIndex == 0) 
            {
                result = acumulada * 52;
            }
            //mensual
            else if (cmbCH.SelectedIndex == 1)
            {
                result = acumulada * 12;
            }
            //anual
            else if (cmbCH.SelectedIndex == 2)
            {
                result = acumulada;
            }
            return result;
        }

        private float Costo_H()
        {
            float result = 0;
            if (rbtPorcentual.Checked)
            {
               result = (float.Parse(txtCosto_Mantenimiento.Text)/100) * float.Parse(txtCosto_Producto.Text);
            }
            else if (rbtH.Checked)
            {
                result = float.Parse(txtCosto_Mantenimiento.Text);
            }

            return result;
        }

        private float Cantidad_H (float H)
        {
            float result = 0;
            //semanal
            if (cmbTipo_Demanda.SelectedIndex == 0)
            {
                result = H * 52;
            }
            //mensual
            else if (cmbTipo_Demanda.SelectedIndex == 1)
            {
                result = H * 12;
            }
            //anual
            else if (cmbTipo_Demanda.SelectedIndex == 2)
            {
                result = H;
            }

            return result;
        }
    }
}

