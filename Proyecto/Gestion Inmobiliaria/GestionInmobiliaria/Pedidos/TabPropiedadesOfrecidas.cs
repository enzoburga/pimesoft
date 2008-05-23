using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Pedidos
{
    public partial class TabPropiedadesOfrecidas : TabContenidoPedidos
    {
        public TabPropiedadesOfrecidas()
        {
            InitializeComponent();
        }

        GI.Managers.Pedidos.MngPedidos mng = new GI.Managers.Pedidos.MngPedidos();
        protected override void Inicializar()
        {
            LlenarLista(mng.GetPropiedadesOfrecidas(Pedido));
            Pedido.OnPropiedadesOfrecidas += new GI.BR.Pedidos.PropiedadeOfrecidasHandler(Pedido_OnPropiedadesOfrecidas);

        }

        void Pedido_OnPropiedadesOfrecidas()
        {
            LlenarLista(mng.GetPropiedadesOfrecidas(Pedido));
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

        private void enviarPorEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvPropiedades.SelectedItems.Count > 0)
            {
                //TODO: Soportar multi propiedades, y multi contactos.
                GI.UI.Propiedades.Formularios.FrmEnviarFichasMail frm = new GI.UI.Propiedades.Formularios.FrmEnviarFichasMail();
                frm.Show();
            }
        }  
    }
}
