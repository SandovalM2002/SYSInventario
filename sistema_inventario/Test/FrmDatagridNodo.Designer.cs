
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
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Node27");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Node28");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Node29");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("A", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Node30");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Node31");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("B", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Node32");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Node33");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Node34");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("B", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Node35");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Node36");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Node37");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("C", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode16.Name = "Node27";
            treeNode16.Text = "Node27";
            treeNode17.Name = "Node28";
            treeNode17.Text = "Node28";
            treeNode18.Name = "Node29";
            treeNode18.Text = "Node29";
            treeNode19.Name = "A";
            treeNode19.Text = "A";
            treeNode20.Name = "Node30";
            treeNode20.Text = "Node30";
            treeNode21.Name = "Node31";
            treeNode21.Text = "Node31";
            treeNode22.Name = "B";
            treeNode22.Text = "B";
            treeNode23.Name = "Node32";
            treeNode23.Text = "Node32";
            treeNode24.Name = "Node33";
            treeNode24.Text = "Node33";
            treeNode25.Name = "Node34";
            treeNode25.Text = "Node34";
            treeNode26.Name = "B";
            treeNode26.Text = "B";
            treeNode27.Name = "Node35";
            treeNode27.Text = "Node35";
            treeNode28.Name = "Node36";
            treeNode28.Text = "Node36";
            treeNode29.Name = "Node37";
            treeNode29.Text = "Node37";
            treeNode30.Name = "C";
            treeNode30.Text = "C";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode22,
            treeNode26,
            treeNode30});
            this.treeView1.Size = new System.Drawing.Size(272, 293);
            this.treeView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 139);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(401, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(387, 293);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // FrmDatagridNodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 323);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmDatagridNodo";
            this.Text = "FrmDatagridNodo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}