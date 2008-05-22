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
                switch (GI.Framework.General.GIMsgBox.Show("¿Desea enviar las fichas por correo electrónico?", GI.Framework.General.enumTipoMensaje.Pregunta))
                {
                    case DialogResult.Yes:
                        {
                            GI.UI.Propiedades.Formularios.FrmEnviarFichasMail frm = new GI.UI.Propiedades.Formularios.FrmEnviarFichasMail();
                            if (frm.ShowDialog() == DialogResult.Cancel)
                            {
                                switch (GI.Framework.General.GIMsgBox.Show("Se canceló el envio de las fichas, ¿Desea marcar las propiedades como ofrecidas?", GI.Framework.General.enumTipoMensaje.PreguntaSinCancelar))
                                {
                                    case DialogResult.No: return;
                                }

                            }
                            break;
                        }
                    case DialogResult.Cancel: return;
                }

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
        }
    }
}
