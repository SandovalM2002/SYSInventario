namespace CapaVistas.FrameMDI
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReporteActaTecnica = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnReporteFactura = new Bunifu.Framework.UI.BunifuTileButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(101, 151);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1355, 550);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1501, 100);
            this.pnlHeader.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReporteFactura);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 544);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReporteActaTecnica);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(680, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 544);
            this.panel2.TabIndex = 1;
            // 
            // btnReporteActaTecnica
            // 
            this.btnReporteActaTecnica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReporteActaTecnica.BackColor = System.Drawing.Color.Transparent;
            this.btnReporteActaTecnica.color = System.Drawing.Color.Transparent;
            this.btnReporteActaTecnica.colorActive = System.Drawing.Color.Transparent;
            this.btnReporteActaTecnica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteActaTecnica.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnReporteActaTecnica.ForeColor = System.Drawing.Color.Black;
            this.btnReporteActaTecnica.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteActaTecnica.Image")));
            this.btnReporteActaTecnica.ImagePosition = 20;
            this.btnReporteActaTecnica.ImageZoom = 77;
            this.btnReporteActaTecnica.LabelPosition = 41;
            this.btnReporteActaTecnica.LabelText = "Reporte Acta Tecnica";
            this.btnReporteActaTecnica.Location = new System.Drawing.Point(222, 125);
            this.btnReporteActaTecnica.Margin = new System.Windows.Forms.Padding(6);
            this.btnReporteActaTecnica.Name = "btnReporteActaTecnica";
            this.btnReporteActaTecnica.Size = new System.Drawing.Size(250, 256);
            this.btnReporteActaTecnica.TabIndex = 8;
            // 
            // btnReporteFactura
            // 
            this.btnReporteFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReporteFactura.BackColor = System.Drawing.Color.Transparent;
            this.btnReporteFactura.color = System.Drawing.Color.Transparent;
            this.btnReporteFactura.colorActive = System.Drawing.Color.Transparent;
            this.btnReporteFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteFactura.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnReporteFactura.ForeColor = System.Drawing.Color.Black;
            this.btnReporteFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteFactura.Image")));
            this.btnReporteFactura.ImagePosition = 20;
            this.btnReporteFactura.ImageZoom = 77;
            this.btnReporteFactura.LabelPosition = 41;
            this.btnReporteFactura.LabelText = "Reporte Factura";
            this.btnReporteFactura.Location = new System.Drawing.Point(197, 125);
            this.btnReporteFactura.Margin = new System.Windows.Forms.Padding(6);
            this.btnReporteFactura.Name = "btnReporteFactura";
            this.btnReporteFactura.Size = new System.Drawing.Size(250, 256);
            this.btnReporteFactura.TabIndex = 7;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1501, 784);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTileButton btnReporteActaTecnica;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTileButton btnReporteFactura;
    }
}