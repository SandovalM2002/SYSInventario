
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExplosion = new System.Windows.Forms.Button();
            this.dgvExplosion = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMRP = new System.Windows.Forms.TextBox();
            this.dgvMRP = new System.Windows.Forms.DataGridView();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbtProducto = new System.Windows.Forms.RadioButton();
            this.rbtMaterial = new System.Windows.Forms.RadioButton();
            this.btnAdd_sub = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gBData = new System.Windows.Forms.GroupBox();
            this.tbMRP.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExplosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMRP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.gBData.SuspendLayout();
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
            this.pnlData.Location = new System.Drawing.Point(3, 3);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(903, 697);
            this.pnlData.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(800, 40);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 27);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(711, 40);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 27);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            // tvArbol
            // 
            this.tvArbol.Enabled = false;
            this.tvArbol.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvArbol.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tvArbol.Location = new System.Drawing.Point(29, 50);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(303, 283);
            this.tvArbol.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExplosion);
            this.tabPage2.Controls.Add(this.dgvExplosion);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(815, 709);
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
            this.dgvExplosion.Size = new System.Drawing.Size(795, 475);
            this.dgvExplosion.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(391, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "MRP";
            // 
            // txtMRP
            // 
            this.txtMRP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMRP.Enabled = false;
            this.txtMRP.Location = new System.Drawing.Point(440, 41);
            this.txtMRP.Name = "txtMRP";
            this.txtMRP.Size = new System.Drawing.Size(253, 25);
            this.txtMRP.TabIndex = 12;
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
            this.dgvDatos.Location = new System.Drawing.Point(28, 108);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(798, 214);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(598, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 27);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbtProducto
            // 
            this.rbtProducto.AutoSize = true;
            this.rbtProducto.Checked = true;
            this.rbtProducto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbtProducto.Location = new System.Drawing.Point(28, 21);
            this.rbtProducto.Name = "rbtProducto";
            this.rbtProducto.Size = new System.Drawing.Size(90, 24);
            this.rbtProducto.TabIndex = 5;
            this.rbtProducto.TabStop = true;
            this.rbtProducto.Text = "Producto";
            this.rbtProducto.UseVisualStyleBackColor = true;
            this.rbtProducto.CheckedChanged += new System.EventHandler(this.rbtProducto_CheckedChanged);
            // 
            // rbtMaterial
            // 
            this.rbtMaterial.AutoSize = true;
            this.rbtMaterial.Location = new System.Drawing.Point(28, 56);
            this.rbtMaterial.Name = "rbtMaterial";
            this.rbtMaterial.Size = new System.Drawing.Size(77, 23);
            this.rbtMaterial.TabIndex = 6;
            this.rbtMaterial.Text = "Material";
            this.rbtMaterial.UseVisualStyleBackColor = true;
            this.rbtMaterial.CheckedChanged += new System.EventHandler(this.rbtMaterial_CheckedChanged);
            // 
            // btnAdd_sub
            // 
            this.btnAdd_sub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd_sub.Location = new System.Drawing.Point(715, 52);
            this.btnAdd_sub.Name = "btnAdd_sub";
            this.btnAdd_sub.Size = new System.Drawing.Size(111, 27);
            this.btnAdd_sub.TabIndex = 3;
            this.btnAdd_sub.Text = "Agregar Sub";
            this.btnAdd_sub.UseVisualStyleBackColor = true;
            this.btnAdd_sub.Click += new System.EventHandler(this.btnAdd_sub_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(263, 24);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(266, 25);
            this.txtProducto.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Producto";
            // 
            // txtMaterial
            // 
            this.txtMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaterial.Enabled = false;
            this.txtMaterial.Location = new System.Drawing.Point(263, 56);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(266, 25);
            this.txtMaterial.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Material";
            // 
            // gBData
            // 
            this.gBData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBData.Controls.Add(this.label3);
            this.gBData.Controls.Add(this.txtMaterial);
            this.gBData.Controls.Add(this.label2);
            this.gBData.Controls.Add(this.txtProducto);
            this.gBData.Controls.Add(this.btnAdd_sub);
            this.gBData.Controls.Add(this.rbtMaterial);
            this.gBData.Controls.Add(this.rbtProducto);
            this.gBData.Controls.Add(this.btnAdd);
            this.gBData.Controls.Add(this.dgvDatos);
            this.gBData.Location = new System.Drawing.Point(29, 339);
            this.gBData.Name = "gBData";
            this.gBData.Size = new System.Drawing.Size(854, 341);
            this.gBData.TabIndex = 2;
            this.gBData.TabStop = false;
            this.gBData.Text = "Datos Para el Mrp";
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
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExplosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMRP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.gBData.ResumeLayout(false);
            this.gBData.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button btnAdd_sub;
        private System.Windows.Forms.RadioButton rbtMaterial;
        private System.Windows.Forms.RadioButton rbtProducto;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}