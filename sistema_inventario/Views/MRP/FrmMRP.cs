﻿using DataAcces;
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
        private string _id_padre;
        private string _id_hijo;
        private char tipo;
        public DataSet dtsN = null;

        public FrmMRP()
        {
            InitializeComponent();
            dtsN = new DataSet();
        }

        private void FrmMRP_Load(object sender, EventArgs e)
        {
            CargarDataSQL();
            dgvDatos.DataSource = null;
            if (rbtProducto.Checked.Equals(true))
            {
                dgvDatos.DataSource = C_Producto.view_search_producto("");
            }
            else if (rbtMaterial.Checked.Equals(true))
            {
                dgvDatos.DataSource = C_Material.view_search_Material("");
            }

            dgvMRP.DataSource = null;
            dgvMRP.DataSource = C_Nodo.View_Nodo();
        }

        private void rbtProducto_CheckedChanged(object sender, EventArgs e)
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = C_Producto.view_search_producto("");
            this.tipo = 'P';
        }

        private void rbtMaterial_CheckedChanged(object sender, EventArgs e)
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = C_Material.view_search_Material("");
            this.tipo = 'M';
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this._row = e.RowIndex;
                this.txtProducto.Text = dgvDatos.Rows[_row].Cells["Nombre"].Value.ToString();
                if (tipo.Equals("P"))
                {
                    this._id_padre = 0.ToString();
                    this._id_hijo =  dgvDatos.Rows[_row].Cells["Cod"].Value.ToString();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_sub_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
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
    }
}
