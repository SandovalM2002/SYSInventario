using CapaNegocio;
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
    public partial class FrmLogin : Form
    {
        //Variables
        static FrmLogin _obj;
        FrmSplash splash;

        public FrmLogin()
        {
            InitializeComponent();
        }

        //Usuario
        public TextBox Usuer
        {
            get
            {
                return txtUsuario;
            }
            set
            {
                txtUsuario = value;
            }
        }

        public static FrmLogin Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FrmLogin();
                }
                return _obj;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string User;
            string Pass;

            User = txtUsuario.Text;
            Pass = txtContra.Text;

          //  Usuario_Controller.SearchDataUsuario();

            if (User == "Omar" && Pass == "123")
            {
                splash = new FrmSplash(User);
                splash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Logeado Incorrecto");
            }
        }
        
    }
}
