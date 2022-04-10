
namespace Views.Modelo_EOQ_ABCC
{
    partial class ModelosCantidadOptima
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbTasaMan = new System.Windows.Forms.ComboBox();
            this.cbCostoMant = new System.Windows.Forms.ComboBox();
            this.cbDemanda = new System.Windows.Forms.ComboBox();
            this.txtCalcular = new System.Windows.Forms.Button();
            this.txtDiasH = new System.Windows.Forms.TextBox();
            this.txtPlazoEnt = new System.Windows.Forms.TextBox();
            this.txtTasaMant = new System.Windows.Forms.TextBox();
            this.txtCostoMant = new System.Windows.Forms.TextBox();
            this.txtCostoProd = new System.Windows.Forms.TextBox();
            this.txtCostoPedido = new System.Windows.Forms.TextBox();
            this.txtDemanda = new System.Windows.Forms.TextBox();
            this.rbTasaMan = new System.Windows.Forms.RadioButton();
            this.rbCostoMant = new System.Windows.Forms.RadioButton();
            this.GraficaEOQ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCostoT = new System.Windows.Forms.Label();
            this.lblRop = new System.Windows.Forms.Label();
            this.lblEQO = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvABC = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrCompra = new System.Windows.Forms.TextBox();
            this.txtPrVenta = new System.Windows.Forms.TextBox();
            this.txtPrReventa = new System.Windows.Forms.TextBox();
            this.btnCalcularPU = new System.Windows.Forms.Button();
            this.lblPF = new System.Windows.Forms.Label();
            this.lblPS = new System.Windows.Forms.Label();
            this.lblCOPU = new System.Windows.Forms.Label();
            this.txtDemPU = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDesvPU = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaEOQ)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvABC)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1043, 591);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbTasaMan);
            this.tabPage1.Controls.Add(this.cbCostoMant);
            this.tabPage1.Controls.Add(this.cbDemanda);
            this.tabPage1.Controls.Add(this.txtCalcular);
            this.tabPage1.Controls.Add(this.txtDiasH);
            this.tabPage1.Controls.Add(this.txtPlazoEnt);
            this.tabPage1.Controls.Add(this.txtTasaMant);
            this.tabPage1.Controls.Add(this.txtCostoMant);
            this.tabPage1.Controls.Add(this.txtCostoProd);
            this.tabPage1.Controls.Add(this.txtCostoPedido);
            this.tabPage1.Controls.Add(this.txtDemanda);
            this.tabPage1.Controls.Add(this.rbTasaMan);
            this.tabPage1.Controls.Add(this.rbCostoMant);
            this.tabPage1.Controls.Add(this.GraficaEOQ);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblCostoT);
            this.tabPage1.Controls.Add(this.lblRop);
            this.tabPage1.Controls.Add(this.lblEQO);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1035, 562);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modelo EOQ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbTasaMan
            // 
            this.cbTasaMan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTasaMan.Enabled = false;
            this.cbTasaMan.FormattingEnabled = true;
            this.cbTasaMan.Items.AddRange(new object[] {
            "Anual",
            "Mensual",
            "Semanal",
            "Diaria"});
            this.cbTasaMan.Location = new System.Drawing.Point(453, 206);
            this.cbTasaMan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTasaMan.Name = "cbTasaMan";
            this.cbTasaMan.Size = new System.Drawing.Size(83, 24);
            this.cbTasaMan.TabIndex = 63;
            this.cbTasaMan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCostoMant_KeyPress);
            // 
            // cbCostoMant
            // 
            this.cbCostoMant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCostoMant.Enabled = false;
            this.cbCostoMant.FormattingEnabled = true;
            this.cbCostoMant.Items.AddRange(new object[] {
            "Anual",
            "Mensual",
            "Semanal",
            "Diaria"});
            this.cbCostoMant.Location = new System.Drawing.Point(453, 246);
            this.cbCostoMant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCostoMant.Name = "cbCostoMant";
            this.cbCostoMant.Size = new System.Drawing.Size(83, 24);
            this.cbCostoMant.TabIndex = 62;
            // 
            // cbDemanda
            // 
            this.cbDemanda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDemanda.FormattingEnabled = true;
            this.cbDemanda.Items.AddRange(new object[] {
            "Anual",
            "Mensual",
            "Semanal",
            "Diaria"});
            this.cbDemanda.Location = new System.Drawing.Point(453, 92);
            this.cbDemanda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDemanda.Name = "cbDemanda";
            this.cbDemanda.Size = new System.Drawing.Size(83, 24);
            this.cbDemanda.TabIndex = 61;
            this.cbDemanda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCostoMant_KeyPress);
            // 
            // txtCalcular
            // 
            this.txtCalcular.Location = new System.Drawing.Point(313, 385);
            this.txtCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCalcular.Name = "txtCalcular";
            this.txtCalcular.Size = new System.Drawing.Size(89, 26);
            this.txtCalcular.TabIndex = 60;
            this.txtCalcular.Text = "Calcular";
            this.txtCalcular.UseVisualStyleBackColor = true;
            this.txtCalcular.Click += new System.EventHandler(this.txtCalcular_Click);
            // 
            // txtDiasH
            // 
            this.txtDiasH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiasH.Location = new System.Drawing.Point(287, 341);
            this.txtDiasH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiasH.Name = "txtDiasH";
            this.txtDiasH.Size = new System.Drawing.Size(145, 28);
            this.txtDiasH.TabIndex = 58;
            // 
            // txtPlazoEnt
            // 
            this.txtPlazoEnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlazoEnt.Location = new System.Drawing.Point(287, 295);
            this.txtPlazoEnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlazoEnt.Name = "txtPlazoEnt";
            this.txtPlazoEnt.Size = new System.Drawing.Size(145, 28);
            this.txtPlazoEnt.TabIndex = 57;
            // 
            // txtTasaMant
            // 
            this.txtTasaMant.Enabled = false;
            this.txtTasaMant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTasaMant.Location = new System.Drawing.Point(287, 206);
            this.txtTasaMant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTasaMant.Name = "txtTasaMant";
            this.txtTasaMant.Size = new System.Drawing.Size(145, 28);
            this.txtTasaMant.TabIndex = 56;
            // 
            // txtCostoMant
            // 
            this.txtCostoMant.Enabled = false;
            this.txtCostoMant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoMant.Location = new System.Drawing.Point(287, 246);
            this.txtCostoMant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCostoMant.Name = "txtCostoMant";
            this.txtCostoMant.Size = new System.Drawing.Size(145, 28);
            this.txtCostoMant.TabIndex = 55;
            // 
            // txtCostoProd
            // 
            this.txtCostoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoProd.Location = new System.Drawing.Point(287, 167);
            this.txtCostoProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCostoProd.Name = "txtCostoProd";
            this.txtCostoProd.Size = new System.Drawing.Size(145, 28);
            this.txtCostoProd.TabIndex = 54;
            // 
            // txtCostoPedido
            // 
            this.txtCostoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoPedido.Location = new System.Drawing.Point(287, 129);
            this.txtCostoPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCostoPedido.Name = "txtCostoPedido";
            this.txtCostoPedido.Size = new System.Drawing.Size(145, 28);
            this.txtCostoPedido.TabIndex = 53;
            // 
            // txtDemanda
            // 
            this.txtDemanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDemanda.Location = new System.Drawing.Point(287, 92);
            this.txtDemanda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDemanda.Name = "txtDemanda";
            this.txtDemanda.Size = new System.Drawing.Size(145, 28);
            this.txtDemanda.TabIndex = 59;
            // 
            // rbTasaMan
            // 
            this.rbTasaMan.AutoSize = true;
            this.rbTasaMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTasaMan.Location = new System.Drawing.Point(28, 199);
            this.rbTasaMan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTasaMan.Name = "rbTasaMan";
            this.rbTasaMan.Size = new System.Drawing.Size(248, 28);
            this.rbTasaMan.TabIndex = 52;
            this.rbTasaMan.TabStop = true;
            this.rbTasaMan.Text = "Tasa de mantenimiento %\r\n";
            this.rbTasaMan.UseVisualStyleBackColor = true;
            this.rbTasaMan.CheckedChanged += new System.EventHandler(this.rbTasaMan_CheckedChanged);
            // 
            // rbCostoMant
            // 
            this.rbCostoMant.AutoSize = true;
            this.rbCostoMant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCostoMant.Location = new System.Drawing.Point(28, 240);
            this.rbCostoMant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCostoMant.Name = "rbCostoMant";
            this.rbCostoMant.Size = new System.Drawing.Size(191, 28);
            this.rbCostoMant.TabIndex = 51;
            this.rbCostoMant.TabStop = true;
            this.rbCostoMant.Text = "Costo de mantener";
            this.rbCostoMant.UseVisualStyleBackColor = true;
            this.rbCostoMant.CheckedChanged += new System.EventHandler(this.rbCostoMant_CheckedChanged);
            // 
            // GraficaEOQ
            // 
            this.GraficaEOQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.GraficaEOQ.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GraficaEOQ.Legends.Add(legend1);
            this.GraficaEOQ.Location = new System.Drawing.Point(542, 222);
            this.GraficaEOQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GraficaEOQ.Name = "GraficaEOQ";
            this.GraficaEOQ.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.Legend = "Legend1";
            series1.Name = "ModeloQ";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "ROP";
            this.GraficaEOQ.Series.Add(series1);
            this.GraficaEOQ.Series.Add(series2);
            this.GraficaEOQ.Size = new System.Drawing.Size(470, 311);
            this.GraficaEOQ.TabIndex = 50;
            this.GraficaEOQ.Text = "chart1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 24);
            this.label8.TabIndex = 42;
            this.label8.Text = "Dias habiles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "Plazo de entrega dias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 24);
            this.label4.TabIndex = 44;
            this.label4.Text = "Costo del producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "Costo del pedido";
            // 
            // lblCostoT
            // 
            this.lblCostoT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCostoT.AutoSize = true;
            this.lblCostoT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoT.Location = new System.Drawing.Point(793, 161);
            this.lblCostoT.Name = "lblCostoT";
            this.lblCostoT.Size = new System.Drawing.Size(109, 24);
            this.lblCostoT.TabIndex = 49;
            this.lblCostoT.Text = "Costo Total:";
            // 
            // lblRop
            // 
            this.lblRop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRop.AutoSize = true;
            this.lblRop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRop.Location = new System.Drawing.Point(793, 129);
            this.lblRop.Name = "lblRop";
            this.lblRop.Size = new System.Drawing.Size(55, 24);
            this.lblRop.TabIndex = 48;
            this.lblRop.Text = "ROP:";
            // 
            // lblEQO
            // 
            this.lblEQO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEQO.AutoSize = true;
            this.lblEQO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEQO.Location = new System.Drawing.Point(793, 94);
            this.lblEQO.Name = "lblEQO";
            this.lblEQO.Size = new System.Drawing.Size(92, 24);
            this.lblEQO.TabIndex = 47;
            this.lblEQO.Text = "Q optimo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 46;
            this.label2.Text = "Demanda promedio";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(764, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 32);
            this.label6.TabIndex = 41;
            this.label6.Text = "Resultados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 40;
            this.label1.Text = "Datos";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1035, 562);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modelo ABC";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvABC);
            this.panel1.Location = new System.Drawing.Point(151, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 384);
            this.panel1.TabIndex = 0;
            // 
            // dgvABC
            // 
            this.dgvABC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvABC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvABC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvABC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvABC.Location = new System.Drawing.Point(0, 0);
            this.dgvABC.Name = "dgvABC";
            this.dgvABC.RowHeadersWidth = 51;
            this.dgvABC.RowTemplate.Height = 24;
            this.dgvABC.Size = new System.Drawing.Size(682, 384);
            this.dgvABC.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtDesvPU);
            this.tabPage3.Controls.Add(this.txtDemPU);
            this.tabPage3.Controls.Add(this.btnCalcularPU);
            this.tabPage3.Controls.Add(this.txtPrReventa);
            this.tabPage3.Controls.Add(this.txtPrVenta);
            this.tabPage3.Controls.Add(this.txtPrCompra);
            this.tabPage3.Controls.Add(this.lblCOPU);
            this.tabPage3.Controls.Add(this.lblPS);
            this.tabPage3.Controls.Add(this.lblPF);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1035, 562);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pedido Unico";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Modelo Pedido Unico";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Precio de Compra";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Precio de Venta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "Precio de Reventa";
            // 
            // txtPrCompra
            // 
            this.txtPrCompra.Location = new System.Drawing.Point(258, 108);
            this.txtPrCompra.Name = "txtPrCompra";
            this.txtPrCompra.Size = new System.Drawing.Size(148, 22);
            this.txtPrCompra.TabIndex = 2;
            // 
            // txtPrVenta
            // 
            this.txtPrVenta.Location = new System.Drawing.Point(258, 151);
            this.txtPrVenta.Name = "txtPrVenta";
            this.txtPrVenta.Size = new System.Drawing.Size(148, 22);
            this.txtPrVenta.TabIndex = 3;
            // 
            // txtPrReventa
            // 
            this.txtPrReventa.Location = new System.Drawing.Point(258, 202);
            this.txtPrReventa.Name = "txtPrReventa";
            this.txtPrReventa.Size = new System.Drawing.Size(148, 22);
            this.txtPrReventa.TabIndex = 4;
            // 
            // btnCalcularPU
            // 
            this.btnCalcularPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularPU.Location = new System.Drawing.Point(206, 492);
            this.btnCalcularPU.Name = "btnCalcularPU";
            this.btnCalcularPU.Size = new System.Drawing.Size(107, 30);
            this.btnCalcularPU.TabIndex = 5;
            this.btnCalcularPU.Text = "Calcular";
            this.btnCalcularPU.UseVisualStyleBackColor = true;
            this.btnCalcularPU.Click += new System.EventHandler(this.btnCalcularPU_Click);
            // 
            // lblPF
            // 
            this.lblPF.AutoSize = true;
            this.lblPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPF.Location = new System.Drawing.Point(53, 352);
            this.lblPF.Name = "lblPF";
            this.lblPF.Size = new System.Drawing.Size(193, 24);
            this.lblPF.TabIndex = 1;
            this.lblPF.Text = "Precio del faltante es: ";
            // 
            // lblPS
            // 
            this.lblPS.AutoSize = true;
            this.lblPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPS.Location = new System.Drawing.Point(53, 395);
            this.lblPS.Name = "lblPS";
            this.lblPS.Size = new System.Drawing.Size(208, 24);
            this.lblPS.TabIndex = 1;
            this.lblPS.Text = "Precio del sobrante es: ";
            // 
            // lblCOPU
            // 
            this.lblCOPU.AutoSize = true;
            this.lblCOPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCOPU.Location = new System.Drawing.Point(53, 436);
            this.lblCOPU.Name = "lblCOPU";
            this.lblCOPU.Size = new System.Drawing.Size(217, 24);
            this.lblCOPU.TabIndex = 1;
            this.lblCOPU.Text = "Cantidad Optima a pedir:\r\n";
            // 
            // txtDemPU
            // 
            this.txtDemPU.Location = new System.Drawing.Point(258, 293);
            this.txtDemPU.Name = "txtDemPU";
            this.txtDemPU.Size = new System.Drawing.Size(148, 22);
            this.txtDemPU.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(49, 290);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 24);
            this.label15.TabIndex = 1;
            this.label15.Text = "Demanda Diaria";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(49, 246);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(181, 24);
            this.label16.TabIndex = 1;
            this.label16.Text = "Desviacion Estandar";
            // 
            // txtDesvPU
            // 
            this.txtDesvPU.Location = new System.Drawing.Point(258, 247);
            this.txtDesvPU.Name = "txtDesvPU";
            this.txtDesvPU.Size = new System.Drawing.Size(148, 22);
            this.txtDesvPU.TabIndex = 7;
            // 
            // ModelosCantidadOptima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1043, 591);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ModelosCantidadOptima";
            this.Text = "ModelosCantidadOptima";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ModelosCantidadOptima_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaEOQ)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvABC)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbTasaMan;
        private System.Windows.Forms.ComboBox cbCostoMant;
        private System.Windows.Forms.ComboBox cbDemanda;
        private System.Windows.Forms.Button txtCalcular;
        private System.Windows.Forms.TextBox txtDiasH;
        private System.Windows.Forms.TextBox txtPlazoEnt;
        private System.Windows.Forms.TextBox txtTasaMant;
        private System.Windows.Forms.TextBox txtCostoMant;
        private System.Windows.Forms.TextBox txtCostoProd;
        private System.Windows.Forms.TextBox txtCostoPedido;
        private System.Windows.Forms.TextBox txtDemanda;
        private System.Windows.Forms.RadioButton rbTasaMan;
        private System.Windows.Forms.RadioButton rbCostoMant;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficaEOQ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCostoT;
        private System.Windows.Forms.Label lblRop;
        private System.Windows.Forms.Label lblEQO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvABC;
        private System.Windows.Forms.TextBox txtDemPU;
        private System.Windows.Forms.Button btnCalcularPU;
        private System.Windows.Forms.TextBox txtPrReventa;
        private System.Windows.Forms.TextBox txtPrVenta;
        private System.Windows.Forms.TextBox txtPrCompra;
        private System.Windows.Forms.Label lblCOPU;
        private System.Windows.Forms.Label lblPS;
        private System.Windows.Forms.Label lblPF;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDesvPU;
    }
}