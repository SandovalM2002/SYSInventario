using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.INVENTARIO;

namespace Views
{
    public partial class FrmDashboard : Form
    {
        private string id_frm_child;

        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            AgregarFormHijo(new FrmHome());
            id_frm_child = FrmHome.getFrameName();
        }

        private void AgregarFormHijo(Object formHijo)
        {
            if (this.padre.Controls.Count > 0)
            {
                this.padre.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.padre.Controls.Add(fh);
            this.padre.Tag = fh;
            fh.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            if (id_frm_child != MODULO_I.FrmMenu_ModuloI.getFrameName())
            {
                AgregarFormHijo(new MODULO_I.FrmMenu_ModuloI());
                id_frm_child = MODULO_I.FrmMenu_ModuloI.getFrameName();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (id_frm_child != FrmHome.getFrameName())
            {
                AgregarFormHijo(new FrmHome());
                id_frm_child = FrmHome.getFrameName();
            }
        }
    }
}
