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
        frmPopUpEventos frmEventos;
        
  
        public frmStartUp()
        {
            InitializeComponent();
            builder = new FrmBuilder(this);

            if (Framework.Seguridad.MngSeguridadDemo.GetInstancia.VersionDemo)
                this.Text += " - (Version de prueba)";


            frmEventos = new frmPopUpEventos();
            frmEventos.MdiParent = this;
         

            eventoServicio = EventosService.Servicio;
            eventoServicio.OnNuevosEventos += new NotificarEventosHandler(eventosServicio_OnNuevosEventos);
            toolStripStatusEventos.Text = "(" + eventoServicio.Eventos.Count.ToString() + ") Eventos Pendientes";
            frmEventos.Eventos = eventoServicio.Eventos;


            menuStrip1.MdiWindowListItem = ventanasToolStripMenuItem;


               
        }



        private void mostrarEventos(GI.BR.Eventos.Eventos Eventos)
        {
            toolStripStatusEventos.Text = "(" + Eventos.Count.ToString() + ") Eventos Pendientes";
            frmEventos.Eventos = Eventos;

            if (!frmEventos.MantenerOculto && Eventos.Count > 0)
            {

                frmEventos.Show();
                frmEventos.BringToFront();
            }
        }

        private void eventosServicio_OnNuevosEventos(GI.BR.Eventos.Eventos Eventos)
        {
            this.Invoke(new NotificarEventosHandler(mostrarEventos), new object[] { Eventos });

            
       
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
            frmEventos.Show();
            
            //frmPopUpEventos frmEventos = new frmPopUpEventos();
            //frmEventos.Eventos = eventoServicio.Eventos;
            //frmEventos.ShowDialog();
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            builder.AbrirFormulario(typeof(Carteles.frmListadoCarteles).ToString());
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Framework.General.GIMsgBox.Show("¿Desea salir de la aplicación", GI.Framework.General.enumTipoMensaje.PreguntaSinCancelar) == DialogResult.Yes)
                Close();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            publicarToolStripMenuItem_Click(null, null);
        }

        private void publicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            builder.AbrirFormulario(typeof(frmPublicacionWeb).ToString());
        }

        private void parametrosGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Generales.FrmParametrosGenerales().ShowDialog();
        }

        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void ventanasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}