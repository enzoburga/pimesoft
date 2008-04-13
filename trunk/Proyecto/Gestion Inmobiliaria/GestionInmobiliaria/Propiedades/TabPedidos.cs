using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades
{
    public partial class TabPedidos : TabContenidoPropiedad
    {
        public TabPedidos()
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
            item.SubItems.Add("Emilio Davidis");
            item.SubItems.Add("153-590-5900");

            lvPedidos.Items.Add(item);
        }
    }
}
