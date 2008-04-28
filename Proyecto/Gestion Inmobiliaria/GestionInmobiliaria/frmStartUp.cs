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
        FrmBuilder builder;

        public frmStartUp()
        {
            InitializeComponent();
            builder = new FrmBuilder(this);
        }



        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            builder.AbrirFormulario("GI.UI.Propiedades.FrmListadoPropiedades");
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            builder.AbrirFormulario(typeof(GI.UI.Clientes.frmListadoClientes).ToString());
        }

        private void administraciónDeAlquileresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            builder.AbrirFormulario(typeof(AdminAlquileres.frmListadoAdmAlquiler).ToString());
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