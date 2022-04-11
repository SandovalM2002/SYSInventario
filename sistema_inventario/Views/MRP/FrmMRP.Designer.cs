
namespace Views.MRP
{
    partial class FrmMRP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbMRP = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlData = new System.Windows.Forms.Panel();
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.gBData = new System.Windows.Forms.GroupBox();
            this.dgvNodos = new System.Windows.Forms.DataGridView();
            this.btnSend = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd_sub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbtProducto = new System.Windows.Forms.RadioButton();
            this.rbtMaterial = new System.Windows.Forms.RadioButton();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.dgvExplosion = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnExplosion = new System.Windows.Forms.Button();
            this.Padre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbMRP.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.gBData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExplosion)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMRP
            // 
            this.tbMRP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMRP.Controls.Add(this.tabPage1);
            this.tbMRP.Controls.Add(this.tabPage2);
            this.tbMRP.Location = new System.Drawing.Point(5, 12);
            this.tbMRP.Name = "tbMRP";
            this.tbMRP.SelectedIndex = 0;
            this.tbMRP.Size = new System.Drawing.Size(895, 625);
            this.tbMRP.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlData);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(887, 593);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MRP-S         ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExplosion);
            this.tabPage2.Controls.Add(this.dgvExplosion);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(887, 593);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MRP-E         ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.btnGuardar);
            this.pnlData.Controls.Add(this.btnSend);
            this.pnlData.Controls.Add(this.dgvNodos);
            this.pnlData.Controls.Add(this.gBData);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Controls.Add(this.tvArbol);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(3, 3);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(881, 587);
            this.pnlData.TabIndex = 0;
            // 
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(29, 50);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(254, 244);
            this.tvArbol.TabIndex = 0;
            this.tvArbol.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvArbol_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arbol MRP";
            // 
            // gBData
            // 
            this.gBData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBData.Controls.Add(this.txtSelect);
            this.gBData.Controls.Add(this.rbtMaterial);
            this.gBData.Controls.Add(this.rbtProducto);
            this.gBData.Controls.Add(this.btnAdd);
            this.gBData.Controls.Add(this.btnAdd_sub);
            this.gBData.Controls.Add(this.btnUpdate);
            this.gBData.Controls.Add(this.btnDelete);
            this.gBData.Controls.Add(this.dgvDatos);
            this.gBData.Location = new System.Drawing.Point(29, 310);
            this.gBData.Name = "gBData";
            this.gBData.Size = new System.Drawing.Size(831, 260);
            this.gBData.TabIndex = 2;
            this.gBData.TabStop = false;
            this.gBData.Text = "Datos Para el Mrp";
            // 
            // dgvNodos
            // 
            this.dgvNodos.AllowUserToAddRows = false;
            this.dgvNodos.AllowUserToDeleteRows = false;
            this.dgvNodos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNodos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Padre,
            this.Hijo});
            this.dgvNodos.Location = new System.Drawing.Point(457, 50);
            this.dgvNodos.Name = "dgvNodos";
            this.dgvNodos.ReadOnly = true;
            this.dgvNodos.Size = new System.Drawing.Size(403, 244);
            this.dgvNodos.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(329, 120);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(83, 45);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "--->";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(28, 66);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(780, 180);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(705, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 39);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(596, 21);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 39);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd_sub
            // 
            this.btnAdd_sub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd_sub.Location = new System.Drawing.Point(487, 21);
            this.btnAdd_sub.Name = "btnAdd_sub";
            this.btnAdd_sub.Size = new System.Drawing.Size(103, 39);
            this.btnAdd_sub.TabIndex = 3;
            this.btnAdd_sub.Text = "Agregar Sub";
            this.btnAdd_sub.UseVisualStyleBackColor = true;
            this.btnAdd_sub.Click += new System.EventHandler(this.btnAdd_sub_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(378, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbtProducto
            // 
            this.rbtProducto.AutoSize = true;
            this.rbtProducto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbtProducto.Location = new System.Drawing.Point(28, 29);
            this.rbtProducto.Name = "rbtProducto";
            this.rbtProducto.Size = new System.Drawing.Size(90, 24);
            this.rbtProducto.TabIndex = 5;
            this.rbtProducto.Text = "Producto";
            this.rbtProducto.UseVisualStyleBackColor = true;
            this.rbtProducto.CheckedChanged += new System.EventHandler(this.rbtProducto_CheckedChanged);
            // 
            // rbtMaterial
            // 
            this.rbtMaterial.AutoSize = true;
            this.rbtMaterial.Checked = true;
            this.rbtMaterial.Location = new System.Drawing.Point(142, 29);
            this.rbtMaterial.Name = "rbtMaterial";
            this.rbtMaterial.Size = new System.Drawing.Size(77, 23);
            this.rbtMaterial.TabIndex = 6;
            this.rbtMaterial.TabStop = true;
            this.rbtMaterial.Text = "Material";
            this.rbtMaterial.UseVisualStyleBackColor = true;
            this.rbtMaterial.CheckedChanged += new System.EventHandler(this.rbtMaterial_CheckedChanged);
            // 
            // txtSelect
            // 
            this.txtSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelect.Enabled = false;
            this.txtSelect.Location = new System.Drawing.Point(225, 29);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(137, 25);
            this.txtSelect.TabIndex = 7;
            // 
            // dgvExplosion
            // 
            this.dgvExplosion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExplosion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExplosion.Location = new System.Drawing.Point(40, 98);
            this.dgvExplosion.Name = "dgvExplosion";
            this.dgvExplosion.Size = new System.Drawing.Size(795, 475);
            this.dgvExplosion.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(329, 181);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 45);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnExplosion
            // 
            this.btnExplosion.Location = new System.Drawing.Point(40, 30);
            this.btnExplosion.Name = "btnExplosion";
            this.btnExplosion.Size = new System.Drawing.Size(131, 38);
            this.btnExplosion.TabIndex = 1;
            this.btnExplosion.Text = "EXPLOSION";
            this.btnExplosion.UseVisualStyleBackColor = true;
            // 
            // Padre
            // 
            this.Padre.HeaderText = "Padre";
            this.Padre.Name = "Padre";
            // 
            // Hijo
            // 
            this.Hijo.HeaderText = "Hijo";
            this.Hijo.Name = "Hijo";
            // 
            // FrmMRP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(905, 649);
            this.Controls.Add(this.tbMRP);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmMRP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMRP";
            this.Load += new System.EventHandler(this.FrmMRP_Load);
            this.tbMRP.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.gBData.ResumeLayout(false);
            this.gBData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExplosion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbMRP;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.GroupBox gBData;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.DataGridView dgvNodos;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnAdd_sub;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rbtMaterial;
        private System.Windows.Forms.RadioButton rbtProducto;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvExplosion;
        private System.Windows.Forms.Button btnExplosion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Padre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hijo;
    }
}