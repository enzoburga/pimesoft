using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI
{
    public partial class frmStartUp : Form
    {
        public frmStartUp()
        {
            InitializeComponent();
        }



        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Propiedades.FrmListadoPropiedades frmListado = new GI.UI.Propiedades.FrmListadoPropiedades(typeof(GI.BR.Propiedades.Venta));
            frmListado.MdiParent = this;
            frmListado.Show();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes.frmListadoClientes frmListado = new GI.UI.Clientes.frmListadoClientes();
            frmListado.MdiParent = this;
            frmListado.Show();
        }

        private void administraciónDeAlquileresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminAlquileres.frmListadoAdmAlquiler frmListado = new AdminAlquileres.frmListadoAdmAlquiler();
            frmListado.MdiParent = this;
            frmListado.Show();
        }

        private void toolStripStatusEventos_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusSincronizacion_DoubleClick(object sender, EventArgs e)
        {

        }

        private void toolStripStatusEventos_Click(object sender, EventArgs e)
        {
            new frmPopUpEventos().ShowDialog();
        }
    }
}