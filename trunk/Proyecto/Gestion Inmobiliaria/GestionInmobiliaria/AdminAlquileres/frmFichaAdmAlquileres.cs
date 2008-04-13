using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.AdminAlquileres
{
    public partial class frmFichaAdmAlquileres : Form
    {
        public frmFichaAdmAlquileres()
        {
            InitializeComponent();
            Inicializar();
        }


        private void Inicializar()
        {
            System.Windows.Forms.TabPage tabPage;
            System.Windows.Forms.Control control;

            tabPage = new TabPage("Datos Vigentes");
            control = new TabDatosPrincipales();
            control.Dock = DockStyle.Fill;
            tabPage.Controls.Add(control);
            tabControl.TabPages.Add(tabPage);

            tabPage = new TabPage("Pagos Realizados");
            control = new TabPagos();
            control.Dock = DockStyle.Fill;
            tabPage.Controls.Add(control);
            tabControl.TabPages.Add(tabPage);

            tabPage = new TabPage("Historico Inquilinos");
            control = new TabHistorico();
            control.Dock = DockStyle.Fill;
            tabPage.Controls.Add(control);
            tabControl.TabPages.Add(tabPage);


        }
    }
}