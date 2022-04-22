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
        private int _row;
        public int id;
        public string nombre;
        public decimal costo;
        public decimal precio;
        public int stock;
        public int stock_s;

        public FrmStock()
        {
            InitializeComponent();
            _row = 0;
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
           
        }

    }
}
