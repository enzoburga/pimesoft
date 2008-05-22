using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades
{
    public partial class TabPedidos : TabContenidoPropiedad
    {
        public TabPedidos()
        {
            InitializeComponent();
        }



        protected override void Inicializar()
        {
            base.Inicializar();
        }


        protected override void CargarPropiedad()
        {
            if (Propiedad.IdPropiedad != 0)
            {

                GI.Managers.Pedidos.MngPedidos mng = new GI.Managers.Pedidos.MngPedidos();
                LlenarLista(mng.RecuperarPedidosPorPropiedad(Propiedad));
            }
        }

        internal void RecargarPedidos()
        {
            CargarPropiedad();
        }

        private void LlenarLista( GI.BR.Pedidos.Pedidos pedidos )
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

                lvi.Tag = p;
                lvPedidos.Items.Add(lvi);
            }
            lvPedidos.EndUpdate();

            lvPedidos.Focus();
        }
    }
}
