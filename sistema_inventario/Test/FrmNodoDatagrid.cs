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
    public partial class FrmNodoDatagrid : Form
    {
        public FrmNodoDatagrid()
        {
            InitializeComponent();
        }

        private void FrmNodoDatagrid_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            // add columns to datatable
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Age", typeof(int));

            // add rows to datatable
            table.Rows.Add(1, "First A", "Last A", 10);
            table.Rows.Add(2, "First B", "Last B", 20);
            table.Rows.Add(3, "First C", "Last C", 30);
            table.Rows.Add(4, "First D", "Last D", 40);
            table.Rows.Add(5, "First E", "Last E", 50);
            table.Rows.Add(6, "First F", "Last F", 60);
            table.Rows.Add(7, "First G", "Last G", 70);
            table.Rows.Add(8, "First H", "Last H", 80);

            dataGridView1.DataSource = table;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int rowIndex = i + 1;
                TreeNode node = new TreeNode("Row_" + rowIndex);
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    node.Nodes.Add(dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
                treeView1.Nodes.Add(node);
            }
        }
    }
}
