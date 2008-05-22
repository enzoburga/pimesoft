using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI
{
    public partial class frmPopUpEventos : Form
    {

        private GI.BR.Eventos.Eventos eventos;

        

        public frmPopUpEventos()
        {
            InitializeComponent();

        }


        public GI.BR.Eventos.Eventos Eventos
        {
            set
            {
                eventos = value;
                Inicializar();
            }
        }


        private void Inicializar()
        {
            lvEventos.BeginUpdate();
            lvEventos.Items.Clear();

            ListViewItem item;
            foreach (GI.BR.Eventos.Evento e in eventos)
            {
                item = new ListViewItem();
                item.Text = e.TipoEvento.ToString();
                item.SubItems.Add(e.Fecha.ToShortDateString());
                item.SubItems.Add(e.Descripcion);
                item.SubItems.Add(e.Vencimiento.HasValue ? e.Vencimiento.Value.ToShortDateString() : "--");
                item.Tag = e;
                lvEventos.Items.Add(item);
            
            }


            lvEventos.EndUpdate();
        
        
        }

        

        private void frmPopUpEventos_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmPopUpEventos_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void bSilencias_Click(object sender, EventArgs e)
        {

        }

        private void bCerra_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lvEventos_DoubleClick(object sender, EventArgs e)
        {

        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



    }
}