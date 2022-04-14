
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
            this.pnlData = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMRP = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtMRP = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gBData = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtHijo = new System.Windows.Forms.RadioButton();
            this.rbtPadre = new System.Windows.Forms.RadioButton();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHijo = new System.Windows.Forms.TextBox();
            this.txtPadre = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExplosion = new System.Windows.Forms.Button();
            this.dgvExplosion = new System.Windows.Forms.DataGridView();
            this.btnSubAdd = new System.Windows.Forms.Button();
            this.tbMRP.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMRP)).BeginInit();
            this.gBData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            this.tbMRP.Size = new System.Drawing.Size(917, 735);
            this.tbMRP.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlData);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(909, 703);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MRP-S         ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.label4);
            this.pnlData.Controls.Add(this.dgvMRP);
            this.pnlData.Controls.Add(this.btnDelete);
            this.pnlData.Controls.Add(this.txtMRP);
            this.pnlData.Controls.Add(this.btnUpdate);
            this.pnlData.Controls.Add(this.gBData);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Controls.Add(this.tvArbol);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlData.Location = new System.Drawing.Point(3, 3);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(903, 697);
            this.pnlData.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Elemento Seleccionado:";
            // 
            // dgvMRP
            // 
            this.dgvMRP.AllowUserToAddRows = false;
            this.dgvMRP.AllowUserToDeleteRows = false;
            this.dgvMRP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMRP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMRP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMRP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMRP.Location = new System.Drawing.Point(395, 87);
            this.dgvMRP.Name = "dgvMRP";
            this.dgvMRP.ReadOnly = true;
            this.dgvMRP.Size = new System.Drawing.Size(488, 246);
            this.dgvMRP.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(800, 46);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 27);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtMRP
            // 
            this.txtMRP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMRP.Enabled = false;
            this.txtMRP.Location = new System.Drawing.Point(395, 48);
            this.txtMRP.Name = "txtMRP";
            this.txtMRP.Size = new System.Drawing.Size(310, 23);
            this.txtMRP.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(711, 46);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 27);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gBData
            // 
            this.gBData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBData.Controls.Add(this.btnSubAdd);
            this.gBData.Controls.Add(this.label3);
            this.gBData.Controls.Add(this.rbtHijo);
            this.gBData.Controls.Add(this.rbtPadre);
            this.gBData.Controls.Add(this.btnMaterial);
            this.gBData.Controls.Add(this.btnProducto);
            this.gBData.Controls.Add(this.label2);
            this.gBData.Controls.Add(this.txtHijo);
            this.gBData.Controls.Add(this.txtPadre);
            this.gBData.Controls.Add(this.btnAdd);
            this.gBData.Controls.Add(this.dgvDatos);
            this.gBData.Location = new System.Drawing.Point(29, 339);
            this.gBData.Name = "gBData";
            this.gBData.Size = new System.Drawing.Size(854, 344);
            this.gBData.TabIndex = 2;
            this.gBData.TabStop = false;
            this.gBData.Text = "Datos Para el Mrp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(231, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Agregar un Nodo:";
            // 
            // rbtHijo
            // 
            this.rbtHijo.AutoSize = true;
            this.rbtHijo.Location = new System.Drawing.Point(234, 90);
            this.rbtHijo.Name = "rbtHijo";
            this.rbtHijo.Size = new System.Drawing.Size(90, 21);
            this.rbtHijo.TabIndex = 17;
            this.rbtHijo.TabStop = true;
            this.rbtHijo.Text = "Nodo Hijo:";
            this.rbtHijo.UseVisualStyleBackColor = true;
            // 
            // rbtPadre
            // 
            this.rbtPadre.AutoSize = true;
            this.rbtPadre.Location = new System.Drawing.Point(234, 56);
            this.rbtPadre.Name = "rbtPadre";
            this.rbtPadre.Size = new System.Drawing.Size(101, 21);
            this.rbtPadre.TabIndex = 16;
            this.rbtPadre.TabStop = true;
            this.rbtPadre.Text = "Nodo Padre:";
            this.rbtPadre.UseVisualStyleBackColor = true;
            // 
            // btnMaterial
            // 
            this.btnMaterial.Location = new System.Drawing.Point(28, 88);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(111, 27);
            this.btnMaterial.TabIndex = 15;
            this.btnMaterial.Text = "Material";
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Location = new System.Drawing.Point(28, 53);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(111, 27);
            this.btnProducto.TabIndex = 14;
            this.btnProducto.Text = "Producto";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(25, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ver Datos por:";
            // 
            // txtHijo
            // 
            this.txtHijo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHijo.Enabled = false;
            this.txtHijo.Location = new System.Drawing.Point(342, 88);
            this.txtHijo.Name = "txtHijo";
            this.txtHijo.Size = new System.Drawing.Size(266, 23);
            this.txtHijo.TabIndex = 10;
            // 
            // txtPadre
            // 
            this.txtPadre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPadre.Enabled = false;
            this.txtPadre.Location = new System.Drawing.Point(342, 56);
            this.txtPadre.Name = "txtPadre";
            this.txtPadre.Size = new System.Drawing.Size(266, 23);
            this.txtPadre.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(682, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 31);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.dgvDatos.Location = new System.Drawing.Point(28, 132);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(798, 187);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arbol MRP";
            // 
            // tvArbol
            // 
            this.tvArbol.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvArbol.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tvArbol.Location = new System.Drawing.Point(29, 50);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(303, 283);
            this.tvArbol.TabIndex = 0;
            this.tvArbol.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvArbol_AfterSelect);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExplosion);
            this.tabPage2.Controls.Add(this.dgvExplosion);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(909, 709);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MRP-E         ";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // dgvExplosion
            // 
            this.dgvExplosion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExplosion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExplosion.Location = new System.Drawing.Point(40, 98);
            this.dgvExplosion.Name = "dgvExplosion";
            this.dgvExplosion.Size = new System.Drawing.Size(795, 469);
            this.dgvExplosion.TabIndex = 0;
            // 
            // btnSubAdd
            // 
            this.btnSubAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubAdd.Location = new System.Drawing.Point(682, 88);
            this.btnSubAdd.Name = "btnSubAdd";
            this.btnSubAdd.Size = new System.Drawing.Size(144, 27);
            this.btnSubAdd.TabIndex = 19;
            this.btnSubAdd.Text = "Agregar Sub Nodo";
            this.btnSubAdd.UseVisualStyleBackColor = true;
            this.btnSubAdd.Click += new System.EventHandler(this.btnSubAdd_Click);
            // 
            // FrmMRP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(927, 759);
            this.Controls.Add(this.tbMRP);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmMRP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMRP";
            this.Load += new System.EventHandler(this.FrmMRP_Load);
            this.tbMRP.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMRP)).EndInit();
            this.gBData.ResumeLayout(false);
            this.gBData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.tabPage2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvExplosion;
        private System.Windows.Forms.Button btnExplosion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMRP;
        private System.Windows.Forms.DataGridView dgvMRP;
        private System.Windows.Forms.GroupBox gBData;
        private System.Windows.Forms.TextBox txtHijo;
        private System.Windows.Forms.TextBox txtPadre;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.RadioButton rbtHijo;
        private System.Windows.Forms.RadioButton rbtPadre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubAdd;
    }
}