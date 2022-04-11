using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class FrmDatagridNodo : Form
    {
        public FrmDatagridNodo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < treeView1.Nodes.Count; i++)
            {
                TreeNode node = treeView1.Nodes[i];

                Object[] row = new Object[node.Nodes.Count];

                for (int j = 0; j < node.Nodes.Count; j++)
                {
                    row[j] = node.Nodes[j].Text;
                }
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
