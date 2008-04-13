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


        protected override void CargarPropiedad()
        {
            ListViewItem item = new ListViewItem();

            item.Text = DateTime.Now.ToShortDateString();
            item.SubItems.Add("Clarín");
            item.SubItems.Add("$ 120");
            item.SubItems.Add("detalles...");

            lvPublicaciones.Items.Add(item);
        }
    }
}
