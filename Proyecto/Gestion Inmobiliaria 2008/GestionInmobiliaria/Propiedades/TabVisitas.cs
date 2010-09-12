using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades
{
    public partial class TabVisitas : TabContenidoPropiedad
    {
        public TabVisitas()
        {
            InitializeComponent();
        }


        protected override void Inicializar()
        {
            base.Inicializar();
        }


        public override bool AsignarSoloLectura(Control Ctrl)
        {

            if (Ctrl.Name == "lvVisitas") return false;
            return base.AsignarSoloLectura(Ctrl);
        }

        protected override void CargarPropiedad()
        {

            GI.BR.Propiedades.VisitasPropiedad visitas = new GI.BR.Propiedades.VisitasPropiedad();
            visitas.Recuperar(Propiedad);

            foreach (GI.BR.Propiedades.VisitaPropiedad v in visitas)
                lvVisitas.Items.Add(generarLVI(v));


        }

        private ListViewItem generarLVI(GI.BR.Propiedades.VisitaPropiedad visita)
        {
            ListViewItem item = new ListViewItem();

            item.Text = visita.FechaHora.ToShortDateString();
            item.SubItems.Add(visita.FechaHora.ToShortTimeString());
            item.SubItems.Add(visita.Realizada ? "Si" : "No");
            item.SubItems.Add(visita.Visita);
            item.SubItems.Add(visita.Detalles);
            item.Tag = visita;

            return item;

        }

        private void lvVisitas_DoubleClick(object sender, EventArgs e)
        {
            if (lvVisitas.SelectedItems.Count != 1) return;

            GI.BR.Propiedades.VisitaPropiedad v = (GI.BR.Propiedades.VisitaPropiedad)lvVisitas.SelectedItems[0].Tag;

            Formularios.frmVisita frmVisita = new GI.UI.Propiedades.Formularios.frmVisita(v);
            frmVisita.SoloLectura = this.SoloLectura;
            if (frmVisita.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = generarLVI(v);
                int index = lvVisitas.SelectedIndices[0];
                lvVisitas.Items.RemoveAt(index);
                lvVisitas.Items.Insert(index, item);
            }
        }

        private void linkLabelAgregarVisita_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Propiedad.IdPropiedad == 0)
            {

                Framework.General.GIMsgBox.Show("Debe primero guardar la propiedad para cargar visitas", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }


            GI.BR.Propiedades.VisitaPropiedad v = new GI.BR.Propiedades.VisitaPropiedad();
            v.ConAlarma = true;
            v.Detalles = "";
            v.FechaHora = DateTime.Now;
            v.IdPropiedad = Propiedad.IdPropiedad;
            v.Realizada = false;
            v.TelefonoContacto = "";
            v.TiempoAlarma = new GI.BR.Propiedades.TiemposAlarmaFactory().RecuperarTodos()[0];
            v.Visita = "";


            Formularios.frmVisita frmVisita = new GI.UI.Propiedades.Formularios.frmVisita(v);
            if (frmVisita.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = generarLVI(v);
                lvVisitas.Items.Add(item);
            }
        }

        private void linkLabelEliminarVisita_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Propiedad.IdPropiedad == 0)
            {

                Framework.General.GIMsgBox.Show("Debe primero guardar la propiedad para cargar visitas", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }

            if (lvVisitas.SelectedItems.Count != 1) return;

            GI.BR.Propiedades.VisitaPropiedad v = (GI.BR.Propiedades.VisitaPropiedad)lvVisitas.SelectedItems[0].Tag;

            if (Framework.General.GIMsgBox.Show("¿Desea eliminar la visita seleccionada?", GI.Framework.General.enumTipoMensaje.Pregunta) == DialogResult.Yes)
            {
                v.Eliminar();
                lvVisitas.Items.Remove(lvVisitas.SelectedItems[0]);
            }
        }
    }
}
