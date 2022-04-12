
namespace Views.Planeacion_Agregada
{
    partial class FrmPlaneacionAgregada
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeriodos = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvDYD = new System.Windows.Forms.DataGridView();
            this.dgvPlanificacion = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvIni = new System.Windows.Forms.TextBox();
            this.txtSS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTrabajadores = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContratar = new System.Windows.Forms.TextBox();
            this.txtDespedir = new System.Windows.Forms.TextBox();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDYD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "Cantidad de periodos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 32);
            this.label1.TabIndex = 47;
            this.label1.Text = "Planificacion Agregada";
            // 
            // txtPeriodos
            // 
            this.txtPeriodos.Location = new System.Drawing.Point(233, 95);
            this.txtPeriodos.Name = "txtPeriodos";
            this.txtPeriodos.Size = new System.Drawing.Size(100, 22);
            this.txtPeriodos.TabIndex = 49;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(339, 96);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(82, 23);
            this.btnGenerar.TabIndex = 50;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dgvDYD
            // 
            this.dgvDYD.AllowUserToAddRows = false;
            this.dgvDYD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDYD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDYD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDYD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDYD.Location = new System.Drawing.Point(445, 94);
            this.dgvDYD.Name = "dgvDYD";
            this.dgvDYD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDYD.RowTemplate.Height = 24;
            this.dgvDYD.Size = new System.Drawing.Size(573, 106);
            this.dgvDYD.TabIndex = 51;
            // 
            // dgvPlanificacion
            // 
            this.dgvPlanificacion.AllowUserToAddRows = false;
            this.dgvPlanificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlanificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanificacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPlanificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanificacion.Location = new System.Drawing.Point(445, 228);
            this.dgvPlanificacion.Name = "dgvPlanificacion";
            this.dgvPlanificacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPlanificacion.RowTemplate.Height = 24;
            this.dgvPlanificacion.Size = new System.Drawing.Size(573, 298);
            this.dgvPlanificacion.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "Inventario Inicial:\r\n";
            // 
            // txtInvIni
            // 
            this.txtInvIni.Location = new System.Drawing.Point(233, 137);
            this.txtInvIni.Name = "txtInvIni";
            this.txtInvIni.Size = new System.Drawing.Size(100, 22);
            this.txtInvIni.TabIndex = 54;
            // 
            // txtSS
            // 
            this.txtSS.Location = new System.Drawing.Point(233, 177);
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(100, 22);
            this.txtSS.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 24);
            this.label4.TabIndex = 56;
            this.label4.Text = "% stock de seguridad";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(233, 437);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 57;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 24);
            this.label5.TabIndex = 58;
            this.label5.Text = "Horas requeridas";
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(233, 216);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(100, 22);
            this.txtHoras.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 24);
            this.label6.TabIndex = 60;
            this.label6.Text = "Trabajadores Actuales\r\n";
            // 
            // txtTrabajadores
            // 
            this.txtTrabajadores.Location = new System.Drawing.Point(233, 263);
            this.txtTrabajadores.Name = "txtTrabajadores";
            this.txtTrabajadores.Size = new System.Drawing.Size(100, 22);
            this.txtTrabajadores.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 48);
            this.label7.TabIndex = 62;
            this.label7.Text = "Costo de contratar\r\n\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 24);
            this.label8.TabIndex = 63;
            this.label8.Text = "Costo de despedir\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 24);
            this.label9.TabIndex = 64;
            this.label9.Text = "Costo hora trabajada\r\n";
            // 
            // txtContratar
            // 
            this.txtContratar.Location = new System.Drawing.Point(233, 307);
            this.txtContratar.Name = "txtContratar";
            this.txtContratar.Size = new System.Drawing.Size(100, 22);
            this.txtContratar.TabIndex = 65;
            // 
            // txtDespedir
            // 
            this.txtDespedir.Location = new System.Drawing.Point(233, 351);
            this.txtDespedir.Name = "txtDespedir";
            this.txtDespedir.Size = new System.Drawing.Size(100, 22);
            this.txtDespedir.TabIndex = 66;
            // 
            // txtValorHora
            // 
            this.txtValorHora.Location = new System.Drawing.Point(233, 395);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(100, 22);
            this.txtValorHora.TabIndex = 67;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(15, 486);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(114, 24);
            this.lblCosto.TabIndex = 68;
            this.lblCosto.Text = "Costo Total: ";
            // 
            // FrmPlaneacionAgregada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 538);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.txtValorHora);
            this.Controls.Add(this.txtDespedir);
            this.Controls.Add(this.txtContratar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTrabajadores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSS);
            this.Controls.Add(this.txtInvIni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPlanificacion);
            this.Controls.Add(this.dgvDYD);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtPeriodos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPlaneacionAgregada";
            this.Text = "FrmPlaneacionAgregada";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDYD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeriodos;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgvDYD;
        private System.Windows.Forms.DataGridView dgvPlanificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInvIni;
        private System.Windows.Forms.TextBox txtSS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTrabajadores;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtContratar;
        private System.Windows.Forms.TextBox txtDespedir;
        private System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.Label lblCosto;
    }
}