using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades
{
    public partial class TabNotas : TabContenidoPropiedad
    {
        public TabNotas()
        {
            InitializeComponent();
        }


        protected override void Inicializar()
        {
            base.Inicializar();
        }


        public override bool AsignarSoloLectura(Control Ctrl)
        {
            if (Ctrl.Name == "lvNotas")
                return false;

            return base.AsignarSoloLectura(Ctrl);
        }

        protected override void CargarPropiedad()
        {

            GI.BR.Propiedades.Notas notas = new GI.BR.Propiedades.Notas();
            notas.Recuperar(Propiedad);

            lvNotas.Items.Clear();
            foreach (GI.BR.Propiedades.Nota n in notas)
                lvNotas.Items.Add(generarLVI(n));





        }


        private ListViewItem generarLVI(GI.BR.Propiedades.Nota Nota)
        {
            ListViewItem item = new ListViewItem();
            item.Text = Nota.Fecha.ToShortDateString();
            item.SubItems.Add(Nota.Comentario);
            item.Tag = Nota;

            return item;
        }

        private void lvNotas_DoubleClick(object sender, EventArgs e)
        {
            if (lvNotas.SelectedItems.Count != 1) return;

            GI.BR.Propiedades.Nota n = (GI.BR.Propiedades.Nota)lvNotas.SelectedItems[0].Tag;

            Formularios.frmNota frmNota = new GI.UI.Propiedades.Formularios.frmNota(n, Propiedad);
            frmNota.ShowDialog();
        }

        private void linkLabelAgregar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Propiedad.IdPropiedad == 0)
            {

                Framework.General.GIMsgBox.Show("Debe primero guardar la propiedad para cargar notas", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }

            GI.BR.Propiedades.Nota n = new GI.BR.Propiedades.Nota();
            Formularios.frmNota frm = new GI.UI.Propiedades.Formularios.frmNota(n, Propiedad);
            if (frm.ShowDialog() == DialogResult.OK)
            {

                lvNotas.Items.Add(generarLVI(n));
            }

        }

        private void linkLabelEliminar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Propiedad.IdPropiedad == 0)
            {

                Framework.General.GIMsgBox.Show("Debe primero guardar la propiedad para cargar notas", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }

            if (lvNotas.SelectedItems.Count != 1) return;
            GI.BR.Propiedades.Nota n = (GI.BR.Propiedades.Nota)lvNotas.SelectedItems[0].Tag;

            if (Framework.General.GIMsgBox.Show("¿Desea eliminar la nota seleccionada?", GI.Framework.General.enumTipoMensaje.Pregunta) == DialogResult.Yes)
            {
                n.Eliminar();
                lvNotas.Items.Remove(lvNotas.SelectedItems[0]);
            }
        }
    }
}
