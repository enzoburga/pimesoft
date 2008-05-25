using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Pedidos
{
    public partial class TabPropiedadesSinOfrecer : TabContenidoPedidos
    {
        public TabPropiedadesSinOfrecer()
        {
            InitializeComponent();
        }

        GI.Managers.Pedidos.MngPedidos mng = new GI.Managers.Pedidos.MngPedidos();
        protected override void Inicializar()
        {
            LlenarLista(mng.GetPropiedadesSinOfrecer(Pedido));

        }

        public override bool AsignarSoloLectura(Control Ctrl)
        {
            if(!Pedido.Activo)
                return base.AsignarSoloLectura(Ctrl);
            return false;
        }

        private void LlenarLista(GI.BR.Propiedades.Propiedades propiedades)
        {
            ListViewItem lvi;
            lvPropiedades.Items.Clear();
            foreach (GI.BR.Propiedades.Propiedad p in propiedades)
            {
                lvPropiedades.BeginUpdate();
                

                lvi = new ListViewItem();
                lvi.Text = p.Codigo;
                lvi.SubItems.Add(p.Direccion.ToString());
                if (p.Propietario != null)
                    lvi.SubItems.Add(p.Propietario.ToString());
                else
                    lvi.SubItems.Add("Sin Propietario.");

                lvi.Tag = p;
                lvPropiedades.Items.Add(lvi);
                
                lvPropiedades.EndUpdate();                
            }
        }

        private void verFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvPropiedades.SelectedItems.Count != 1)
                return;
            GI.UI.Propiedades.frmFichaPropiedad frm = new GI.UI.Propiedades.frmFichaPropiedad();
            frm.Propiedad = (GI.BR.Propiedades.Propiedad)lvPropiedades.SelectedItems[0].Tag;
            frm.SoloLectura = true;
            frm.Show();

        }

        private void lvPropiedades_DoubleClick(object sender, EventArgs e)
        {
            verFichaToolStripMenuItem_Click(null, null);
        }

        private GI.BR.Propiedades.Propiedades GetPropiedadeSeleccionadas()
        {
            

            GI.BR.Propiedades.Propiedades propiedades = new GI.BR.Propiedades.Propiedades();
            GI.BR.Propiedades.Propiedad p;
            foreach (ListViewItem lvi in lvPropiedades.SelectedItems)
            {
                p = (GI.BR.Propiedades.Propiedad)lvi.Tag;
                propiedades.Add(p);
            }
            return propiedades;
        }

        private void ofrecerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvPropiedades.SelectedItems.Count > 0)
            {
                GI.BR.Propiedades.Propiedades propiedades = GetPropiedadeSeleccionadas();
                GI.BR.Clientes.Clientes clientes = new GI.BR.Clientes.Clientes();
                clientes.Add(this.Pedido.ClientePedido);

                GI.UI.Propiedades.Formularios.FrmEnviarFichasMail frm = new GI.UI.Propiedades.Formularios.FrmEnviarFichasMail(propiedades,clientes);
                frm.OnEnvioFinalizado += new GI.UI.Propiedades.Formularios.EnvioFinalizadoHandler(frm_OnEnvioFinalizado);
                frm.Show();
            }
        }

        void frm_OnEnvioFinalizado(string mensaje, bool error)
        {
            if (!error)
                if (GI.Framework.General.GIMsgBox.Show("Se ha enviado el email correctamente, ¿Desea marcar la propiedad como ofrecida?", GI.Framework.General.enumTipoMensaje.PreguntaSinCancelar) == DialogResult.Yes)
                {
                    MarcarPropiedadeComoOfrecidas();
                }
        }

        private void MarcarPropiedadeComoOfrecidas()
        {
            if (lvPropiedades.SelectedItems.Count <= 0)
                return;

            if (!Pedido.OfrecerPropiedades(GetPropiedadeSeleccionadas()))
            {
                foreach (ListViewItem lvi in lvPropiedades.SelectedItems)
                {
                    lvPropiedades.Items.Remove(lvi);
                }
            }
            else
            {
                GI.Framework.General.GIMsgBox.Show("Ocurrio un error al marcar las propiedades como ofrecidas", GI.Framework.General.enumTipoMensaje.Error);
                return;
            }

            GI.Framework.General.GIMsgBox.Show("Las propiededes fueron marcadas con éxito.", GI.Framework.General.enumTipoMensaje.Informacion);

        
        }

        private void marcarComoOfrecidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarcarPropiedadeComoOfrecidas();
        }
    }
}
