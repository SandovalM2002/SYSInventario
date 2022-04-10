﻿
namespace Views.INVENTARIO
{
    partial class FrmStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblLine = new System.Windows.Forms.Label();
            this.imgFrame = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tbLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlUp = new System.Windows.Forms.Panel();
            this.btnDesactivar_P = new System.Windows.Forms.Button();
            this.btnAdd_P = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch_P = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.btnUpdate_P = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFrame)).BeginInit();
            this.pnlCenter.SuspendLayout();
            this.tbLayout.SuspendLayout();
            this.pnlUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduct.CausesValidation = false;
            this.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProduct.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvProduct.ColumnHeadersHeight = 42;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvProduct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.dgvProduct.Location = new System.Drawing.Point(10, 94);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 56;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(105)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProduct.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(905, 220);
            this.dgvProduct.TabIndex = 1;
            this.dgvProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellDoubleClick);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(105)))), ((int)(((byte)(248)))));
            this.pnlTitle.Controls.Add(this.lblLine);
            this.pnlTitle.Controls.Add(this.imgFrame);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(944, 55);
            this.pnlTitle.TabIndex = 1;
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.lblLine.Location = new System.Drawing.Point(68, 4);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(3, 45);
            this.lblLine.TabIndex = 2;
            // 
            // imgFrame
            // 
            this.imgFrame.Image = global::Views.Properties.Resources.Inventory;
            this.imgFrame.Location = new System.Drawing.Point(12, 8);
            this.imgFrame.Name = "imgFrame";
            this.imgFrame.Size = new System.Drawing.Size(50, 41);
            this.imgFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFrame.TabIndex = 1;
            this.imgFrame.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(77, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Gestión de Inventario";
            // 
            // pnlCenter
            // 
            this.pnlCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.pnlCenter.Controls.Add(this.tbLayout);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 55);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(944, 680);
            this.pnlCenter.TabIndex = 2;
            // 
            // tbLayout
            // 
            this.tbLayout.ColumnCount = 1;
            this.tbLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLayout.Controls.Add(this.pnlUp, 0, 0);
            this.tbLayout.Controls.Add(this.pnlDown, 0, 1);
            this.tbLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLayout.Location = new System.Drawing.Point(0, 0);
            this.tbLayout.Name = "tbLayout";
            this.tbLayout.RowCount = 2;
            this.tbLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLayout.Size = new System.Drawing.Size(944, 680);
            this.tbLayout.TabIndex = 0;
            // 
            // pnlUp
            // 
            this.pnlUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUp.BackColor = System.Drawing.Color.Transparent;
            this.pnlUp.Controls.Add(this.btnDesactivar_P);
            this.pnlUp.Controls.Add(this.btnUpdate_P);
            this.pnlUp.Controls.Add(this.btnAdd_P);
            this.pnlUp.Controls.Add(this.pictureBox1);
            this.pnlUp.Controls.Add(this.txtSearch_P);
            this.pnlUp.Controls.Add(this.dgvProduct);
            this.pnlUp.Controls.Add(this.lblProducto);
            this.pnlUp.Location = new System.Drawing.Point(3, 3);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(938, 334);
            this.pnlUp.TabIndex = 0;
            // 
            // btnDesactivar_P
            // 
            this.btnDesactivar_P.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesactivar_P.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.btnDesactivar_P.FlatAppearance.BorderSize = 0;
            this.btnDesactivar_P.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.btnDesactivar_P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivar_P.ForeColor = System.Drawing.Color.White;
            this.btnDesactivar_P.Location = new System.Drawing.Point(603, 55);
            this.btnDesactivar_P.Name = "btnDesactivar_P";
            this.btnDesactivar_P.Size = new System.Drawing.Size(100, 33);
            this.btnDesactivar_P.TabIndex = 5;
            this.btnDesactivar_P.Text = "Desactivar";
            this.btnDesactivar_P.UseVisualStyleBackColor = false;
            // 
            // btnAdd_P
            // 
            this.btnAdd_P.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd_P.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.btnAdd_P.FlatAppearance.BorderSize = 0;
            this.btnAdd_P.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.btnAdd_P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_P.ForeColor = System.Drawing.Color.White;
            this.btnAdd_P.Location = new System.Drawing.Point(815, 55);
            this.btnAdd_P.Name = "btnAdd_P";
            this.btnAdd_P.Size = new System.Drawing.Size(100, 33);
            this.btnAdd_P.TabIndex = 0;
            this.btnAdd_P.Text = "Agregar";
            this.btnAdd_P.UseVisualStyleBackColor = false;
            this.btnAdd_P.Click += new System.EventHandler(this.btnAdd_P_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Views.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(10, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearch_P
            // 
            this.txtSearch_P.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch_P.Location = new System.Drawing.Point(50, 59);
            this.txtSearch_P.Name = "txtSearch_P";
            this.txtSearch_P.Size = new System.Drawing.Size(528, 25);
            this.txtSearch_P.TabIndex = 2;
            this.txtSearch_P.TextChanged += new System.EventHandler(this.txtSearch_P_TextChanged);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblProducto.Location = new System.Drawing.Point(6, 9);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(107, 19);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Info Productos";
            // 
            // pnlDown
            // 
            this.pnlDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDown.Controls.Add(this.lblMaterial);
            this.pnlDown.Location = new System.Drawing.Point(3, 343);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(938, 334);
            this.pnlDown.TabIndex = 1;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblMaterial.Location = new System.Drawing.Point(9, 9);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(109, 19);
            this.lblMaterial.TabIndex = 1;
            this.lblMaterial.Text = "Info Materiales";
            // 
            // btnUpdate_P
            // 
            this.btnUpdate_P.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate_P.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.btnUpdate_P.FlatAppearance.BorderSize = 0;
            this.btnUpdate_P.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.btnUpdate_P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate_P.ForeColor = System.Drawing.Color.White;
            this.btnUpdate_P.Location = new System.Drawing.Point(709, 55);
            this.btnUpdate_P.Name = "btnUpdate_P";
            this.btnUpdate_P.Size = new System.Drawing.Size(100, 33);
            this.btnUpdate_P.TabIndex = 4;
            this.btnUpdate_P.Text = "Modificar";
            this.btnUpdate_P.UseVisualStyleBackColor = false;
            // 
            // FrmStock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(944, 735);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFrame)).EndInit();
            this.pnlCenter.ResumeLayout(false);
            this.tbLayout.ResumeLayout(false);
            this.pnlUp.ResumeLayout(false);
            this.pnlUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDown.ResumeLayout(false);
            this.pnlDown.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.PictureBox imgFrame;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.TableLayoutPanel tbLayout;
        private System.Windows.Forms.Panel pnlUp;
        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.TextBox txtSearch_P;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdd_P;
        private System.Windows.Forms.Button btnDesactivar_P;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnUpdate_P;
    }
}