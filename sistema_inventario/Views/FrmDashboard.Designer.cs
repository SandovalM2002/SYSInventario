
namespace Views
{
    partial class FrmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.btnPModulo = new System.Windows.Forms.Button();
            this.padre = new System.Windows.Forms.Panel();
            this.btnInventario = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.pnlLeft.Controls.Add(this.btnInformacion);
            this.pnlLeft.Controls.Add(this.btnInventario);
            this.pnlLeft.Controls.Add(this.lblTitle);
            this.pnlLeft.Controls.Add(this.Logo);
            this.pnlLeft.Controls.Add(this.lblLine);
            this.pnlLeft.Controls.Add(this.btnPModulo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(229, 735);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnInformacion
            // 
            this.btnInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(105)))), ((int)(((byte)(248)))));
            this.btnInformacion.FlatAppearance.BorderSize = 0;
            this.btnInformacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(144)))));
            this.btnInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacion.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacion.ForeColor = System.Drawing.Color.White;
            this.btnInformacion.Location = new System.Drawing.Point(47, 683);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(136, 40);
            this.btnInformacion.TabIndex = 0;
            this.btnInformacion.Text = "Acerca de";
            this.btnInformacion.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(97, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(132, 63);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Sistema de Inventario Automatizado\r\n";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(105)))), ((int)(((byte)(248)))));
            this.lblLine.Location = new System.Drawing.Point(89, 20);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(3, 59);
            this.lblLine.TabIndex = 7;
            // 
            // btnPModulo
            // 
            this.btnPModulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPModulo.FlatAppearance.BorderSize = 0;
            this.btnPModulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(105)))), ((int)(((byte)(248)))));
            this.btnPModulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPModulo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.btnPModulo.ForeColor = System.Drawing.Color.White;
            this.btnPModulo.Location = new System.Drawing.Point(0, 230);
            this.btnPModulo.Name = "btnPModulo";
            this.btnPModulo.Size = new System.Drawing.Size(229, 44);
            this.btnPModulo.TabIndex = 2;
            this.btnPModulo.Text = "Cantidad Optima";
            this.btnPModulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPModulo.UseVisualStyleBackColor = true;
            this.btnPModulo.Click += new System.EventHandler(this.btnPModulo_Click);
            // 
            // padre
            // 
            this.padre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.padre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.padre.Location = new System.Drawing.Point(229, 0);
            this.padre.Name = "padre";
            this.padre.Size = new System.Drawing.Size(944, 735);
            this.padre.TabIndex = 1;
            // 
            // btnInventario
            // 
            this.btnInventario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(105)))), ((int)(((byte)(248)))));
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Image = global::Views.Properties.Resources.box;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 182);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInventario.Size = new System.Drawing.Size(229, 42);
            this.btnInventario.TabIndex = 8;
            this.btnInventario.Text = "   Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::Views.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(22, 18);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(61, 61);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 6;
            this.Logo.TabStop = false;
            // 
            // FrmDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1173, 735);
            this.Controls.Add(this.padre);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1189, 774);
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnPModulo;
        private System.Windows.Forms.Panel padre;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnInformacion;
    }
}

