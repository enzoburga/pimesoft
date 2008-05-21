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
            lvPedidos.ListViewItemSorter = sorter;
        }
        public void Inicializar()
        {
            pedidos.RecuperarPedidosTodos();
            LlenarLista();
        }

        private GI.BR.Pedidos.Pedidos pedidos = new GI.BR.Pedidos.Pedidos();

        Framework.ListView.ListViewColumnSorter sorter = new GI.Framework.ListView.ListViewColumnSorter();

        private void lvPedidos_DoubleClick(object sender, EventArgs e)
        {
            if (lvPedidos.SelectedItems.Count != 1)
                return;

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

                if(p.Activo)
                    lvi.SubItems.Add("Activo");
                else
                    lvi.SubItems.Add("Histórico");

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
            if (lvPedidos.SelectedItems.Count != 1)
                return;
            frmFichaPedidos frm = new frmFichaPedidos();
            
            frm.Pedido = (GI.BR.Pedidos.Pedido)lvPedidos.SelectedItems[0].Tag;

            if (!frm.Pedido.Activo)
            {
                GI.Framework.General.GIMsgBox.Show("El pedido es histórico, se abrira en modo solo lectura.", GI.Framework.General.enumTipoMensaje.Informacion);
                lvPedidos_DoubleClick(sender, e);
            }
            else
            {

                if (frm.ShowDialog() == DialogResult.OK)
                    LlenarLista();
            }
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

        private void lvPedidos_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            sorter.SetTipoComparacion(GI.Framework.ListView.ListViewColumnSorter.TipoComparacion.STRING);                

            if (e.Column == sorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (sorter.Order == SortOrder.Ascending)
                {
                    sorter.Order = SortOrder.Descending;
                }
                else
                {
                    sorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                sorter.SortColumn = e.Column;
                sorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.lvPedidos.Sort();
        }

        private void verTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pedidos.RecuperarPedidosTodos();
            LlenarLista();
        }

        



    }
}