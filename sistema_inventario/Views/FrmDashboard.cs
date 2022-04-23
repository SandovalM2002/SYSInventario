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
using Views.MRP;

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
            if (id_frm_child != FrmStock.getFrameName())
            {
                AgregarFormHijo(new FrmStock());
                id_frm_child = FrmStock.getFrameName();
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

        private void btnEOQ_Click(object sender, EventArgs e)
        {
            if (id_frm_child != Views.Modelo_EOQ_ABCC.FrmGestion.getFrameName())
            {
                AgregarFormHijo(new Modelo_EOQ_ABCC.FrmGestion());
                id_frm_child = Modelo_EOQ_ABCC.FrmGestion.getFrameName();
            }
        }

        private void btnMRP_Click(object sender, EventArgs e)
        {
            if (id_frm_child != FrmMRP.getFrameName())
            {
                AgregarFormHijo(new FrmMRP());
                id_frm_child = FrmMRP.getFrameName();
            }
        }

        private void btnPlaneacion_Agregada_Click(object sender, EventArgs e)
        {
            if (id_frm_child != Views.Planeacion_Agregada.FrmPlaneacionAgregada.getFrame())
            {
                AgregarFormHijo(new Planeacion_Agregada.FrmPlaneacionAgregada());
                id_frm_child = Planeacion_Agregada.FrmPlaneacionAgregada.getFrame();
            }
        }
    }
}
