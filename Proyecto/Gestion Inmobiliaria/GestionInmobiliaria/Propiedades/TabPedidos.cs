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
                LlenarLista(mng.RecuperarPedidosPorPropiedadSinOfrecer(Propiedad));
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lvPedidos.SelectedItems.Count > 0)
            {
                //TODO: Soportar multi propiedades, y multi contactos.
                GI.UI.Propiedades.Formularios.FrmEnviarFichasMail frm = new GI.UI.Propiedades.Formularios.FrmEnviarFichasMail(this.Propiedad);
                frm.OnEnvioFinalizado += new GI.UI.Propiedades.Formularios.EnvioFinalizadoHandler(frm_OnEnvioFinalizado);
                frm.Show();
            }
        }

        void frm_OnEnvioFinalizado(string mensaje, bool error)
        {
            if (!error)
                if (GI.Framework.General.GIMsgBox.Show("Se ha enviado el email correctamente, ¿Desea marcar la propiedad como ofrecida?", GI.Framework.General.enumTipoMensaje.PreguntaSinCancelar) == DialogResult.Yes)
                {
                    MarcarPropiedadComoOfrecida();
                }
        }

        private void MarcarPropiedadComoOfrecida()
        {
            if (lvPedidos.SelectedItems.Count > 0)
            {
                GI.BR.Pedidos.Pedidos pedidos = new GI.BR.Pedidos.Pedidos();
                foreach(ListViewItem lvi in lvPedidos.SelectedItems)
                {
                    GI.BR.Pedidos.Pedido p = (GI.BR.Pedidos.Pedido)lvi.Tag;
                    pedidos.Add(p);
                }

                if (!this.Propiedad.MarcarPropiedadComoOfrecida(pedidos))
                {

                    //Los saco de la lista si se marcaron todas correctamente.
                    foreach (ListViewItem lvi in lvPedidos.SelectedItems)
                    {
                        lvPedidos.Items.Remove(lvi);
                    }
                }

            }
        }

        private void llMarcarPropiedadComoOfrecida_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MarcarPropiedadComoOfrecida();
        }
    }
}
