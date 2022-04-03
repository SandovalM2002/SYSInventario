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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnPModulo_Click(object sender, EventArgs e)
        {
            AgregarFormHijo(new Modelo_EOQ_ABCC.ModelosCantidadOptima());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AgregarFormHijo(new AcercaDe());
        }

        private void AgregarFormHijo(Object formHijo)
        {
            if (this.padre.Controls.Count > 0) {
                this.padre.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.padre.Controls.Add(fh);
            this.padre.Tag = fh;
            fh.Show();
        }
    }
}
