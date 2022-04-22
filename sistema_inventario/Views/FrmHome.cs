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
    public partial class FrmHome : Form
    {
        public static string id_frm = "HOME";
        public FrmHome()
        {
            InitializeComponent();
        }

        public static string getFrameName()
        {
            return id_frm;
        } 
    }
}
