
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblLine = new System.Windows.Forms.Label();
            this.imgFrame = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.tbLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlUp = new System.Windows.Forms.Panel();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.rbtDelete_P = new System.Windows.Forms.RadioButton();
            this.rbtUpdate_P = new System.Windows.Forms.RadioButton();
            this.rbtAdd_P = new System.Windows.Forms.RadioButton();
            this.btnSave_P = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearchProducto = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.lblProducto = new System.Windows.Forms.Label();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.gbMaterial = new System.Windows.Forms.GroupBox();
            this.rbtDelete_M = new System.Windows.Forms.RadioButton();
            this.rbtUpdate_M = new System.Windows.Forms.RadioButton();
            this.rbtAdd_M = new System.Windows.Forms.RadioButton();
            this.btnSave_M = new System.Windows.Forms.Button();
            this.dgvMateriales = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSearchMateriales = new System.Windows.Forms.TextBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFrame)).BeginInit();
            this.pnlCenter.SuspendLayout();
            this.tbLayout.SuspendLayout();
            this.pnlUp.SuspendLayout();
            this.gbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pnlDown.SuspendLayout();
            this.gbMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.pnlUp.Controls.Add(this.gbProducto);
            this.pnlUp.Controls.Add(this.pictureBox1);
            this.pnlUp.Controls.Add(this.txtSearchProducto);
            this.pnlUp.Controls.Add(this.dgvProductos);
            this.pnlUp.Controls.Add(this.lblProducto);
            this.pnlUp.Location = new System.Drawing.Point(3, 3);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(938, 334);
            this.pnlUp.TabIndex = 0;
            // 
            // gbProducto
            // 
            this.gbProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProducto.Controls.Add(this.rbtDelete_P);
            this.gbProducto.Controls.Add(this.rbtUpdate_P);
            this.gbProducto.Controls.Add(this.rbtAdd_P);
            this.gbProducto.Controls.Add(this.btnSave_P);
            this.gbProducto.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProducto.Location = new System.Drawing.Point(645, 59);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(270, 255);
            this.gbProducto.TabIndex = 4;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Acciones Producto";
            // 
            // rbtDelete_P
            // 
            this.rbtDelete_P.AutoSize = true;
            this.rbtDelete_P.Location = new System.Drawing.Point(24, 95);
            this.rbtDelete_P.Name = "rbtDelete_P";
            this.rbtDelete_P.Size = new System.Drawing.Size(108, 24);
            this.rbtDelete_P.TabIndex = 3;
            this.rbtDelete_P.TabStop = true;
            this.rbtDelete_P.Text = "Dar de Baja";
            this.rbtDelete_P.UseVisualStyleBackColor = true;
            // 
            // rbtUpdate_P
            // 
            this.rbtUpdate_P.AutoSize = true;
            this.rbtUpdate_P.Location = new System.Drawing.Point(24, 65);
            this.rbtUpdate_P.Name = "rbtUpdate_P";
            this.rbtUpdate_P.Size = new System.Drawing.Size(169, 24);
            this.rbtUpdate_P.TabIndex = 2;
            this.rbtUpdate_P.TabStop = true;
            this.rbtUpdate_P.Text = "Modificar Producto";
            this.rbtUpdate_P.UseVisualStyleBackColor = true;
            // 
            // rbtAdd_P
            // 
            this.rbtAdd_P.AutoSize = true;
            this.rbtAdd_P.Location = new System.Drawing.Point(24, 35);
            this.rbtAdd_P.Name = "rbtAdd_P";
            this.rbtAdd_P.Size = new System.Drawing.Size(159, 24);
            this.rbtAdd_P.TabIndex = 1;
            this.rbtAdd_P.TabStop = true;
            this.rbtAdd_P.Text = "Agregar Producto";
            this.rbtAdd_P.UseVisualStyleBackColor = true;
            // 
            // btnSave_P
            // 
            this.btnSave_P.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave_P.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.btnSave_P.FlatAppearance.BorderSize = 0;
            this.btnSave_P.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.btnSave_P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave_P.ForeColor = System.Drawing.Color.White;
            this.btnSave_P.Location = new System.Drawing.Point(24, 193);
            this.btnSave_P.Name = "btnSave_P";
            this.btnSave_P.Size = new System.Drawing.Size(218, 44);
            this.btnSave_P.TabIndex = 0;
            this.btnSave_P.Text = "Ejecutar";
            this.btnSave_P.UseVisualStyleBackColor = false;
            this.btnSave_P.Click += new System.EventHandler(this.btnSave_P_Click);
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
            // txtSearchProducto
            // 
            this.txtSearchProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchProducto.Location = new System.Drawing.Point(50, 59);
            this.txtSearchProducto.Name = "txtSearchProducto";
            this.txtSearchProducto.Size = new System.Drawing.Size(566, 25);
            this.txtSearchProducto.TabIndex = 2;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToOrderColumns = true;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CausesValidation = false;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeight = 42;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.dgvProductos.Location = new System.Drawing.Point(10, 94);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 56;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(105)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(606, 220);
            this.dgvProductos.TabIndex = 1;
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
            this.pnlDown.Controls.Add(this.gbMaterial);
            this.pnlDown.Controls.Add(this.dgvMateriales);
            this.pnlDown.Controls.Add(this.pictureBox2);
            this.pnlDown.Controls.Add(this.txtSearchMateriales);
            this.pnlDown.Controls.Add(this.lblMaterial);
            this.pnlDown.Location = new System.Drawing.Point(3, 343);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(938, 334);
            this.pnlDown.TabIndex = 1;
            // 
            // gbMaterial
            // 
            this.gbMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMaterial.Controls.Add(this.rbtDelete_M);
            this.gbMaterial.Controls.Add(this.rbtUpdate_M);
            this.gbMaterial.Controls.Add(this.rbtAdd_M);
            this.gbMaterial.Controls.Add(this.btnSave_M);
            this.gbMaterial.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMaterial.Location = new System.Drawing.Point(645, 50);
            this.gbMaterial.Name = "gbMaterial";
            this.gbMaterial.Size = new System.Drawing.Size(270, 255);
            this.gbMaterial.TabIndex = 8;
            this.gbMaterial.TabStop = false;
            this.gbMaterial.Text = "Acciones Materiales";
            // 
            // rbtDelete_M
            // 
            this.rbtDelete_M.AutoSize = true;
            this.rbtDelete_M.Location = new System.Drawing.Point(24, 95);
            this.rbtDelete_M.Name = "rbtDelete_M";
            this.rbtDelete_M.Size = new System.Drawing.Size(108, 24);
            this.rbtDelete_M.TabIndex = 6;
            this.rbtDelete_M.TabStop = true;
            this.rbtDelete_M.Text = "Dar de Baja";
            this.rbtDelete_M.UseVisualStyleBackColor = true;
            // 
            // rbtUpdate_M
            // 
            this.rbtUpdate_M.AutoSize = true;
            this.rbtUpdate_M.Location = new System.Drawing.Point(24, 65);
            this.rbtUpdate_M.Name = "rbtUpdate_M";
            this.rbtUpdate_M.Size = new System.Drawing.Size(169, 24);
            this.rbtUpdate_M.TabIndex = 5;
            this.rbtUpdate_M.TabStop = true;
            this.rbtUpdate_M.Text = "Modificar Producto";
            this.rbtUpdate_M.UseVisualStyleBackColor = true;
            // 
            // rbtAdd_M
            // 
            this.rbtAdd_M.AutoSize = true;
            this.rbtAdd_M.Location = new System.Drawing.Point(24, 35);
            this.rbtAdd_M.Name = "rbtAdd_M";
            this.rbtAdd_M.Size = new System.Drawing.Size(159, 24);
            this.rbtAdd_M.TabIndex = 4;
            this.rbtAdd_M.TabStop = true;
            this.rbtAdd_M.Text = "Agregar Producto";
            this.rbtAdd_M.UseVisualStyleBackColor = true;
            // 
            // btnSave_M
            // 
            this.btnSave_M.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave_M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.btnSave_M.FlatAppearance.BorderSize = 0;
            this.btnSave_M.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.btnSave_M.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave_M.ForeColor = System.Drawing.Color.White;
            this.btnSave_M.Location = new System.Drawing.Point(24, 205);
            this.btnSave_M.Name = "btnSave_M";
            this.btnSave_M.Size = new System.Drawing.Size(218, 44);
            this.btnSave_M.TabIndex = 1;
            this.btnSave_M.Text = "Ejecutar";
            this.btnSave_M.UseVisualStyleBackColor = false;
            // 
            // dgvMateriales
            // 
            this.dgvMateriales.AllowUserToAddRows = false;
            this.dgvMateriales.AllowUserToDeleteRows = false;
            this.dgvMateriales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMateriales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMateriales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.dgvMateriales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMateriales.CausesValidation = false;
            this.dgvMateriales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMateriales.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvMateriales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMateriales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMateriales.ColumnHeadersHeight = 42;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMateriales.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMateriales.EnableHeadersVisualStyles = false;
            this.dgvMateriales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.dgvMateriales.Location = new System.Drawing.Point(10, 85);
            this.dgvMateriales.MultiSelect = false;
            this.dgvMateriales.Name = "dgvMateriales";
            this.dgvMateriales.ReadOnly = true;
            this.dgvMateriales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMateriales.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMateriales.RowHeadersVisible = false;
            this.dgvMateriales.RowHeadersWidth = 56;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(105)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMateriales.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMateriales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateriales.Size = new System.Drawing.Size(606, 220);
            this.dgvMateriales.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Views.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(10, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // txtSearchMateriales
            // 
            this.txtSearchMateriales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchMateriales.Location = new System.Drawing.Point(50, 50);
            this.txtSearchMateriales.Name = "txtSearchMateriales";
            this.txtSearchMateriales.Size = new System.Drawing.Size(566, 25);
            this.txtSearchMateriales.TabIndex = 5;
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
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFrame)).EndInit();
            this.pnlCenter.ResumeLayout(false);
            this.tbLayout.ResumeLayout(false);
            this.pnlUp.ResumeLayout(false);
            this.pnlUp.PerformLayout();
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.pnlDown.ResumeLayout(false);
            this.pnlDown.PerformLayout();
            this.gbMaterial.ResumeLayout(false);
            this.gbMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtSearchProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSearchMateriales;
        private System.Windows.Forms.DataGridView dgvMateriales;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.GroupBox gbMaterial;
        private System.Windows.Forms.Button btnSave_P;
        private System.Windows.Forms.Button btnSave_M;
        private System.Windows.Forms.RadioButton rbtDelete_P;
        private System.Windows.Forms.RadioButton rbtUpdate_P;
        private System.Windows.Forms.RadioButton rbtAdd_P;
        private System.Windows.Forms.RadioButton rbtDelete_M;
        private System.Windows.Forms.RadioButton rbtUpdate_M;
        private System.Windows.Forms.RadioButton rbtAdd_M;
    }
}