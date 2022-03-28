namespace CapaVistas.FrameMDI
{
    partial class FrmCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtFinder = new System.Windows.Forms.TextBox();
            this.btnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvCompra = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlDataCliente = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbFechaCompra = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd_IdEmpleado = new Bunifu.Framework.UI.BunifuImageButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId_Empleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd_IdProducto = new Bunifu.Framework.UI.BunifuImageButton();
            this.label25 = new System.Windows.Forms.Label();
            this.txtId_Producto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidadComprada = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.pnlDataCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd_IdEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd_IdProducto)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Controls.Add(this.pictureBox6);
            this.pnlContenedor.Controls.Add(this.txtFinder);
            this.pnlContenedor.Controls.Add(this.btnClear);
            this.pnlContenedor.Controls.Add(this.btnEliminar);
            this.pnlContenedor.Controls.Add(this.btnEditar);
            this.pnlContenedor.Controls.Add(this.dgvCompra);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 66);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(990, 717);
            this.pnlContenedor.TabIndex = 7;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CapaVistas.Properties.Resources.Busqueda;
            this.pictureBox6.Location = new System.Drawing.Point(58, 71);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 38;
            this.pictureBox6.TabStop = false;
            // 
            // txtFinder
            // 
            this.txtFinder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinder.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinder.Location = new System.Drawing.Point(99, 71);
            this.txtFinder.Name = "txtFinder";
            this.txtFinder.Size = new System.Drawing.Size(307, 31);
            this.txtFinder.TabIndex = 37;
            this.txtFinder.TextChanged += new System.EventHandler(this.txtFinder_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.BorderRadius = 0;
            this.btnClear.ButtonText = "LIMPIAR";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledColor = System.Drawing.Color.White;
            this.btnClear.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClear.Iconimage = null;
            this.btnClear.Iconimage_right = null;
            this.btnClear.Iconimage_right_Selected = null;
            this.btnClear.Iconimage_Selected = null;
            this.btnClear.IconMarginLeft = 0;
            this.btnClear.IconMarginRight = 0;
            this.btnClear.IconRightVisible = true;
            this.btnClear.IconRightZoom = 0D;
            this.btnClear.IconVisible = true;
            this.btnClear.IconZoom = 60D;
            this.btnClear.IsTab = false;
            this.btnClear.Location = new System.Drawing.Point(793, 644);
            this.btnClear.Name = "btnClear";
            this.btnClear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.btnClear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnClear.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClear.selected = false;
            this.btnClear.Size = new System.Drawing.Size(151, 48);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "LIMPIAR";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Textcolor = System.Drawing.Color.White;
            this.btnClear.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnEliminar
            // 
            this.btnEliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderRadius = 0;
            this.btnEliminar.ButtonText = "ELIMINAR";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DisabledColor = System.Drawing.Color.White;
            this.btnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Iconimage")));
            this.btnEliminar.Iconimage_right = null;
            this.btnEliminar.Iconimage_right_Selected = null;
            this.btnEliminar.Iconimage_Selected = null;
            this.btnEliminar.IconMarginLeft = 0;
            this.btnEliminar.IconMarginRight = 0;
            this.btnEliminar.IconRightVisible = true;
            this.btnEliminar.IconRightZoom = 0D;
            this.btnEliminar.IconVisible = true;
            this.btnEliminar.IconZoom = 60D;
            this.btnEliminar.IsTab = false;
            this.btnEliminar.Location = new System.Drawing.Point(265, 644);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.btnEliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminar.selected = false;
            this.btnEliminar.Size = new System.Drawing.Size(151, 48);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.Textcolor = System.Drawing.Color.White;
            this.btnEliminar.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.BorderRadius = 0;
            this.btnEditar.ButtonText = "EDITAR";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.DisabledColor = System.Drawing.Color.White;
            this.btnEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditar.Iconimage")));
            this.btnEditar.Iconimage_right = null;
            this.btnEditar.Iconimage_right_Selected = null;
            this.btnEditar.Iconimage_Selected = null;
            this.btnEditar.IconMarginLeft = 0;
            this.btnEditar.IconMarginRight = 0;
            this.btnEditar.IconRightVisible = true;
            this.btnEditar.IconRightZoom = 0D;
            this.btnEditar.IconVisible = true;
            this.btnEditar.IconZoom = 60D;
            this.btnEditar.IsTab = false;
            this.btnEditar.Location = new System.Drawing.Point(58, 644);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.btnEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditar.selected = false;
            this.btnEditar.Size = new System.Drawing.Size(151, 48);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditar.Textcolor = System.Drawing.Color.White;
            this.btnEditar.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvCompra
            // 
            this.dgvCompra.AllowUserToAddRows = false;
            this.dgvCompra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCompra.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompra.ColumnHeadersHeight = 48;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompra.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCompra.DoubleBuffered = true;
            this.dgvCompra.EnableHeadersVisualStyles = false;
            this.dgvCompra.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dgvCompra.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCompra.Location = new System.Drawing.Point(58, 135);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCompra.RowHeadersVisible = false;
            this.dgvCompra.RowHeadersWidth = 50;
            this.dgvCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompra.Size = new System.Drawing.Size(886, 489);
            this.dgvCompra.TabIndex = 8;
            this.dgvCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompra_CellClick);
            this.dgvCompra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompra_CellDoubleClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 0;
            this.btnGuardar.ButtonText = "GUARDAR";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.White;
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Iconimage")));
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 56D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(133, 644);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(151, 48);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Textcolor = System.Drawing.Color.White;
            this.btnGuardar.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlDataCliente
            // 
            this.pnlDataCliente.BackColor = System.Drawing.Color.White;
            this.pnlDataCliente.Controls.Add(this.label13);
            this.pnlDataCliente.Controls.Add(this.cmbFechaCompra);
            this.pnlDataCliente.Controls.Add(this.btnGuardar);
            this.pnlDataCliente.Controls.Add(this.label9);
            this.pnlDataCliente.Controls.Add(this.label10);
            this.pnlDataCliente.Controls.Add(this.txtMonto);
            this.pnlDataCliente.Controls.Add(this.label5);
            this.pnlDataCliente.Controls.Add(this.btnAdd_IdEmpleado);
            this.pnlDataCliente.Controls.Add(this.label8);
            this.pnlDataCliente.Controls.Add(this.txtId_Empleado);
            this.pnlDataCliente.Controls.Add(this.label4);
            this.pnlDataCliente.Controls.Add(this.btnAdd_IdProducto);
            this.pnlDataCliente.Controls.Add(this.label25);
            this.pnlDataCliente.Controls.Add(this.txtId_Producto);
            this.pnlDataCliente.Controls.Add(this.label6);
            this.pnlDataCliente.Controls.Add(this.label7);
            this.pnlDataCliente.Controls.Add(this.txtCantidadComprada);
            this.pnlDataCliente.Controls.Add(this.label11);
            this.pnlDataCliente.Controls.Add(this.label12);
            this.pnlDataCliente.Controls.Add(this.txtId);
            this.pnlDataCliente.Controls.Add(this.panel1);
            this.pnlDataCliente.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDataCliente.Location = new System.Drawing.Point(990, 66);
            this.pnlDataCliente.Name = "pnlDataCliente";
            this.pnlDataCliente.Size = new System.Drawing.Size(411, 717);
            this.pnlDataCliente.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(30, 414);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 21);
            this.label13.TabIndex = 101;
            this.label13.Text = "Fecha de la Compra:";
            // 
            // cmbFechaCompra
            // 
            this.cmbFechaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.cmbFechaCompra.BorderRadius = 0;
            this.cmbFechaCompra.ForeColor = System.Drawing.Color.White;
            this.cmbFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.cmbFechaCompra.FormatCustom = "";
            this.cmbFechaCompra.Location = new System.Drawing.Point(28, 438);
            this.cmbFechaCompra.Name = "cmbFechaCompra";
            this.cmbFechaCompra.Size = new System.Drawing.Size(317, 36);
            this.cmbFechaCompra.TabIndex = 6;
            this.cmbFechaCompra.Value = new System.DateTime(2020, 11, 17, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(172)))));
            this.label9.Location = new System.Drawing.Point(29, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 3);
            this.label9.TabIndex = 99;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(26, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 21);
            this.label10.TabIndex = 98;
            this.label10.Text = "Monto de la Compra:";
            // 
            // txtMonto
            // 
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(30, 360);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(156, 20);
            this.txtMonto.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(28, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 96;
            this.label5.Text = "Id Empleado";
            // 
            // btnAdd_IdEmpleado
            // 
            this.btnAdd_IdEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.btnAdd_IdEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd_IdEmpleado.Image")));
            this.btnAdd_IdEmpleado.ImageActive = null;
            this.btnAdd_IdEmpleado.Location = new System.Drawing.Point(178, 202);
            this.btnAdd_IdEmpleado.Name = "btnAdd_IdEmpleado";
            this.btnAdd_IdEmpleado.Size = new System.Drawing.Size(32, 32);
            this.btnAdd_IdEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnAdd_IdEmpleado.TabIndex = 93;
            this.btnAdd_IdEmpleado.TabStop = false;
            this.btnAdd_IdEmpleado.Zoom = 15;
            this.btnAdd_IdEmpleado.Click += new System.EventHandler(this.btnAdd_IdEmpleado_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(172)))));
            this.label8.Location = new System.Drawing.Point(31, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 3);
            this.label8.TabIndex = 95;
            // 
            // txtId_Empleado
            // 
            this.txtId_Empleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId_Empleado.Enabled = false;
            this.txtId_Empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_Empleado.Location = new System.Drawing.Point(32, 210);
            this.txtId_Empleado.Name = "txtId_Empleado";
            this.txtId_Empleado.Size = new System.Drawing.Size(140, 20);
            this.txtId_Empleado.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(26, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 92;
            this.label4.Text = "Id Producto";
            // 
            // btnAdd_IdProducto
            // 
            this.btnAdd_IdProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.btnAdd_IdProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd_IdProducto.Image")));
            this.btnAdd_IdProducto.ImageActive = null;
            this.btnAdd_IdProducto.Location = new System.Drawing.Point(178, 135);
            this.btnAdd_IdProducto.Name = "btnAdd_IdProducto";
            this.btnAdd_IdProducto.Size = new System.Drawing.Size(32, 32);
            this.btnAdd_IdProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnAdd_IdProducto.TabIndex = 88;
            this.btnAdd_IdProducto.TabStop = false;
            this.btnAdd_IdProducto.Zoom = 15;
            this.btnAdd_IdProducto.Click += new System.EventHandler(this.btnAdd_IdProducto_Click);
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(172)))));
            this.label25.Location = new System.Drawing.Point(29, 164);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(143, 3);
            this.label25.TabIndex = 91;
            // 
            // txtId_Producto
            // 
            this.txtId_Producto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId_Producto.Enabled = false;
            this.txtId_Producto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_Producto.Location = new System.Drawing.Point(30, 143);
            this.txtId_Producto.Name = "txtId_Producto";
            this.txtId_Producto.Size = new System.Drawing.Size(142, 20);
            this.txtId_Producto.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(172)))));
            this.label6.Location = new System.Drawing.Point(31, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 3);
            this.label6.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(28, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 21);
            this.label7.TabIndex = 61;
            this.label7.Text = "Cantidad Comprada:";
            // 
            // txtCantidadComprada
            // 
            this.txtCantidadComprada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadComprada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadComprada.Location = new System.Drawing.Point(32, 286);
            this.txtCantidadComprada.Name = "txtCantidadComprada";
            this.txtCantidadComprada.Size = new System.Drawing.Size(150, 20);
            this.txtCantidadComprada.TabIndex = 4;
            this.txtCantidadComprada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadComprada_KeyPress);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(172)))));
            this.label11.Location = new System.Drawing.Point(27, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 3);
            this.label11.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(24, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 21);
            this.label12.TabIndex = 55;
            this.label12.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(28, 71);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(45, 20);
            this.txtId.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(193)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 36);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datos de la Compra";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.Control;
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1401, 66);
            this.pnlHeader.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(76, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "COMPRAS";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label1.Location = new System.Drawing.Point(72, 4);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(3, 58);
            this.label1.TabIndex = 0;
            // 
            // FrmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 783);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlDataCliente);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCompra";
            this.Text = "FrmCompra";
            this.Load += new System.EventHandler(this.FrmCompra_Load);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.pnlDataCliente.ResumeLayout(false);
            this.pnlDataCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd_IdEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd_IdProducto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditar;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCompra;
        private System.Windows.Forms.Panel pnlDataCliente;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd_IdProducto;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtId_Producto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantidadComprada;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd_IdEmpleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId_Empleado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMonto;
        private Bunifu.Framework.UI.BunifuDatepicker cmbFechaCompra;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuFlatButton btnClear;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txtFinder;
    }
}