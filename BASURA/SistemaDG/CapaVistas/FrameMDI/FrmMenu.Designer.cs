namespace CapaVistas
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.Header = new System.Windows.Forms.Panel();
            this.btnConfiguraciones = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SideBar = new System.Windows.Forms.Panel();
            this.btnProveedor = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnOrdenes = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCompras = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnProducto = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnEmpleado = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnUsuarios = new Bunifu.Framework.UI.BunifuTileButton();
            this.Flecha = new System.Windows.Forms.PictureBox();
            this.btnInventario = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClientes = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfiguraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Flecha)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(180)))));
            this.Header.Controls.Add(this.btnConfiguraciones);
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1635, 46);
            this.Header.TabIndex = 0;
            // 
            // btnConfiguraciones
            // 
            this.btnConfiguraciones.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnConfiguraciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguraciones.Image = global::CapaVistas.Properties.Resources.Configuraciones;
            this.btnConfiguraciones.Location = new System.Drawing.Point(21, 4);
            this.btnConfiguraciones.Name = "btnConfiguraciones";
            this.btnConfiguraciones.Size = new System.Drawing.Size(34, 37);
            this.btnConfiguraciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnConfiguraciones.TabIndex = 15;
            this.btnConfiguraciones.TabStop = false;
            this.btnConfiguraciones.Click += new System.EventHandler(this.btnConfiguraciones_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1594, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.SideBar.Controls.Add(this.btnProveedor);
            this.SideBar.Controls.Add(this.btnOrdenes);
            this.SideBar.Controls.Add(this.btnCompras);
            this.SideBar.Controls.Add(this.btnProducto);
            this.SideBar.Controls.Add(this.btnEmpleado);
            this.SideBar.Controls.Add(this.btnUsuarios);
            this.SideBar.Controls.Add(this.Flecha);
            this.SideBar.Controls.Add(this.btnInventario);
            this.SideBar.Controls.Add(this.btnClientes);
            this.SideBar.Controls.Add(this.btnHome);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 46);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(81, 826);
            this.SideBar.TabIndex = 1;
            // 
            // btnProveedor
            // 
            this.btnProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnProveedor.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnProveedor.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedor.ForeColor = System.Drawing.Color.White;
            this.btnProveedor.Image = global::CapaVistas.Properties.Resources.Cliente;
            this.btnProveedor.ImagePosition = 14;
            this.btnProveedor.ImageZoom = 40;
            this.btnProveedor.LabelPosition = 29;
            this.btnProveedor.LabelText = "Proveedor";
            this.btnProveedor.Location = new System.Drawing.Point(-1, 584);
            this.btnProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(81, 76);
            this.btnProveedor.TabIndex = 13;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnOrdenes.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnOrdenes.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnOrdenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdenes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenes.ForeColor = System.Drawing.Color.White;
            this.btnOrdenes.Image = ((System.Drawing.Image)(resources.GetObject("btnOrdenes.Image")));
            this.btnOrdenes.ImagePosition = 14;
            this.btnOrdenes.ImageZoom = 40;
            this.btnOrdenes.LabelPosition = 29;
            this.btnOrdenes.LabelText = "Ordenes";
            this.btnOrdenes.Location = new System.Drawing.Point(-1, 502);
            this.btnOrdenes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(81, 76);
            this.btnOrdenes.TabIndex = 12;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnCompras.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnCompras.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnCompras.Image")));
            this.btnCompras.ImagePosition = 14;
            this.btnCompras.ImageZoom = 40;
            this.btnCompras.LabelPosition = 29;
            this.btnCompras.LabelText = "Compras";
            this.btnCompras.Location = new System.Drawing.Point(-1, 420);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(81, 76);
            this.btnCompras.TabIndex = 11;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnProducto.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnProducto.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.Color.White;
            this.btnProducto.Image = global::CapaVistas.Properties.Resources.Productos;
            this.btnProducto.ImagePosition = 14;
            this.btnProducto.ImageZoom = 40;
            this.btnProducto.LabelPosition = 29;
            this.btnProducto.LabelText = "Productos";
            this.btnProducto.Location = new System.Drawing.Point(-1, 256);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(81, 76);
            this.btnProducto.TabIndex = 10;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnEmpleado.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnEmpleado.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEmpleado.Image = global::CapaVistas.Properties.Resources.Cliente;
            this.btnEmpleado.ImagePosition = 14;
            this.btnEmpleado.ImageZoom = 40;
            this.btnEmpleado.LabelPosition = 29;
            this.btnEmpleado.LabelText = "Empleados";
            this.btnEmpleado.Location = new System.Drawing.Point(0, 171);
            this.btnEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(81, 80);
            this.btnEmpleado.TabIndex = 9;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnUsuarios.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnUsuarios.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::CapaVistas.Properties.Resources.Usuario1;
            this.btnUsuarios.ImagePosition = 14;
            this.btnUsuarios.ImageZoom = 40;
            this.btnUsuarios.LabelPosition = 29;
            this.btnUsuarios.LabelText = "Usuarios";
            this.btnUsuarios.Location = new System.Drawing.Point(1, 744);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(81, 77);
            this.btnUsuarios.TabIndex = 8;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // Flecha
            // 
            this.Flecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.Flecha.Location = new System.Drawing.Point(0, 80);
            this.Flecha.Name = "Flecha";
            this.Flecha.Size = new System.Drawing.Size(83, 3);
            this.Flecha.TabIndex = 0;
            this.Flecha.TabStop = false;
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnInventario.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnInventario.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnInventario.Image")));
            this.btnInventario.ImagePosition = 14;
            this.btnInventario.ImageZoom = 40;
            this.btnInventario.LabelPosition = 29;
            this.btnInventario.LabelText = "Inventario";
            this.btnInventario.Location = new System.Drawing.Point(0, 339);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(81, 76);
            this.btnInventario.TabIndex = 2;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnClientes.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnClientes.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = global::CapaVistas.Properties.Resources.Cliente;
            this.btnClientes.ImagePosition = 14;
            this.btnClientes.ImageZoom = 40;
            this.btnClientes.LabelPosition = 29;
            this.btnClientes.LabelText = "Clientes";
            this.btnClientes.Location = new System.Drawing.Point(0, 87);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(81, 80);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnHome.color = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnHome.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::CapaVistas.Properties.Resources.Home;
            this.btnHome.ImagePosition = 14;
            this.btnHome.ImageZoom = 40;
            this.btnHome.LabelPosition = 29;
            this.btnHome.LabelText = "Home";
            this.btnHome.Location = new System.Drawing.Point(0, 1);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(81, 80);
            this.btnHome.TabIndex = 0;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(81, 46);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1554, 826);
            this.pnlContenedor.TabIndex = 2;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1635, 872);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnConfiguraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Flecha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel SideBar;
        private Bunifu.Framework.UI.BunifuTileButton btnHome;
        private Bunifu.Framework.UI.BunifuTileButton btnClientes;
        private Bunifu.Framework.UI.BunifuTileButton btnInventario;
        private System.Windows.Forms.PictureBox Flecha;
        private Bunifu.Framework.UI.BunifuTileButton btnUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlContenedor;
        private Bunifu.Framework.UI.BunifuTileButton btnEmpleado;
        private Bunifu.Framework.UI.BunifuTileButton btnProducto;
        private Bunifu.Framework.UI.BunifuTileButton btnCompras;
        private System.Windows.Forms.PictureBox btnConfiguraciones;
        private Bunifu.Framework.UI.BunifuTileButton btnProveedor;
        private Bunifu.Framework.UI.BunifuTileButton btnOrdenes;
    }
}

