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

        GI.Managers.Pedidos.MngPedidos mng = new GI.Managers.Pedidos.MngPedidos();

        public void Inicializar()
        {

            this.pedidos = mng.RecuperarPedidosTodos(false);
            LlenarLista();
        }

        private GI.BR.Pedidos.Pedidos pedidos;

        Framework.ListView.ListViewColumnSorter sorter = new GI.Framework.ListView.ListViewColumnSorter();

        private void lvPedidos_DoubleClick(object sender, EventArgs e)
        {
            if (lvPedidos.SelectedItems.Count != 1)
                return;

            frmFichaPedidos frm = new frmFichaPedidos();
            frm.Pedido = (GI.BR.Pedidos.Pedido)lvPedidos.SelectedItems[0].Tag;
            frm.SoloLectura = true;
            frm.ShowDialog();
            LlenarLista();


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
                lvi.Text = p.FechaAlta.ToShortDateString();
                lvi.SubItems.Add(p.ClientePedido.ToString());
                lvi.SubItems.Add(p.ClientePedido.GetTelefonoPpal);

                if (p.TipoPropiedad != null)
                    lvi.SubItems.Add(p.TipoPropiedad.ToString());
                else
                    lvi.SubItems.Add("----");

                if (p.EstadoPropiedad == typeof(GI.BR.Propiedades.Venta).ToString())
                    lvi.SubItems.Add("Venta");
                if (p.EstadoPropiedad == typeof(GI.BR.Propiedades.Alquiler).ToString())
                    lvi.SubItems.Add("Alquiler");

                if (p.Moneda != null)
                {
                    lvi.SubItems.Add( p.Moneda.ToString() + " " + p.ValorInicial.ToString());
                    lvi.SubItems.Add(p.Moneda.ToString() + " " + p.ValorFinal.ToString());
                }
                else
                {
                    lvi.SubItems.Add("----");
                    lvi.SubItems.Add("----");
                }


                if (p.Activo)
                    lvi.SubItems.Add("Activo");
                else
                    lvi.SubItems.Add("Hist�rico");

                string ubic = "----";
                if (p.Ubicacion.Pais != null)
                {                    
                    if (p.Ubicacion.Provincia != null)
                    {
                        ubic = p.Ubicacion.Provincia.ToString() + " - ";
                        if (p.Ubicacion.Localidad != null)
                            ubic += p.Ubicacion.Localidad.ToString();
                        else
                            ubic += "Loc. Sin Definir";
                    }                                       
                }

                lvi.SubItems.Add(ubic); 

                lvi.SubItems.Add(mng.GetPropiedadesOfrecidas(p).Count.ToString());
                lvi.SubItems.Add(mng.GetPropiedadesSinOfrecer(p).Count.ToString());

                lvi.Tag = p;
                lvPedidos.Items.Add(lvi);
            }

            int a, b;

            //Ajusto el tama�o de las columnas
            for (int i = 0; i < lvPedidos.Columns.Count; i++)
            {
                lvPedidos.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);

                a = lvPedidos.Columns[i].Width;

                lvPedidos.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);

                b = lvPedidos.Columns[i].Width;

                if (a > b)
                    lvPedidos.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                else
                    lvPedidos.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);

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
                GI.Framework.General.GIMsgBox.Show("El pedido es hist�rico, se abrira en modo solo lectura.", GI.Framework.General.enumTipoMensaje.Informacion);
                lvPedidos_DoubleClick(sender, e);
            }
            else
            {

                frm.ShowDialog();
                
            }
            LlenarLista();
        }


        private void nuevoPedidoDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFichaPedidos frm = new frmFichaPedidos();

            GI.BR.Pedidos.Pedido pedido = new GI.BR.Pedidos.Pedido();
            pedido.EstadoPropiedad = typeof(GI.BR.Propiedades.Venta).ToString();
            
            pedido.Ubicacion = new GI.BR.Propiedades.Ubicacion();
        
            pedido.Ubicacion.Pais = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetPaises().GetDefault;
            pedido.Ubicacion.Provincia = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetProvincias(pedido.Ubicacion.Pais.IdPais).GetDefault;
            pedido.Ubicacion.Localidad = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetLocalidades(pedido.Ubicacion.Provincia.IdProvincia).GetDefault;
            pedido.Ubicacion.Barrio = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetBarrios(pedido.Ubicacion.Localidad.IdLocalidad).GetDefault;
            
            frm.Pedido = pedido;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                pedidos.Add(pedido);
                
            }
            LlenarLista();
        }

        private void nuevoPedidoDeAlquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFichaPedidos frm = new frmFichaPedidos();

            GI.BR.Pedidos.Pedido pedido = new GI.BR.Pedidos.Pedido();
            pedido.EstadoPropiedad = typeof(GI.BR.Propiedades.Alquiler).ToString();

            pedido.Ubicacion = new GI.BR.Propiedades.Ubicacion();

            pedido.Ubicacion.Pais = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetPaises().GetDefault;
            pedido.Ubicacion.Provincia = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetProvincias(pedido.Ubicacion.Pais.IdPais).GetDefault;
            pedido.Ubicacion.Localidad = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetLocalidades(pedido.Ubicacion.Provincia.IdProvincia).GetDefault;
            pedido.Ubicacion.Barrio = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia.GetBarrios(pedido.Ubicacion.Localidad.IdLocalidad).GetDefault;

            frm.Pedido = pedido;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                pedidos.Add(pedido);
                
            }
            LlenarLista();
        }

        private void pedidosDeAlquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarPedidos frmBuscar = new frmBuscarPedidos(typeof(GI.BR.Propiedades.Alquiler));

            if (frmBuscar.ShowDialog() == DialogResult.OK)
            {
                this.pedidos = frmBuscar.Pedidos;
                
            }
            this.LlenarLista();
        }

        private void pedidosDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarPedidos frmBuscar = new frmBuscarPedidos(typeof(GI.BR.Propiedades.Venta));

            if (frmBuscar.ShowDialog() == DialogResult.OK)
            {
                this.pedidos = frmBuscar.Pedidos;

            }
                 this.LlenarLista();
        }

        private void lvPedidos_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
                sorter.SetTipoComparacion(GI.Framework.ListView.ListViewColumnSorter.TipoComparacion.DATETIME);
            if (e.Column > 0 && e.Column < 8)
                sorter.SetTipoComparacion(GI.Framework.ListView.ListViewColumnSorter.TipoComparacion.STRING);
            if (e.Column > 7 && e.Column < 11)
                sorter.SetTipoComparacion(GI.Framework.ListView.ListViewColumnSorter.TipoComparacion.INT);

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
            this.pedidos = mng.RecuperarPedidosTodos(true);
            LlenarLista();
        }






    }
}