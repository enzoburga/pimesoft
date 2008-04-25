using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Clientes
{
    public partial class frmListadoClientes : Form//GI.Framework.Seguridad.FrmGISeguridad
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

        private void nuevoPropietarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFichaCliente frm = new frmFichaCliente();
            frm.Cliente = new GI.BR.Propietario();
            frm.Show();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            if(tbBuscar.Text.Length <2)
            {
                GI.Framework.General.GIMsgBox.Show("Debe ingresar al menos dos caracteres.", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }
            GI.BR.Clientes clientes = new GI.BR.Clientes();
            clientes.RecuperarPropietarios(tbBuscar.Text);

            if(clientes.Count <1)
            {
                GI.Framework.General.GIMsgBox.Show("No se han encontrado clientes coincidentes con el criterio.", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }


            CargarClientes(clientes);
        }

        private void CargarClientes(GI.BR.Clientes clientes)
        {
            ListViewItem lvi;
            lvClientes.Items.Clear();
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

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoInquilinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFichaCliente frm = new frmFichaCliente();
            frm.Cliente = new GI.BR.Inquilino();
            frm.Show();
        }
    }
}