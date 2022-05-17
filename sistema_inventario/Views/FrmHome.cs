using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class principal : Form
    {
        public static string id_frm = "HOME";
        public principal()
        {
            InitializeComponent();
        }

        public static string getFrameName()
        {
            return id_frm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void title_var_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hora_Tick(object sender, EventArgs e)
        {
            lblReloj.Text=DateTime.Now.ToLongTimeString();
            lblFecha.Text=DateTime.Now.ToLongDateString();
        }
    }
}
