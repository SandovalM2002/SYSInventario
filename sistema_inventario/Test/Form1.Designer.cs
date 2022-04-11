
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
            this.arbol = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnElemento = new System.Windows.Forms.Button();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNodo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarElem = new System.Windows.Forms.Button();
            this.btnEliminarNodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arbol
            // 
            this.arbol.Location = new System.Drawing.Point(31, 48);
            this.arbol.Name = "arbol";
            this.arbol.Size = new System.Drawing.Size(173, 331);
            this.arbol.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "MRP Nodos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Elementos de cada Nodo";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(236, 48);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(159, 331);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnElemento
            // 
            this.btnElemento.Enabled = false;
            this.btnElemento.Location = new System.Drawing.Point(442, 347);
            this.btnElemento.Name = "btnElemento";
            this.btnElemento.Size = new System.Drawing.Size(101, 32);
            this.btnElemento.TabIndex = 43;
            this.btnElemento.Text = "Añadir elemento";
            this.btnElemento.UseVisualStyleBackColor = true;
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(442, 172);
            this.txtElemento.Multiline = true;
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(278, 152);
            this.txtElemento.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 19);
            this.label5.TabIndex = 41;
            this.label5.Text = "Nuevo elemento";
            // 
            // btnNodo
            // 
            this.btnNodo.Location = new System.Drawing.Point(442, 80);
            this.btnNodo.Name = "btnNodo";
            this.btnNodo.Size = new System.Drawing.Size(101, 38);
            this.btnNodo.TabIndex = 40;
            this.btnNodo.Text = "Añadir nodo";
            this.btnNodo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "Nuevo nodo";
            // 
            // txtNodo
            // 
            this.txtNodo.Location = new System.Drawing.Point(442, 48);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(278, 25);
            this.txtNodo.TabIndex = 38;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(656, 347);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 32);
            this.btnSalir.TabIndex = 46;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEliminarElem
            // 
            this.btnEliminarElem.Location = new System.Drawing.Point(549, 347);
            this.btnEliminarElem.Name = "btnEliminarElem";
            this.btnEliminarElem.Size = new System.Drawing.Size(101, 32);
            this.btnEliminarElem.TabIndex = 45;
            this.btnEliminarElem.Text = "Eliminar elemento";
            this.btnEliminarElem.UseVisualStyleBackColor = true;
            // 
            // btnEliminarNodo
            // 
            this.btnEliminarNodo.Location = new System.Drawing.Point(549, 80);
            this.btnEliminarNodo.Name = "btnEliminarNodo";
            this.btnEliminarNodo.Size = new System.Drawing.Size(101, 38);
            this.btnEliminarNodo.TabIndex = 44;
            this.btnEliminarNodo.Text = "Eliminar nodo";
            this.btnEliminarNodo.UseVisualStyleBackColor = true;
            // 
            // FrmTest
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(751, 424);
            this.Controls.Add(this.btnElemento);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNodo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarElem);
            this.Controls.Add(this.btnEliminarNodo);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arbol);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AAAAA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView arbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnElemento;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminarElem;
        private System.Windows.Forms.Button btnEliminarNodo;
    }
}

