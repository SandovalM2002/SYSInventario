
namespace Test
{
    partial class FrmTest
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
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.cmbNodo = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAdd_Sub = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(12, 12);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(229, 303);
            this.tvArbol.TabIndex = 0;
            this.tvArbol.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvArbol_AfterSelect);
            // 
            // txtNodo
            // 
            this.txtNodo.Location = new System.Drawing.Point(276, 41);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(121, 25);
            this.txtNodo.TabIndex = 1;
            // 
            // cmbNodo
            // 
            this.cmbNodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNodo.FormattingEnabled = true;
            this.cmbNodo.Items.AddRange(new object[] {
            "Sub elemento 1",
            "Sub elemento 2"});
            this.cmbNodo.Location = new System.Drawing.Point(275, 118);
            this.cmbNodo.Name = "cmbNodo";
            this.cmbNodo.Size = new System.Drawing.Size(121, 27);
            this.cmbNodo.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(403, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 32);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd_Sub
            // 
            this.btnAdd_Sub.Location = new System.Drawing.Point(403, 113);
            this.btnAdd_Sub.Name = "btnAdd_Sub";
            this.btnAdd_Sub.Size = new System.Drawing.Size(121, 35);
            this.btnAdd_Sub.TabIndex = 4;
            this.btnAdd_Sub.Text = "Add Sub Nodo";
            this.btnAdd_Sub.UseVisualStyleBackColor = true;
            this.btnAdd_Sub.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del Nodo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre del Sub Nodo:";
            // 
            // txtSelect
            // 
            this.txtSelect.Location = new System.Drawing.Point(275, 186);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(249, 25);
            this.txtSelect.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nodo seleccionado";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(275, 220);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 32);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(403, 220);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 32);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmTest
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(620, 334);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd_Sub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbNodo);
            this.Controls.Add(this.txtNodo);
            this.Controls.Add(this.tvArbol);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AAAAA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.ComboBox cmbNodo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAdd_Sub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

