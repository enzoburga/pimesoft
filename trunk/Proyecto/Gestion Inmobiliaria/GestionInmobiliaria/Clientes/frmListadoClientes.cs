using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Clientes
{
    public partial class frmListadoClientes : GI.Framework.Seguridad.FrmGISeguridad
    {
        public frmListadoClientes()
        {
            InitializeComponent();         
        }

        private GI.BR.Clientes.Clientes clientes;

        private void lvClientes_DoubleClick(object sender, EventArgs e)
        {
            if (lvClientes.SelectedItems.Count != 1)
                return;
            frmFichaCliente frm = new frmFichaCliente();
            frm.SoloLectura = true;
            frm.Cliente = (GI.BR.Clientes.Cliente)lvClientes.SelectedItems[0].Tag;            
            frm.Show();
        }

        private void nuevoPropietarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GI.BR.Clientes.ClienteFactory cf = new GI.BR.Clientes.ClienteFactory();
            frmFichaCliente frm = new frmFichaCliente();
            frm.Cliente = cf.CrearClaseCliente(typeof(GI.BR.Clientes.Propietario));
            frm.ShowDialog();
        }

        private void CargarClientes(GI.BR.Clientes.Clientes clientes)
        {
            ListViewItem lvi;
            lvClientes.Items.Clear();
            foreach (GI.BR.Clientes.Cliente c in clientes)
            {
                lvi  = new ListViewItem();
                lvi.Text = c.ToString();


                if(c.TelefonoParticular != 0)
                    lvi.SubItems.Add(c.TelefonoParticular.ToString());
                else
                    if (c.TelefonoCelular != 0)
                        lvi.SubItems.Add(c.TelefonoCelular.ToString());
                    else
                        if(c.TelefonoTrabajo != 0)
                        lvi.SubItems.Add(c.TelefonoTrabajo.ToString());
                
                lvi.SubItems.Add(c.Email.ToString());
                lvi.SubItems.Add(c.TipoCliente.ToString());
                lvi.Tag = c;
                lvClientes.Items.Add(lvi);
            }
        }

        private void nuevoInquilinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GI.BR.Clientes.ClienteFactory cf = new GI.BR.Clientes.ClienteFactory();
            frmFichaCliente frm = new frmFichaCliente();
            frm.Cliente = cf.CrearClaseCliente(typeof(GI.BR.Clientes.Inquilino));
            frm.Show();
        }

        private void toolStripButtonBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarClientes frmBuscar = new frmBuscarClientes();
            if (frmBuscar.ShowDialog() == DialogResult.OK)
            {
                this.clientes = frmBuscar.Clientes;
                this.CargarClientes(frmBuscar.Clientes);
            }
        }

        private void verFichatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvClientes_DoubleClick( sender,  e);
        }

        private void editarFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvClientes.SelectedItems.Count != 1)
                return;
            frmFichaCliente frm = new frmFichaCliente();
            
            frm.Cliente = (GI.BR.Clientes.Cliente)lvClientes.SelectedItems[0].Tag;
            if (frm.ShowDialog() == DialogResult.OK)
                this.CargarClientes(clientes);
        }
    }
}