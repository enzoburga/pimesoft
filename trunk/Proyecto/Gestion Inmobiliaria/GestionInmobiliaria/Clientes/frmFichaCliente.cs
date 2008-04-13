using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Clientes
{
    public partial class frmFichaCliente : Form
    {
        public frmFichaCliente()
        {
            InitializeComponent();
            Inicializar();
        }



        private void Inicializar()
        {

            System.Windows.Forms.TabPage tabPage;
            System.Windows.Forms.Control control;

            tabPage = new TabPage("Propiedad");
            control = new TabDatosPrincipales();
            control.Dock = DockStyle.Fill;
            tabPage.Controls.Add(control);
            tabControl.TabPages.Add(tabPage);
        }
    }
}