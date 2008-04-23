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

            Inicializar();          
        }

        private void Inicializar()
        {
            
        }

        

        private void lvClientes_DoubleClick(object sender, EventArgs e)
        {
            frmFichaCliente frm = new frmFichaCliente();
            frm.Cliente = (GI.BR.Cliente)lvClientes.SelectedItems[0].Tag;
            frm.ShowDialog();
        }

        private void nuevaFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFichaCliente frm = new frmFichaCliente();
            if (frm.ShowDialog() == DialogResult.OK)
                if (frm.Cliente.Guardar() == false)
                    MessageBox.Show("Error al guardar el cliente");
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            GI.BR.Clientes clientes = new GI.BR.Clientes();
            clientes.RecuperarPropietarios();

            CargarClientes(clientes);
        }

        private void CargarClientes(GI.BR.Clientes clientes)
        {
            ListViewItem lvi;
            foreach(GI.BR.Cliente c in clientes)
            {
                lvi  = new ListViewItem();
                lvi.Text = c.ToString();
                lvi.SubItems.Add(c.Direccion.ToString());
                lvi.SubItems.Add(c.Email.ToString());
                lvi.Tag = c;
                lvClientes.Items.Add(lvi);
            }
        }
    }
}