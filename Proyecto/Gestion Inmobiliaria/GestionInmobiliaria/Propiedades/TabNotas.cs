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

        protected override void CargarPropiedad()
        {
            ListViewItem i;

            i = new ListViewItem();
            i.Text = DateTime.Now.ToShortDateString();
            i.SubItems.Add("Aca agregamos una nota con comentarios para una fecha...");

            lvNotas.Items.Add(i);
        }

        private void lvNotas_DoubleClick(object sender, EventArgs e)
        {
            Formularios.frmNota frmNota = new GI.UI.Propiedades.Formularios.frmNota();
            frmNota.ShowDialog();
        }
    }
}
