
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEOQ = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPlaneacion_Agregada = new System.Windows.Forms.Button();
            this.btnMRP = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.padre = new System.Windows.Forms.Panel();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.pnlLeft.Controls.Add(this.pictureBox1);
            this.pnlLeft.Controls.Add(this.label2);
            this.pnlLeft.Controls.Add(this.label1);
            this.pnlLeft.Controls.Add(this.btnEOQ);
            this.pnlLeft.Controls.Add(this.btnHome);
            this.pnlLeft.Controls.Add(this.btnPlaneacion_Agregada);
            this.pnlLeft.Controls.Add(this.btnMRP);
            this.pnlLeft.Controls.Add(this.btnInventario);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(229, 735);
            this.pnlLeft.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(8, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Generales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(8, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modulos";
            // 
            // btnEOQ
            // 
            this.btnEOQ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEOQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEOQ.FlatAppearance.BorderSize = 0;
            this.btnEOQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(105)))), ((int)(((byte)(248)))));
            this.btnEOQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEOQ.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEOQ.ForeColor = System.Drawing.Color.White;
            this.btnEOQ.Image = global::Views.Properties.Resources.box;
            this.btnEOQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEOQ.Location = new System.Drawing.Point(-1, 392);
            this.btnEOQ.Name = "btnEOQ";
            this.btnEOQ.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEOQ.Size = new System.Drawing.Size(229, 42);
            this.btnEOQ.TabIndex = 12;
            this.btnEOQ.Text = "   Gestion EOQ";
            this.btnEOQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEOQ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEOQ.UseVisualStyleBackColor = true;
            this.btnEOQ.Click += new System.EventHandler(this.btnEOQ_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(105)))), ((int)(((byte)(248)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::Views.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 242);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(229, 42);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "   Inicio";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnPlaneacion_Agregada
            // 
            this.btnPlaneacion_Agregada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlaneacion_Agregada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlaneacion_Agregada.FlatAppearance.BorderSize = 0;
            this.btnPlaneacion_Agregada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(105)))), ((int)(((byte)(248)))));
            this.btnPlaneacion_Agregada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaneacion_Agregada.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaneacion_Agregada.ForeColor = System.Drawing.Color.White;
            this.btnPlaneacion_Agregada.Image = global::Views.Properties.Resources.human_resources;
            this.btnPlaneacion_Agregada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaneacion_Agregada.Location = new System.Drawing.Point(-2, 488);
            this.btnPlaneacion_Agregada.Name = "btnPlaneacion_Agregada";
            this.btnPlaneacion_Agregada.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPlaneacion_Agregada.Size = new System.Drawing.Size(229, 42);
            this.btnPlaneacion_Agregada.TabIndex = 10;
            this.btnPlaneacion_Agregada.Text = "   Planeación Agregada";
            this.btnPlaneacion_Agregada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaneacion_Agregada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlaneacion_Agregada.UseVisualStyleBackColor = true;
            this.btnPlaneacion_Agregada.Click += new System.EventHandler(this.btnPlaneacion_Agregada_Click);
            // 
            // btnMRP
            // 
            this.btnMRP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMRP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMRP.FlatAppearance.BorderSize = 0;
            this.btnMRP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(105)))), ((int)(((byte)(248)))));
            this.btnMRP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMRP.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMRP.ForeColor = System.Drawing.Color.White;
            this.btnMRP.Image = global::Views.Properties.Resources.materials;
            this.btnMRP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMRP.Location = new System.Drawing.Point(-2, 440);
            this.btnMRP.Name = "btnMRP";
            this.btnMRP.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMRP.Size = new System.Drawing.Size(229, 42);
            this.btnMRP.TabIndex = 9;
            this.btnMRP.Text = "   MRP";
            this.btnMRP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMRP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMRP.UseVisualStyleBackColor = true;
            this.btnMRP.Click += new System.EventHandler(this.btnMRP_Click);
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
            this.btnInventario.Location = new System.Drawing.Point(0, 290);
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
            // padre
            // 
            this.padre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.padre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.padre.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.padre.Location = new System.Drawing.Point(229, 0);
            this.padre.Name = "padre";
            this.padre.Size = new System.Drawing.Size(944, 735);
            this.padre.TabIndex = 1;
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
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel padre;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnPlaneacion_Agregada;
        private System.Windows.Forms.Button btnMRP;
        private System.Windows.Forms.Button btnEOQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

