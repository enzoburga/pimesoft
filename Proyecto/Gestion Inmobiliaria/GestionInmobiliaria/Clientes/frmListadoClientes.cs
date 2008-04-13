using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Clientes
{
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();


            ListViewItem item = new ListViewItem();
            item.Text = "Emilio Luis Davidis";
            item.SubItems.Add("011 4761-0137");
            item.SubItems.Add("edavidis@nalejandria.com");

            lvClientes.Items.Add(item);
        }

        private void lvClientes_DoubleClick(object sender, EventArgs e)
        {
            frmFichaCliente frm = new frmFichaCliente();
            frm.ShowDialog();
        }
    }
}