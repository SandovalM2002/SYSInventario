
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeriodos = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
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
            this.txtCostoUnitario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbPersecucion = new System.Windows.Forms.GroupBox();
            this.rbPersecucion = new System.Windows.Forms.RadioButton();
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
            this.dgvPlanificacion = new System.Windows.Forms.DataGridView();
            this.dgvDYD = new System.Windows.Forms.DataGridView();
            this.gbDatosGenerales.SuspendLayout();
            this.gbPersecucion.SuspendLayout();
            this.gbFuerzaN.SuspendLayout();
            this.gbOutS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDYD)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "Cantidad de periodos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 32);
            this.label1.TabIndex = 47;
            this.label1.Text = "Planificacion Agregada";
            // 
            // txtPeriodos
            // 
            this.txtPeriodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodos.Location = new System.Drawing.Point(163, 37);
            this.txtPeriodos.Margin = new System.Windows.Forms.Padding(2);
            this.txtPeriodos.MaxLength = 2;
            this.txtPeriodos.Name = "txtPeriodos";
            this.txtPeriodos.Size = new System.Drawing.Size(76, 26);
            this.txtPeriodos.TabIndex = 49;
            this.txtPeriodos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarNumerosEnteros);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(247, 30);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(70, 40);
            this.btnGenerar.TabIndex = 50;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "Inventario Inicial:\r\n";
            // 
            // txtInvIni
            // 
            this.txtInvIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvIni.Location = new System.Drawing.Point(163, 72);
            this.txtInvIni.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvIni.Name = "txtInvIni";
            this.txtInvIni.Size = new System.Drawing.Size(76, 26);
            this.txtInvIni.TabIndex = 54;
            this.txtInvIni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarNumerosDecimales);
            // 
            // txtSS
            // 
            this.txtSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSS.Location = new System.Drawing.Point(163, 101);
            this.txtSS.Margin = new System.Windows.Forms.Padding(2);
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(76, 26);
            this.txtSS.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 24);
            this.label4.TabIndex = 56;
            this.label4.Text = "% stock de seguridad";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.Location = new System.Drawing.Point(789, 43);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 30);
            this.btnCalcular.TabIndex = 57;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 24);
            this.label5.TabIndex = 58;
            this.label5.Text = "Horas requeridas";
            // 
            // txtHoras
            // 
            this.txtHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoras.Location = new System.Drawing.Point(163, 132);
            this.txtHoras.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(76, 26);
            this.txtHoras.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 24);
            this.label6.TabIndex = 60;
            this.label6.Text = "Trabajadores Actuales\r\n";
            // 
            // txtTrabajadores
            // 
            this.txtTrabajadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrabajadores.Location = new System.Drawing.Point(180, 31);
            this.txtTrabajadores.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrabajadores.Name = "txtTrabajadores";
            this.txtTrabajadores.Size = new System.Drawing.Size(122, 26);
            this.txtTrabajadores.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 24);
            this.label7.TabIndex = 62;
            this.label7.Text = "Costo de contratar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 101);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 24);
            this.label8.TabIndex = 63;
            this.label8.Text = "Costo de despedir\r\n";
            // 
            // txtContratar
            // 
            this.txtContratar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContratar.Location = new System.Drawing.Point(180, 65);
            this.txtContratar.Margin = new System.Windows.Forms.Padding(2);
            this.txtContratar.Name = "txtContratar";
            this.txtContratar.Size = new System.Drawing.Size(122, 26);
            this.txtContratar.TabIndex = 65;
            // 
            // txtDespedir
            // 
            this.txtDespedir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDespedir.Location = new System.Drawing.Point(180, 101);
            this.txtDespedir.Margin = new System.Windows.Forms.Padding(2);
            this.txtDespedir.Name = "txtDespedir";
            this.txtDespedir.Size = new System.Drawing.Size(122, 26);
            this.txtDespedir.TabIndex = 66;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(374, 49);
            this.lblCosto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(114, 24);
            this.lblCosto.TabIndex = 68;
            this.lblCosto.Text = "Costo Total: ";
            // 
            // gbDatosGenerales
            // 
            this.gbDatosGenerales.Controls.Add(this.txtCostoUnitario);
            this.gbDatosGenerales.Controls.Add(this.label13);
            this.gbDatosGenerales.Controls.Add(this.txtSS);
            this.gbDatosGenerales.Controls.Add(this.label2);
            this.gbDatosGenerales.Controls.Add(this.txtValorHora);
            this.gbDatosGenerales.Controls.Add(this.txtPeriodos);
            this.gbDatosGenerales.Controls.Add(this.label9);
            this.gbDatosGenerales.Controls.Add(this.btnGenerar);
            this.gbDatosGenerales.Controls.Add(this.label3);
            this.gbDatosGenerales.Controls.Add(this.txtInvIni);
            this.gbDatosGenerales.Controls.Add(this.label4);
            this.gbDatosGenerales.Controls.Add(this.label5);
            this.gbDatosGenerales.Controls.Add(this.txtHoras);
            this.gbDatosGenerales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosGenerales.Location = new System.Drawing.Point(11, 49);
            this.gbDatosGenerales.Margin = new System.Windows.Forms.Padding(2);
            this.gbDatosGenerales.Name = "gbDatosGenerales";
            this.gbDatosGenerales.Padding = new System.Windows.Forms.Padding(2);
            this.gbDatosGenerales.Size = new System.Drawing.Size(329, 233);
            this.gbDatosGenerales.TabIndex = 70;
            this.gbDatosGenerales.TabStop = false;
            this.gbDatosGenerales.Text = "Datos Generales";
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoUnitario.Location = new System.Drawing.Point(163, 185);
            this.txtCostoUnitario.Margin = new System.Windows.Forms.Padding(2);
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Size = new System.Drawing.Size(76, 26);
            this.txtCostoUnitario.TabIndex = 77;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 188);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 24);
            this.label13.TabIndex = 77;
            this.label13.Text = "Costo de la unidad\r\n";
            // 
            // txtValorHora
            // 
            this.txtValorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorHora.Location = new System.Drawing.Point(163, 159);
            this.txtValorHora.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(76, 26);
            this.txtValorHora.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 24);
            this.label9.TabIndex = 68;
            this.label9.Text = "Costo hora trabajada\r\n";
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
            this.gbPersecucion.Location = new System.Drawing.Point(11, 328);
            this.gbPersecucion.Margin = new System.Windows.Forms.Padding(2);
            this.gbPersecucion.Name = "gbPersecucion";
            this.gbPersecucion.Padding = new System.Windows.Forms.Padding(2);
            this.gbPersecucion.Size = new System.Drawing.Size(329, 141);
            this.gbPersecucion.TabIndex = 71;
            this.gbPersecucion.TabStop = false;
            // 
            // rbPersecucion
            // 
            this.rbPersecucion.AutoSize = true;
            this.rbPersecucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPersecucion.Location = new System.Drawing.Point(17, 302);
            this.rbPersecucion.Margin = new System.Windows.Forms.Padding(2);
            this.rbPersecucion.Name = "rbPersecucion";
            this.rbPersecucion.Size = new System.Drawing.Size(275, 28);
            this.rbPersecucion.TabIndex = 72;
            this.rbPersecucion.TabStop = true;
            this.rbPersecucion.Text = "Estrategia de persecución";
            this.rbPersecucion.UseVisualStyleBackColor = true;
            this.rbPersecucion.CheckedChanged += new System.EventHandler(this.rbPersecucion_CheckedChanged);
            // 
            // rbFuerzaNiv
            // 
            this.rbFuerzaNiv.AutoSize = true;
            this.rbFuerzaNiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFuerzaNiv.Location = new System.Drawing.Point(18, 473);
            this.rbFuerzaNiv.Margin = new System.Windows.Forms.Padding(2);
            this.rbFuerzaNiv.Name = "rbFuerzaNiv";
            this.rbFuerzaNiv.Size = new System.Drawing.Size(300, 28);
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
            this.gbFuerzaN.Location = new System.Drawing.Point(13, 512);
            this.gbFuerzaN.Margin = new System.Windows.Forms.Padding(2);
            this.gbFuerzaN.Name = "gbFuerzaN";
            this.gbFuerzaN.Padding = new System.Windows.Forms.Padding(2);
            this.gbFuerzaN.Size = new System.Drawing.Size(327, 94);
            this.gbFuerzaN.TabIndex = 74;
            this.gbFuerzaN.TabStop = false;
            // 
            // txtMantener
            // 
            this.txtMantener.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMantener.Location = new System.Drawing.Point(178, 61);
            this.txtMantener.Margin = new System.Windows.Forms.Padding(2);
            this.txtMantener.Name = "txtMantener";
            this.txtMantener.Size = new System.Drawing.Size(122, 26);
            this.txtMantener.TabIndex = 68;
            // 
            // txtEscasez
            // 
            this.txtEscasez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEscasez.Location = new System.Drawing.Point(178, 28);
            this.txtEscasez.Margin = new System.Windows.Forms.Padding(2);
            this.txtEscasez.Name = "txtEscasez";
            this.txtEscasez.Size = new System.Drawing.Size(122, 26);
            this.txtEscasez.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 61);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 24);
            this.label11.TabIndex = 62;
            this.label11.Text = "Costo de mantener\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 24);
            this.label10.TabIndex = 61;
            this.label10.Text = "Costo de escasez\r\n";
            // 
            // rbOutS
            // 
            this.rbOutS.AutoSize = true;
            this.rbOutS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOutS.Location = new System.Drawing.Point(18, 631);
            this.rbOutS.Margin = new System.Windows.Forms.Padding(2);
            this.rbOutS.Name = "rbOutS";
            this.rbOutS.Size = new System.Drawing.Size(242, 28);
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
            this.gbOutS.Location = new System.Drawing.Point(13, 657);
            this.gbOutS.Margin = new System.Windows.Forms.Padding(2);
            this.gbOutS.Name = "gbOutS";
            this.gbOutS.Padding = new System.Windows.Forms.Padding(2);
            this.gbOutS.Size = new System.Drawing.Size(327, 80);
            this.gbOutS.TabIndex = 76;
            this.gbOutS.TabStop = false;
            // 
            // txtOutS
            // 
            this.txtOutS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutS.Location = new System.Drawing.Point(178, 32);
            this.txtOutS.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutS.Name = "txtOutS";
            this.txtOutS.Size = new System.Drawing.Size(122, 26);
            this.txtOutS.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 32);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 24);
            this.label12.TabIndex = 62;
            this.label12.Text = "Costo Outsoursing";
            // 
            // dgvPlanificacion
            // 
            this.dgvPlanificacion.AllowUserToAddRows = false;
            this.dgvPlanificacion.AllowUserToDeleteRows = false;
            this.dgvPlanificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlanificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanificacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPlanificacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.dgvPlanificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlanificacion.CausesValidation = false;
            this.dgvPlanificacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPlanificacion.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvPlanificacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanificacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlanificacion.ColumnHeadersHeight = 42;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlanificacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlanificacion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPlanificacion.EnableHeadersVisualStyles = false;
            this.dgvPlanificacion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.dgvPlanificacion.Location = new System.Drawing.Point(378, 181);
            this.dgvPlanificacion.MultiSelect = false;
            this.dgvPlanificacion.Name = "dgvPlanificacion";
            this.dgvPlanificacion.ReadOnly = true;
            this.dgvPlanificacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanificacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPlanificacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(105)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPlanificacion.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPlanificacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanificacion.Size = new System.Drawing.Size(505, 556);
            this.dgvPlanificacion.TabIndex = 77;
            // 
            // dgvDYD
            // 
            this.dgvDYD.AllowUserToAddRows = false;
            this.dgvDYD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDYD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDYD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDYD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.dgvDYD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDYD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDYD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDYD.ColumnHeadersHeight = 39;
            this.dgvDYD.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(105)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDYD.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDYD.EnableHeadersVisualStyles = false;
            this.dgvDYD.GridColor = System.Drawing.Color.DimGray;
            this.dgvDYD.Location = new System.Drawing.Point(378, 79);
            this.dgvDYD.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDYD.Name = "dgvDYD";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDYD.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDYD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(105)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDYD.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDYD.RowTemplate.Height = 24;
            this.dgvDYD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDYD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDYD.Size = new System.Drawing.Size(505, 85);
            this.dgvDYD.TabIndex = 78;
            // 
            // FrmPlaneacionAgregada
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 790);
            this.Controls.Add(this.dgvDYD);
            this.Controls.Add(this.dgvPlanificacion);
            this.Controls.Add(this.gbOutS);
            this.Controls.Add(this.rbOutS);
            this.Controls.Add(this.gbFuerzaN);
            this.Controls.Add(this.rbFuerzaNiv);
            this.Controls.Add(this.rbPersecucion);
            this.Controls.Add(this.gbPersecucion);
            this.Controls.Add(this.gbDatosGenerales);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPlaneacionAgregada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPlaneacionAgregada";
            this.gbDatosGenerales.ResumeLayout(false);
            this.gbDatosGenerales.PerformLayout();
            this.gbPersecucion.ResumeLayout(false);
            this.gbPersecucion.PerformLayout();
            this.gbFuerzaN.ResumeLayout(false);
            this.gbFuerzaN.PerformLayout();
            this.gbOutS.ResumeLayout(false);
            this.gbOutS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDYD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeriodos;
        private System.Windows.Forms.Button btnGenerar;
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
        private System.Windows.Forms.TextBox txtCostoUnitario;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvPlanificacion;
        private System.Windows.Forms.DataGridView dgvDYD;
    }
}