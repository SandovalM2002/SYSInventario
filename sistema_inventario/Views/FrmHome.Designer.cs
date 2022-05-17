
namespace Views
{
    partial class principal
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
            this.components = new System.ComponentModel.Container();
            this.title_var = new System.Windows.Forms.Panel();
            this.contenedor = new System.Windows.Forms.Panel();
            this.lblReloj = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Timer(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNames = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title_var
            // 
            this.title_var.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.title_var.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.title_var.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_var.Location = new System.Drawing.Point(0, 0);
            this.title_var.Name = "title_var";
            this.title_var.Size = new System.Drawing.Size(1280, 50);
            this.title_var.TabIndex = 0;
            this.title_var.Paint += new System.Windows.Forms.PaintEventHandler(this.title_var_Paint);
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.contenedor.Controls.Add(this.label2);
            this.contenedor.Controls.Add(this.label1);
            this.contenedor.Controls.Add(this.pictureBox2);
            this.contenedor.Controls.Add(this.pictureBox1);
            this.contenedor.Controls.Add(this.lblNames);
            this.contenedor.Controls.Add(this.lblFecha);
            this.contenedor.Controls.Add(this.lblReloj);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 50);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1280, 670);
            this.contenedor.TabIndex = 2;
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Font = new System.Drawing.Font("Microsoft YaHei", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.ForeColor = System.Drawing.Color.White;
            this.lblReloj.Location = new System.Drawing.Point(134, 101);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(401, 151);
            this.lblReloj.TabIndex = 0;
            this.lblReloj.Text = "label1";
            // 
            // hora
            // 
            this.hora.Enabled = true;
            this.hora.Tick += new System.EventHandler(this.hora_Tick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft YaHei", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblFecha.Location = new System.Drawing.Point(89, 264);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(171, 65);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "label1";
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNames.ForeColor = System.Drawing.Color.White;
            this.lblNames.Location = new System.Drawing.Point(88, 381);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(780, 402);
            this.lblNames.TabIndex = 2;
            this.lblNames.Text = "Integrantes: \r\nOmar Josue Sandoval Maldonado \r\nMayer Antonio Fonseca Solorzano\r\nE" +
    "ngel Josué Paz Rodríguez\r\nClaudia Isabel Videa Ruiz\r\nScarleth Regina Chavarría L" +
    "arios";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Views.Properties.Resources._755194;
            this.pictureBox2.Location = new System.Drawing.Point(761, 451);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(393, 275);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Views.Properties.Resources._124109;
            this.pictureBox1.Location = new System.Drawing.Point(948, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 50F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(705, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 97);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gestor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 50F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(874, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 97);
            this.label2.TabIndex = 6;
            this.label2.Text = "De inventario";
            // 
            // principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.title_var);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "principal";
            this.Text = "AcercaDe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.contenedor.ResumeLayout(false);
            this.contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel title_var;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Timer hora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}