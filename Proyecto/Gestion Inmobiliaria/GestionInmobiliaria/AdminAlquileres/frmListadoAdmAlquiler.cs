using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.AdminAlquileres
{
    public partial class frmListadoAdmAlquiler : Form
    {
        public frmListadoAdmAlquiler()
        {
            InitializeComponent();


            cbFiltro.Items.Add("Alquileres con contrato vigente");
            cbFiltro.Items.Add("Todos los Alquileres");
            cbFiltro.SelectedIndex = 0;

            ListViewItem item = new ListViewItem();
            item.Text = "Emilio Luis Davidis";
            item.SubItems.Add("P00032 - Agustin Alvarez 2578 PB '2'");
            item.SubItems.Add("Carlos Perez");

            lvAdmAlquileres.Items.Add(item);

            lvAdmAlquileres.Focus();



        }

        private void lvAdmAlquileres_DoubleClick(object sender, EventArgs e)
        {

            new frmFichaAdmAlquileres().ShowDialog();


        }



    }
}