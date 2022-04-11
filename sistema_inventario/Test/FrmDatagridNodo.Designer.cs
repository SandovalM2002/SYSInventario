
namespace Test
{
    partial class FrmDatagridNodo
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("NEGRO");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("HARINA", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("PRODUCTO", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Padre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(12, 12);
            this.tvArbol.Name = "tvArbol";
            treeNode1.Name = "NEGRO";
            treeNode1.Text = "NEGRO";
            treeNode2.Name = "HARINA";
            treeNode2.Text = "HARINA";
            treeNode3.Name = "PRODUCTO";
            treeNode3.Text = "PRODUCTO";
            this.tvArbol.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.tvArbol.Size = new System.Drawing.Size(272, 293);
            this.tvArbol.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "--->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Padre,
            this.Hijo});
            this.dataGridView1.Location = new System.Drawing.Point(401, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(387, 293);
            this.dataGridView1.TabIndex = 3;
            // 
            // Padre
            // 
            this.Padre.HeaderText = "Padre";
            this.Padre.Name = "Padre";
            this.Padre.ReadOnly = true;
            // 
            // Hijo
            // 
            this.Hijo.HeaderText = "Hijo";
            this.Hijo.Name = "Hijo";
            this.Hijo.ReadOnly = true;
            // 
            // FrmDatagridNodo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(804, 323);
            this.Controls.Add(this.tvArbol);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmDatagridNodo";
            this.Text = "FrmDatagridNodo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Padre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hijo;
    }
}