﻿using DataAcces.Controller;
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
        private static string id_frm = "STOCK";

        public FrmStock()
        {
            InitializeComponent();
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
           
        }
        
        public static string getFrameName()
        {
            return id_frm;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

        }
    }
}