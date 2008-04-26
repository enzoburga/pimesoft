using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.AdminAlquileres
{
    public partial class TabPagos : TabContenidoAdmAlquiler
    {
        public TabPagos()
        {
            InitializeComponent();

            ListViewItem item;

            item = new ListViewItem();
            item.Text = DateTime.Now.ToShortDateString();
            item.SubItems.Add("Dic 07");
            item.SubItems.Add("$ 1400");
            listView1.Items.Add(item);

            item = new ListViewItem();
            item.Text = DateTime.Now.ToShortDateString();
            item.SubItems.Add("Ene 08");
            item.SubItems.Add("$ 1400");
            listView1.Items.Add(item);


            item = new ListViewItem();
            item.Text = DateTime.Now.ToShortDateString();
            item.SubItems.Add("Feb 08");
            item.SubItems.Add("$ 1400");
            listView1.Items.Add(item);



        }
    }
}
