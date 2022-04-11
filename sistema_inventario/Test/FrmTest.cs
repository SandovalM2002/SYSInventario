using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.data;

namespace Test
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
           //string_Connection = "Integrated Security=SSPI;Persist Security Info=false;Initial Catalog=MAYER;Data Source=DESKTOP-CG4DUQL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode(txtNodo.Text);
            tvArbol.Nodes.Add(node);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode(cmbNodo.SelectedItem.ToString());
            tvArbol.SelectedNode.Nodes.Add(node);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tvArbol.SelectedNode.Remove();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tvArbol.SelectedNode.Text = txtSelect.Text;
        }

        private void tvArbol_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // get selected node text
            txtSelect.Text = tvArbol.SelectedNode.Text;

            // get selected node name
            txtSelect.Text = txtSelect.Text + tvArbol.SelectedNode.Name;
        }
    }
}
