﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoDeProduccion
{
    /// <summary>
    /// Lógica de interacción para MQSimple.xaml
    /// </summary>
    public partial class MQSimple : UserControl
    {
        public MQSimple()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {

            if(txtDemanda.Text.Equals("")|| txtCostoPedir.Text.Equals("")|| (txtCostoMan.Text.Equals("")&& txtTasa.Text.Equals("")))
            {
                MessageBox.Show("CAMPOS OBLIGATORIOS VACIOS", "MENSAJE DEL SISTEMA", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {

                txtResultados.Text = "";
            lblR.Visibility = Visibility.Visible;
            txtResultados.Visibility = Visibility.Visible;
            txtResultados.Text = "La cantidad óptima a pedir es de " + QOPT() + "\n \nEl número de pedidos ha hacerse al año sería de "
                + NPedidos() + "\n \nEl costo de anual sería de " + CostoTotal() + "\n \nEl tiempo de reaprovisionamiento o tiempo entre" +
                " dos pedidos consecutivos es " + TR() +
                " días"  ;

                if (!txtPlazo.Text.Equals(""))
                { 
                   txtResultados.Text = txtResultados.Text +
                " días\n\nEl punto de pedido o de reorden es de " + ROP() + " unidades en el inventario"; 
                
                }

            }
        }

        private int QOPT()
        {
            int eoq = (int)Math.Round(Math.Sqrt((Double)(2 * CalcularDemanda() * Convert.ToDecimal(txtCostoPedir.Text)) / (Double)(tasa()+CalcularCostoMantenerAnual())));
            return eoq;
        }

        private decimal NPedidos()
        {

            decimal pedidos = CalcularDemanda() / QOPT();
                pedidos = Math.Truncate( pedidos);
            return pedidos;
        }

        public decimal TR()
        {
            decimal c = Convert.ToDecimal(txtDias.Text);
            if (txtDias.Text.Equals(""))
            {
               c = Math.Truncate(365 / NPedidos());
            }
            else
            {
              c=  Math.Truncate(c / NPedidos());
            }
            return c;
        }

        private decimal CostoTotal()
        {
            decimal ct;
            int q = QOPT();
            int D = CalcularDemanda();
            decimal h = CalcularCostoMantenerAnual();
            decimal h2 = tasa();
            decimal s = Convert.ToDecimal(txtCostoPedir.Text);
            decimal c = Convert.ToDecimal(txtCostoProducto.Text);

            ct = Math.Round( (D * s / q) + (q *( h+h2) / 2) + (D * c),2);
            return ct;
        }

        private decimal ROP()
        {
            decimal a = Convert.ToDecimal( CalcularDemanda()) ;
            decimal b = Convert.ToDecimal(txtPlazo.Text);
            decimal c = Convert.ToDecimal(txtDias.Text);
            decimal ROP = 0;

            if (txtDias.Text.Equals(""))
            {
               ROP = (a / 365) * b;
            }
            else
            {
                ROP = (a / c) * b;
            }
           
            ROP =  Math.Round( ROP);
            return ROP;
        }
        private decimal CalcularCostoMantenerAnual()
        {
            decimal c = 0;

            if (!txtCostoMan.Text.Equals(""))
            {
                c = Convert.ToDecimal(txtCostoMan.Text);


                switch (cmbCMant.SelectedIndex)
                {
                    case 0:
                        break;

                    case 1:
                        c = c * 12;
                        break;

                    case 2:
                        c = c * 52;
                        break;


                }
            }
           
            return c;
        }

        public decimal tasa()
        {
            decimal c = 0;
            decimal costop = Convert.ToDecimal(txtCostoProducto.Text);
            if (!txtTasa.Text.Equals(""))
            {
                c = Convert.ToDecimal(txtTasa.Text);

                c = (c / 100) * costop;
            }

            return c;
        }
        private int CalcularDemanda()
        {
            int d = Convert.ToInt32(txtDemanda.Text);
            switch (cmbDemanda.SelectedIndex)
            {
                case 0:
                    break;

                case 1:
                    d = d * 12;
                    break;

                case 2:
                    d = d * 52;
                    break;

                case 3:
                    d = d * 365;
                    break;
            }

            return d;
        }

        private void txtDemanda_KeyDown(object sender, KeyEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtCostoPedir_KeyDown(object sender, KeyEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtCostoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtCostoMan_KeyDown(object sender, KeyEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtPlazo_KeyDown(object sender, KeyEventArgs e)
        {
            soloNumeros(e);
        }

        public static void soloNumeros( KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.OemComma
                ||e.Key == Key.OemPeriod)
            {

                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtTasa_KeyDown(object sender, KeyEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtDias_KeyDown(object sender, KeyEventArgs e)
        {
            soloNumeros(e);
        }
    }
}
