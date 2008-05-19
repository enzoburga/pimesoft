using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Pedidos
{
    public partial class frmListadoPedidos : GI.Framework.Seguridad.FrmGISeguridad
    {
        public frmListadoPedidos()
        {
            InitializeComponent();
        }
        public void Inicializar()
        {
            pedidos.RecuperarPedidosTodos();
            LlenarLista();
        }

        private GI.BR.Pedidos.Pedidos pedidos = new GI.BR.Pedidos.Pedidos();

        private void lvPedidos_DoubleClick(object sender, EventArgs e)
        {

           frmFichaPedidos frm = new frmFichaPedidos();
           frm.Pedido = (GI.BR.Pedidos.Pedido)lvPedidos.SelectedItems[0].Tag;
           frm.SoloLectura = true;
           frm.ShowDialog();


        }

        private void LlenarLista()
        {
            ListViewItem lvi;
            lvPedidos.BeginUpdate();

            lvPedidos.Items.Clear();
            foreach (GI.BR.Pedidos.Pedido p in pedidos)
            {
                lvi = new ListViewItem();
                
                //TODO: LLENAR LISTA
                lvi.Text = p.ClientePedido.ToString();

                if (p.EstadoPropiedad == typeof(GI.BR.Propiedades.Venta))
                    lvi.SubItems.Add("Venta");
                if (p.EstadoPropiedad == typeof(GI.BR.Propiedades.Alquiler))
                    lvi.SubItems.Add("Alquiler");

                lvi.Tag = p;
                lvPedidos.Items.Add(lvi);


                
                
            }
            lvPedidos.EndUpdate();

            lvPedidos.Focus();
        }

        private void verFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvPedidos_DoubleClick(sender, e);
        }

        private void editarFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFichaPedidos frm = new frmFichaPedidos();
            frm.Pedido = (GI.BR.Pedidos.Pedido)lvPedidos.SelectedItems[0].Tag;
            if (frm.ShowDialog() == DialogResult.OK)
                LlenarLista();
        }

        private void imprimirListadotoolStripButton_Click(object sender, EventArgs e)
        {

            if (pedidos == null || pedidos.Count == 0)
            {
                Framework.General.GIMsgBox.Show("No hay pedidos para la vista actual", GI.Framework.General.enumTipoMensaje.Informacion);
                return;
            }

            throw new Exception("No implementado.");
            //GI.Reportes.Clases.AdmAlquileres.ReporteListadoAdmAlquileres reporte = new GI.Reportes.Clases.AdmAlquileres.ReporteListadoAdmAlquileres("Listado de Alquileres Administrados", admAlquileres);

            //GI.Reportes.Visor.FrmVisorReporte frmVisor = new GI.Reportes.Visor.FrmVisorReporte(reporte);

            //frmVisor.ShowDialog();
        }

        private void nuevoPedidoDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFichaPedidos frm = new frmFichaPedidos();
            
            GI.BR.Pedidos.Pedido pedido = new GI.BR.Pedidos.Pedido();
            pedido.EstadoPropiedad = typeof(GI.BR.Propiedades.Venta);
            
            frm.Pedido = pedido;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                pedidos.Add(pedido);
                LlenarLista();
            }
        }

        private void nuevoPedidoDeAlquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFichaPedidos frm = new frmFichaPedidos();
            
            GI.BR.Pedidos.Pedido pedido = new GI.BR.Pedidos.Pedido();
            pedido.EstadoPropiedad = typeof(GI.BR.Propiedades.Alquiler);
            
            frm.Pedido = pedido;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                pedidos.Add(pedido);
                LlenarLista();
            }
        }

        private void pedidosDeAlquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarPedidos frmBuscar = new frmBuscarPedidos(typeof(GI.BR.Propiedades.Alquiler));

            if (frmBuscar.ShowDialog() == DialogResult.OK)
            {
                this.pedidos = frmBuscar.Pedidos;
                this.LlenarLista();
            }
        }

        private void pedidosDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarPedidos frmBuscar = new frmBuscarPedidos(typeof(GI.BR.Propiedades.Venta));

            if (frmBuscar.ShowDialog() == DialogResult.OK)
            {
                this.pedidos = frmBuscar.Pedidos;
                this.LlenarLista();
            }
        }

        



    }
}