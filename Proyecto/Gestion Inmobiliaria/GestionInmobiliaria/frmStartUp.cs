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
        private FrmBuilder builder;
        private EventosService eventoServicio;
        
  
        public frmStartUp()
        {
            InitializeComponent();
            builder = new FrmBuilder(this);

            eventoServicio = EventosService.Servicio;
            eventoServicio.OnNuevosEventos += new NotificarEventosHandler(eventosServicio_OnNuevosEventos);
            toolStripStatusEventos.Text = "(" + eventoServicio.Eventos.Count.ToString() + ") Eventos Pendientes   | ";


            
        }



        private void eventosServicio_OnNuevosEventos(GI.BR.Eventos.Eventos Eventos)
        {

            toolStripStatusEventos.Text = "(" + Eventos.Count.ToString() + ") Eventos Pendientes   | ";

       
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
            frmPopUpEventos frmEventos = new frmPopUpEventos();
            frmEventos.Eventos = eventoServicio.Eventos;
            frmEventos.ShowDialog();
        }

        private void alquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            builder.AbrirFormulario(typeof(Propiedades.FrmListadoPropiedadesEnAlquiler).ToString());
        }

        private void propiedadesEnVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventaToolStripMenuItem_Click(null, null);
        }

        private void propiedadesEnAlquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alquilerToolStripMenuItem_Click(null, null);
        }

        private void frmStartUp_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButtonAdmAlq_Click(object sender, EventArgs e)
        {
            administraciónDeAlquileresToolStripMenuItem_Click(null, null);
        }

        private void toolStripButtonClientes_Click(object sender, EventArgs e)
        {
            clientesToolStripMenuItem_Click(null, null);
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PedidostoolStripButton_Click(null, null);
        }

        private void PedidostoolStripButton_Click(object sender, EventArgs e)
        {
            builder.AbrirFormulario(typeof(Pedidos.frmListadoPedidos).ToString());
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAcercaDe().ShowDialog();
        }
    }
}