using DataAcces.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.INVENTARIO
{
    public partial class FrmStock : Form
    {
        public FrmStock()
        {
            InitializeComponent();
        }

        private void btnSave_P_Click(object sender, EventArgs e)
        {
            Dialogs.DlgProducto dlg = new Dialogs.DlgProducto();
            dlg.Show();
        }
    }
}
