
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPModulo = new System.Windows.Forms.Button();
            this.btnSModulo = new System.Windows.Forms.Button();
            this.btnTModulo = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.pnlLeft.Controls.Add(this.btnTModulo);
            this.pnlLeft.Controls.Add(this.btnSModulo);
            this.pnlLeft.Controls.Add(this.btnPModulo);
            this.pnlLeft.Controls.Add(this.btnHome);
            this.pnlLeft.Controls.Add(this.lblTitulo);
            this.pnlLeft.Location = new System.Drawing.Point(-1, 1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(220, 475);
            this.pnlLeft.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(205, 66);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Sistema de Inventario Adaptativo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(50, 423);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(125, 44);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Acera de";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnPModulo
            // 
            this.btnPModulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPModulo.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPModulo.Location = new System.Drawing.Point(3, 162);
            this.btnPModulo.Name = "btnPModulo";
            this.btnPModulo.Size = new System.Drawing.Size(214, 44);
            this.btnPModulo.TabIndex = 2;
            this.btnPModulo.Text = "Cantidad Optima";
            this.btnPModulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPModulo.UseVisualStyleBackColor = true;
            // 
            // btnSModulo
            // 
            this.btnSModulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSModulo.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSModulo.Location = new System.Drawing.Point(3, 212);
            this.btnSModulo.Name = "btnSModulo";
            this.btnSModulo.Size = new System.Drawing.Size(214, 44);
            this.btnSModulo.TabIndex = 3;
            this.btnSModulo.Text = "MRP";
            this.btnSModulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSModulo.UseVisualStyleBackColor = true;
            // 
            // btnTModulo
            // 
            this.btnTModulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTModulo.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTModulo.Location = new System.Drawing.Point(3, 262);
            this.btnTModulo.Name = "btnTModulo";
            this.btnTModulo.Size = new System.Drawing.Size(214, 44);
            this.btnTModulo.TabIndex = 4;
            this.btnTModulo.Text = "Planeacion Agregada";
            this.btnTModulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTModulo.UseVisualStyleBackColor = true;
            // 
            // FrmDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(960, 480);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnTModulo;
        private System.Windows.Forms.Button btnSModulo;
        private System.Windows.Forms.Button btnPModulo;
    }
}

