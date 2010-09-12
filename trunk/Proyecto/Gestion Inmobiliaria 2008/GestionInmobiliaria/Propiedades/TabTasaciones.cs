using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades
{
    public partial class TabTasaciones : TabContenidoPropiedad
    {
        public TabTasaciones()
        {
            InitializeComponent();
        }


        public override bool AsignarSoloLectura(Control Ctrl)
        {

            if (Ctrl.Name == "lvTasaciones") return false;
            return base.AsignarSoloLectura(Ctrl);
        }

        protected override void CargarPropiedad()
        {

            GI.BR.Propiedades.Tasaciones tasaciones = new GI.BR.Propiedades.Tasaciones();
            tasaciones.Recuperar(Propiedad);

            foreach (GI.BR.Propiedades.Tasacion t in tasaciones)
                lvTasaciones.Items.Add(generarLVI(t));


        }

        private ListViewItem generarLVI(GI.BR.Propiedades.Tasacion tasacion)
        {
            ListViewItem item = new ListViewItem();

            item.Text = tasacion.Fecha.ToShortDateString();
            item.SubItems.Add(tasacion.ValorReal.ToString());
            item.SubItems.Add(tasacion.ValorPublicacion.ToString());
            item.SubItems.Add(tasacion.Comentarios);

            item.Tag = tasacion;

            return item;

        }

        private void lvPedidos_DoubleClick(object sender, EventArgs e)
        {
            if (lvTasaciones.SelectedItems.Count != 1) return;

            GI.BR.Propiedades.Tasacion t = (GI.BR.Propiedades.Tasacion)lvTasaciones.SelectedItems[0].Tag;

            Formularios.FrmTasacion frm = new GI.UI.Propiedades.Formularios.FrmTasacion(t);
            frm.SoloLectura = this.SoloLectura;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = generarLVI(t);
                int index = lvTasaciones.SelectedIndices[0];
                lvTasaciones.Items.RemoveAt(index);
                lvTasaciones.Items.Insert(index, item);
            }
        }

        private void linkLabelAgregarTasacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Propiedad.IdPropiedad == 0)
            {

                Framework.General.GIMsgBox.Show("Debe primero guardar la propiedad para cargar una tasación", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }

            GI.BR.Propiedades.Tasacion t = new GI.BR.Propiedades.Tasacion();
            t.Comentarios = "";
            t.Fecha = DateTime.Now;
            t.IdPropiedad = Propiedad.IdPropiedad;
            t.ValorPublicacion = new GI.BR.Valor();
            t.ValorPublicacion.Importe = 0;
            t.ValorReal = new GI.BR.Valor();
            t.ValorReal.Importe = 0;

            Formularios.FrmTasacion frm = new GI.UI.Propiedades.Formularios.FrmTasacion(t);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = generarLVI(t);
                lvTasaciones.Items.Add(item);
                if (Framework.General.GIMsgBox.Show("¿Desea usar los mismos valores para la ficha?", GI.Framework.General.enumTipoMensaje.Pregunta) == DialogResult.Yes)
                {
                    Propiedad.ValorMercado = t.ValorReal;
                    Propiedad.ValorPublicacion = t.ValorPublicacion;
                
                }

            }

        }

        private void linkLabelEliminarTasacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Propiedad.IdPropiedad == 0)
            {

                Framework.General.GIMsgBox.Show("Debe primero guardar la propiedad para eliminar una tasacion", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }

            if (lvTasaciones.SelectedItems.Count != 1) return;

            GI.BR.Propiedades.Tasacion t = (GI.BR.Propiedades.Tasacion)lvTasaciones.SelectedItems[0].Tag;

            if (Framework.General.GIMsgBox.Show("¿Desea eliminar la tasación seleccionada?", GI.Framework.General.enumTipoMensaje.Pregunta) == DialogResult.Yes)
            {
                t.Eliminar();
                lvTasaciones.Items.Remove(lvTasaciones.SelectedItems[0]);
            }
        }


    }
}
