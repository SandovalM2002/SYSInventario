
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
            this.txtContratar = new System.Windows.Forms.TextBox();
            this.txtDespedir = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.gbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.gbPersecucion = new System.Windows.Forms.GroupBox();
            this.rbPersecucion = new System.Windows.Forms.RadioButton();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbFuerzaNiv = new System.Windows.Forms.RadioButton();
            this.gbFuerzaN = new System.Windows.Forms.GroupBox();
            this.txtMantener = new System.Windows.Forms.TextBox();
            this.txtEscasez = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rbOutS = new System.Windows.Forms.RadioButton();
            this.gbOutS = new System.Windows.Forms.GroupBox();
            this.txtOutS = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDYD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanificacion)).BeginInit();
            this.gbDatosGenerales.SuspendLayout();
            this.gbPersecucion.SuspendLayout();
            this.gbFuerzaN.SuspendLayout();
            this.gbOutS.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "Cantidad de periodos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 32);
            this.label1.TabIndex = 47;
            this.label1.Text = "Planificacion Agregada";
            // 
            // txtPeriodos
            // 
            this.txtPeriodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodos.Location = new System.Drawing.Point(227, 46);
            this.txtPeriodos.Name = "txtPeriodos";
            this.txtPeriodos.Size = new System.Drawing.Size(100, 22);
            this.txtPeriodos.TabIndex = 49;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(333, 45);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(82, 32);
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
            this.dgvDYD.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvDYD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDYD.Location = new System.Drawing.Point(466, 78);
            this.dgvDYD.Name = "dgvDYD";
            this.dgvDYD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDYD.RowTemplate.Height = 24;
            this.dgvDYD.Size = new System.Drawing.Size(648, 106);
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
            this.dgvPlanificacion.Location = new System.Drawing.Point(466, 198);
            this.dgvPlanificacion.Name = "dgvPlanificacion";
            this.dgvPlanificacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvPlanificacion.RowTemplate.Height = 24;
            this.dgvPlanificacion.Size = new System.Drawing.Size(648, 676);
            this.dgvPlanificacion.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "Inventario Inicial:\r\n";
            // 
            // txtInvIni
            // 
            this.txtInvIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvIni.Location = new System.Drawing.Point(227, 88);
            this.txtInvIni.Name = "txtInvIni";
            this.txtInvIni.Size = new System.Drawing.Size(100, 22);
            this.txtInvIni.TabIndex = 54;
            // 
            // txtSS
            // 
            this.txtSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSS.Location = new System.Drawing.Point(227, 128);
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(100, 22);
            this.txtSS.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 24);
            this.label4.TabIndex = 56;
            this.label4.Text = "% stock de seguridad";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(239, 838);
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
            this.label5.Location = new System.Drawing.Point(9, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 24);
            this.label5.TabIndex = 58;
            this.label5.Text = "Horas requeridas";
            // 
            // txtHoras
            // 
            this.txtHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoras.Location = new System.Drawing.Point(227, 167);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(100, 22);
            this.txtHoras.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 24);
            this.label6.TabIndex = 60;
            this.label6.Text = "Trabajadores Actuales\r\n";
            // 
            // txtTrabajadores
            // 
            this.txtTrabajadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrabajadores.Location = new System.Drawing.Point(240, 38);
            this.txtTrabajadores.Name = "txtTrabajadores";
            this.txtTrabajadores.Size = new System.Drawing.Size(100, 22);
            this.txtTrabajadores.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 24);
            this.label7.TabIndex = 62;
            this.label7.Text = "Costo de contratar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 24);
            this.label8.TabIndex = 63;
            this.label8.Text = "Costo de despedir\r\n";
            // 
            // txtContratar
            // 
            this.txtContratar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContratar.Location = new System.Drawing.Point(240, 85);
            this.txtContratar.Name = "txtContratar";
            this.txtContratar.Size = new System.Drawing.Size(100, 22);
            this.txtContratar.TabIndex = 65;
            // 
            // txtDespedir
            // 
            this.txtDespedir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDespedir.Location = new System.Drawing.Point(240, 126);
            this.txtDespedir.Name = "txtDespedir";
            this.txtDespedir.Size = new System.Drawing.Size(100, 22);
            this.txtDespedir.TabIndex = 66;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(21, 838);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(114, 24);
            this.lblCosto.TabIndex = 68;
            this.lblCosto.Text = "Costo Total: ";
            // 
            // gbDatosGenerales
            // 
            this.gbDatosGenerales.Controls.Add(this.txtSS);
            this.gbDatosGenerales.Controls.Add(this.label2);
            this.gbDatosGenerales.Controls.Add(this.txtPeriodos);
            this.gbDatosGenerales.Controls.Add(this.btnGenerar);
            this.gbDatosGenerales.Controls.Add(this.label3);
            this.gbDatosGenerales.Controls.Add(this.txtInvIni);
            this.gbDatosGenerales.Controls.Add(this.label4);
            this.gbDatosGenerales.Controls.Add(this.label5);
            this.gbDatosGenerales.Controls.Add(this.txtHoras);
            this.gbDatosGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosGenerales.Location = new System.Drawing.Point(12, 31);
            this.gbDatosGenerales.Name = "gbDatosGenerales";
            this.gbDatosGenerales.Size = new System.Drawing.Size(427, 252);
            this.gbDatosGenerales.TabIndex = 70;
            this.gbDatosGenerales.TabStop = false;
            this.gbDatosGenerales.Text = "Datos Generales";
            // 
            // gbPersecucion
            // 
            this.gbPersecucion.Controls.Add(this.label6);
            this.gbPersecucion.Controls.Add(this.txtTrabajadores);
            this.gbPersecucion.Controls.Add(this.label7);
            this.gbPersecucion.Controls.Add(this.label8);
            this.gbPersecucion.Controls.Add(this.txtDespedir);
            this.gbPersecucion.Controls.Add(this.txtContratar);
            this.gbPersecucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersecucion.Location = new System.Drawing.Point(-1, 338);
            this.gbPersecucion.Name = "gbPersecucion";
            this.gbPersecucion.Size = new System.Drawing.Size(427, 173);
            this.gbPersecucion.TabIndex = 71;
            this.gbPersecucion.TabStop = false;
            this.gbPersecucion.Text = "Estrategia de Persecucion";
            // 
            // rbPersecucion
            // 
            this.rbPersecucion.AutoSize = true;
            this.rbPersecucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPersecucion.Location = new System.Drawing.Point(12, 300);
            this.rbPersecucion.Name = "rbPersecucion";
            this.rbPersecucion.Size = new System.Drawing.Size(250, 28);
            this.rbPersecucion.TabIndex = 72;
            this.rbPersecucion.TabStop = true;
            this.rbPersecucion.Text = "Estrategia de persecucion";
            this.rbPersecucion.UseVisualStyleBackColor = true;
            this.rbPersecucion.CheckedChanged += new System.EventHandler(this.rbPersecucion_CheckedChanged);
            // 
            // txtValorHora
            // 
            this.txtValorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorHora.Location = new System.Drawing.Point(239, 243);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(100, 22);
            this.txtValorHora.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 24);
            this.label9.TabIndex = 68;
            this.label9.Text = "Costo hora trabajada\r\n";
            // 
            // rbFuerzaNiv
            // 
            this.rbFuerzaNiv.AutoSize = true;
            this.rbFuerzaNiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFuerzaNiv.Location = new System.Drawing.Point(12, 517);
            this.rbFuerzaNiv.Name = "rbFuerzaNiv";
            this.rbFuerzaNiv.Size = new System.Drawing.Size(271, 28);
            this.rbFuerzaNiv.TabIndex = 73;
            this.rbFuerzaNiv.TabStop = true;
            this.rbFuerzaNiv.Text = "Estrategia de fuerza nivelada";
            this.rbFuerzaNiv.UseVisualStyleBackColor = true;
            this.rbFuerzaNiv.CheckedChanged += new System.EventHandler(this.rbFuerzaNiv_CheckedChanged);
            // 
            // gbFuerzaN
            // 
            this.gbFuerzaN.Controls.Add(this.txtMantener);
            this.gbFuerzaN.Controls.Add(this.txtEscasez);
            this.gbFuerzaN.Controls.Add(this.label11);
            this.gbFuerzaN.Controls.Add(this.label10);
            this.gbFuerzaN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFuerzaN.Location = new System.Drawing.Point(13, 564);
            this.gbFuerzaN.Name = "gbFuerzaN";
            this.gbFuerzaN.Size = new System.Drawing.Size(413, 116);
            this.gbFuerzaN.TabIndex = 74;
            this.gbFuerzaN.TabStop = false;
            this.gbFuerzaN.Text = "Fuerza Nivelada";
            // 
            // txtMantener
            // 
            this.txtMantener.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMantener.Location = new System.Drawing.Point(226, 75);
            this.txtMantener.Name = "txtMantener";
            this.txtMantener.Size = new System.Drawing.Size(100, 22);
            this.txtMantener.TabIndex = 68;
            // 
            // txtEscasez
            // 
            this.txtEscasez.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEscasez.Location = new System.Drawing.Point(226, 36);
            this.txtEscasez.Name = "txtEscasez";
            this.txtEscasez.Size = new System.Drawing.Size(100, 22);
            this.txtEscasez.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 24);
            this.label11.TabIndex = 62;
            this.label11.Text = "Costo de mantener\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 24);
            this.label10.TabIndex = 61;
            this.label10.Text = "Costo de escasez\r\n";
            // 
            // rbOutS
            // 
            this.rbOutS.AutoSize = true;
            this.rbOutS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOutS.Location = new System.Drawing.Point(13, 687);
            this.rbOutS.Name = "rbOutS";
            this.rbOutS.Size = new System.Drawing.Size(220, 28);
            this.rbOutS.TabIndex = 75;
            this.rbOutS.TabStop = true;
            this.rbOutS.Text = "Estrategia Outsoursing";
            this.rbOutS.UseVisualStyleBackColor = true;
            this.rbOutS.CheckedChanged += new System.EventHandler(this.rbOutS_CheckedChanged);
            // 
            // gbOutS
            // 
            this.gbOutS.Controls.Add(this.txtOutS);
            this.gbOutS.Controls.Add(this.label12);
            this.gbOutS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOutS.Location = new System.Drawing.Point(13, 737);
            this.gbOutS.Name = "gbOutS";
            this.gbOutS.Size = new System.Drawing.Size(413, 98);
            this.gbOutS.TabIndex = 76;
            this.gbOutS.TabStop = false;
            this.gbOutS.Text = "Outsoursing";
            // 
            // txtOutS
            // 
            this.txtOutS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutS.Location = new System.Drawing.Point(226, 39);
            this.txtOutS.Name = "txtOutS";
            this.txtOutS.Size = new System.Drawing.Size(100, 24);
            this.txtOutS.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 24);
            this.label12.TabIndex = 62;
            this.label12.Text = "Costo Outsoursing";
            // 
            // FrmPlaneacionAgregada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 886);
            this.Controls.Add(this.gbOutS);
            this.Controls.Add(this.rbOutS);
            this.Controls.Add(this.gbFuerzaN);
            this.Controls.Add(this.rbFuerzaNiv);
            this.Controls.Add(this.txtValorHora);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rbPersecucion);
            this.Controls.Add(this.gbPersecucion);
            this.Controls.Add(this.gbDatosGenerales);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dgvPlanificacion);
            this.Controls.Add(this.dgvDYD);
            this.Controls.Add(this.label1);
            this.Name = "FrmPlaneacionAgregada";
            this.Text = "FrmPlaneacionAgregada";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDYD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanificacion)).EndInit();
            this.gbDatosGenerales.ResumeLayout(false);
            this.gbDatosGenerales.PerformLayout();
            this.gbPersecucion.ResumeLayout(false);
            this.gbPersecucion.PerformLayout();
            this.gbFuerzaN.ResumeLayout(false);
            this.gbFuerzaN.PerformLayout();
            this.gbOutS.ResumeLayout(false);
            this.gbOutS.PerformLayout();
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
        private System.Windows.Forms.TextBox txtContratar;
        private System.Windows.Forms.TextBox txtDespedir;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.GroupBox gbDatosGenerales;
        private System.Windows.Forms.GroupBox gbPersecucion;
        private System.Windows.Forms.RadioButton rbPersecucion;
        private System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbFuerzaNiv;
        private System.Windows.Forms.GroupBox gbFuerzaN;
        private System.Windows.Forms.TextBox txtMantener;
        private System.Windows.Forms.TextBox txtEscasez;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbOutS;
        private System.Windows.Forms.GroupBox gbOutS;
        private System.Windows.Forms.TextBox txtOutS;
        private System.Windows.Forms.Label label12;
    }
}