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
            lvClientes.ListViewItemSorter = sorter;
        }

        Framework.ListView.ListViewColumnSorter sorter = new GI.Framework.ListView.ListViewColumnSorter();
        private GI.BR.Clientes.Clientes clientes = new GI.BR.Clientes.Clientes();

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
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.clientes.Add(frm.Cliente);
                this.CargarClientes(clientes);
            }
        }


        public void Inicializar()
        {
            clientes = new GI.BR.Clientes.Clientes();
            clientes.RecuperarTodos();
            CargarClientes(clientes);
        
        
        }

        private void CargarClientes(GI.BR.Clientes.Clientes clientes)
        {
            ListViewItem lvi;
            lvClientes.Items.Clear();
            foreach (GI.BR.Clientes.Cliente c in clientes)
            {
                lvi  = new ListViewItem();
                lvi.Text = c.ToString();


                if(c.TelefonoParticular != "")
                    lvi.SubItems.Add(c.TelefonoParticular.ToString());
                else
                    if (c.TelefonoCelular != "")
                        lvi.SubItems.Add(c.TelefonoCelular.ToString());
                    else
                        if (c.TelefonoTrabajo != "")
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
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.clientes.Add(frm.Cliente);
                this.CargarClientes(clientes);
            }
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

        private void nuevoClientePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GI.BR.Clientes.ClienteFactory cf = new GI.BR.Clientes.ClienteFactory();
            frmFichaCliente frm = new frmFichaCliente();
            frm.Cliente = cf.CrearClaseCliente(typeof(GI.BR.Clientes.ClientePedido));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.clientes.Add(frm.Cliente);
                this.CargarClientes(clientes);
            }
        }

        private void lvClientes_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            sorter.SetTipoComparacion(GI.Framework.ListView.ListViewColumnSorter.TipoComparacion.STRING);

            if (e.Column == sorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (sorter.Order == SortOrder.Ascending)
                {
                    sorter.Order = SortOrder.Descending;
                }
                else
                {
                    sorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                sorter.SortColumn = e.Column;
                sorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.lvClientes.Sort();
        }
    }
}