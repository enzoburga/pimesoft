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

            item.Text = p.Fecha.ToShortDateString();
            item.SubItems.Add(p.Medio);
            item.SubItems.Add(p.ValorPublicacion.ToString());
            item.SubItems.Add(p.Detalles);
            item.Tag = p;

            return item;

        }

        protected override void CargarPropiedad()
        {
            GI.BR.Propiedades.Publicaciones publicaciones = new GI.BR.Propiedades.Publicaciones();
            publicaciones.Recuperar(Propiedad);

            foreach (GI.BR.Propiedades.Publicacion p in publicaciones)
                lvPublicaciones.Items.Add(generarLVI(p));
        }

        private void lvPublicaciones_DoubleClick(object sender, EventArgs e)
        {
            if (lvPublicaciones.SelectedItems.Count != 1) return;

            GI.BR.Propiedades.Publicacion p = (GI.BR.Propiedades.Publicacion)lvPublicaciones.SelectedItems[0].Tag;

            Formularios.FrmPublicacion frm = new GI.UI.Propiedades.Formularios.FrmPublicacion(p);
            frm.SoloLectura = this.SoloLectura;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = generarLVI(p);
                int index = lvPublicaciones.SelectedIndices[0];
                lvPublicaciones.Items.RemoveAt(index);
                lvPublicaciones.Items.Insert(index, item);
            }

        }

        private void linkLabelAgregarPublicacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Propiedad.IdPropiedad == 0)
            {

                Framework.General.GIMsgBox.Show("Debe primero guardar la propiedad para cargar publicaciones", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }


            GI.BR.Propiedades.Publicacion p = new GI.BR.Propiedades.Publicacion();
            p.Detalles = "";
            p.Fecha = DateTime.Now;
            p.IdPropiedad = Propiedad.IdPropiedad;
            p.Medio = "";
            p.ValorPublicacion = new GI.BR.Valor();
            p.ValorPublicacion.Importe = 0;



            Formularios.FrmPublicacion frm = new GI.UI.Propiedades.Formularios.FrmPublicacion(p);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = generarLVI(p);
                lvPublicaciones.Items.Add(item);
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




            GI.BR.Propiedades.Publicacion p = (GI.BR.Propiedades.Publicacion)lvPublicaciones.SelectedItems[0].Tag;

            if (Framework.General.GIMsgBox.Show("¿Desea eliminar la publicación seleccionada?", GI.Framework.General.enumTipoMensaje.Pregunta) == DialogResult.Yes)
            {
                p.Eliminar();
                lvPublicaciones.Items.Remove(lvPublicaciones.SelectedItems[0]);
            }
        }
    }
}
