using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades
{
    public partial class TabLlamadas : TabContenidoPropiedad
    {
        public TabLlamadas()
        {
            InitializeComponent();
        }


        public override bool AsignarSoloLectura(Control Ctrl)
        {

            if (Ctrl.Name == "lvLlamados") return false;
            return base.AsignarSoloLectura(Ctrl);
        }

        protected override void CargarPropiedad()
        {

            GI.BR.Propiedades.Llamados llamados = new GI.BR.Propiedades.Llamados();
            llamados.Recuperar(Propiedad);

            foreach (GI.BR.Propiedades.Llamado l in llamados)
                lvLlamados.Items.Add(generarLVI(l));

        }

        private ListViewItem generarLVI(GI.BR.Propiedades.Llamado llamado)
        {
            ListViewItem item = new ListViewItem();

            item.Text = llamado.FechaHora.ToShortDateString();
            item.SubItems.Add(llamado.FechaHora.ToShortTimeString());
            item.SubItems.Add(llamado.Contacto);
            item.SubItems.Add(llamado.Telefono);
            item.SubItems.Add(llamado.Comentario);
            item.Tag = llamado;

            return item;

        }


        private void linkLabelAgregarLlamado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Propiedad.IdPropiedad == 0)
            {

                Framework.General.GIMsgBox.Show("Debe primero guardar la propiedad para cargar llamados", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }


            GI.BR.Propiedades.Llamado llamado = new GI.BR.Propiedades.Llamado();

            llamado.Comentario = "";
            llamado.Contacto = "";
            llamado.FechaHora = DateTime.Now;
            llamado.IdPropiedad = Propiedad.IdPropiedad;
            llamado.Telefono = "";

            Formularios.FrmLlamado frm = new GI.UI.Propiedades.Formularios.FrmLlamado(llamado);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = generarLVI(llamado);
                lvLlamados.Items.Add(item);
            }
        }

        private void linkLabelEliminarLlamado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Propiedad.IdPropiedad == 0)
            {

                Framework.General.GIMsgBox.Show("Debe primero guardar la propiedad para eliminar llamadas", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }

            if (lvLlamados.SelectedItems.Count != 1) return;

            GI.BR.Propiedades.Llamado l = (GI.BR.Propiedades.Llamado)lvLlamados.SelectedItems[0].Tag;

            if (Framework.General.GIMsgBox.Show("¿Desea eliminar el llamado seleccionada?", GI.Framework.General.enumTipoMensaje.Pregunta) == DialogResult.Yes)
            {
                l.Eliminar();
                lvLlamados.Items.Remove(lvLlamados.SelectedItems[0]);
            }
        }

        private void lvLlamados_DoubleClick(object sender, EventArgs e)
        {
            if (lvLlamados.SelectedItems.Count != 1) return;

            GI.BR.Propiedades.Llamado l = (GI.BR.Propiedades.Llamado)lvLlamados.SelectedItems[0].Tag;

            Formularios.FrmLlamado frm = new GI.UI.Propiedades.Formularios.FrmLlamado(l);
            frm.SoloLectura = this.SoloLectura;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = generarLVI(l);
                int index = lvLlamados.SelectedIndices[0];
                lvLlamados.Items.RemoveAt(index);
                lvLlamados.Items.Insert(index, item);
            }
        }
    }
}
