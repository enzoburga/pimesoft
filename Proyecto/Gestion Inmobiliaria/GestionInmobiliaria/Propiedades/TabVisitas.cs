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


        protected override void CargarPropiedad()
        {
            ListViewItem item = new ListViewItem();

            item.Text = DateTime.Now.ToShortDateString();
            item.SubItems.Add(DateTime.Now.ToShortTimeString());
            item.SubItems.Add("Si");
            lvVisitas.Items.Add(item);

        }

        private void lvVisitas_DoubleClick(object sender, EventArgs e)
        {
            Formularios.frmVisita frmVisita = new GI.UI.Propiedades.Formularios.frmVisita();
            frmVisita.ShowDialog();
        }
    }
}
