using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades
{
    public partial class TabPublicaciones : TabContenidoPropiedad
    {
        public TabPublicaciones()
        {
            InitializeComponent();
        }


        protected override void Inicializar()
        {
            base.Inicializar();
        }


        public override bool AsignarSoloLectura(Control Ctrl)
        {

            if (Ctrl.Name == "lvPublicaciones") return false;
            return base.AsignarSoloLectura(Ctrl);
        }

        private ListViewItem generarLVI(GI.BR.Propiedades.Publicacion p)
        {
            ListViewItem item = new ListViewItem();

           

            return item;

        }

        protected override void CargarPropiedad()
        {
            ListViewItem item = new ListViewItem();

            item.Text = DateTime.Now.ToShortDateString();
            item.SubItems.Add("Clarín");
            item.SubItems.Add("$ 120");
            item.SubItems.Add("detalles...");

            lvPublicaciones.Items.Add(item);
        }

        private void lvPublicaciones_DoubleClick(object sender, EventArgs e)
        {
            if (lvPublicaciones.SelectedItems.Count != 1) return;
        }

        private void linkLabelAgregarPublicacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Propiedad.IdPropiedad == 0)
            {

                Framework.General.GIMsgBox.Show("Debe primero guardar la propiedad para cargar publicaciones", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }
        }

        private void linkLabelEliminar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Propiedad.IdPropiedad == 0)
            {

                Framework.General.GIMsgBox.Show("Debe primero guardar la propiedad para eliminar publicaciones", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }

            if (lvPublicaciones.SelectedItems.Count != 1) return;
        }
    }
}
