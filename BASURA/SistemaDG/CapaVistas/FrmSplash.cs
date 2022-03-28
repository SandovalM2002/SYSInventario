using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistas
{
    public partial class FrmSplash : Form
    {

        public FrmSplash(String User)
        {
            InitializeComponent();
            lblUsuario.Text = User;
        }
        
        private void Inicio_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            barra.Value += 1;
            if (barra.Value == 100)
            {
                Inicio.Stop();
                Fin.Start();
            }
        }//----------------

        private void Fin_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                Fin.Stop();

                //Referencia

                FrmMenu menu = new FrmMenu();
                menu.Show();

                this.Hide();
            }
        }//------------------

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            Inicio.Start();

        }//-------------------------
    }//Final de la clase
}//------------------------
