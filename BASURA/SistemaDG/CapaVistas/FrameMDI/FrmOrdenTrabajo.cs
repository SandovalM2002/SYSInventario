using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using System.Windows.Forms;

namespace CapaVistas.FrameMDI
{
    public partial class FrmOrdenTrabajo : Form
    {
        public FrmOrdenTrabajo()
        {
            InitializeComponent();
        }

        private void VerTabla()
        {
            dgvOrdenTrabajo.DataSource = null;
            dgvOrdenTrabajo.DataSource = OrdenTrabajo_Controller.ViewDataOrdenTrabajo();
        }

        private void FrmOrdenTrabajo_Load(object sender, EventArgs e)
        {
            VerTabla();
        }
    }
}
