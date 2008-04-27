using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.AdminAlquileres
{
    public partial class frmFichaAdmAlquileres : GI.Framework.Seguridad.FrmGISeguridad
    {
        public frmFichaAdmAlquileres()
        {
            InitializeComponent();
            Inicializar();
        }

        private GI.BR.AdmAlquileres.AdmAlquiler admAlquiler;
        private GI.BR.AdmAlquileres.AdmAlquiler admAlquilerClone;

        public GI.BR.AdmAlquileres.AdmAlquiler AdmAlquiler
        {
            get { return admAlquiler; }
            set
            {

                admAlquiler = value;
                admAlquilerClone = (GI.BR.AdmAlquileres.AdmAlquiler)admAlquiler.Clone();

                foreach (System.Windows.Forms.TabPage Page in this.tabControl.TabPages)
                {
                    if (Page.Controls.Count != 1) continue;
                    if (Page.Controls[0] is TabContenidoAdmAlquiler)
                        ((TabContenidoAdmAlquiler)Page.Controls[0]).AdmAlquiler = AdmAlquiler;

                }

            }
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