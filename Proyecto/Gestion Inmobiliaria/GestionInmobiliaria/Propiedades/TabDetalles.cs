using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades
{
    public partial class TabDetalles : TabContenidoPropiedad
    {
        public TabDetalles()
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
            i.Text = "Cocina";
            i.SubItems.Add("4");
            i.SubItems.Add("5");
            i.SubItems.Add("Pinotea");
            lvMedidas.Items.Add(i);

            i = new ListViewItem();
            i.Text = "Living";
            i.SubItems.Add("4");
            i.SubItems.Add("5");
            i.SubItems.Add("Pinotea");
            lvMedidas.Items.Add(i);


  


        }
    }
}
