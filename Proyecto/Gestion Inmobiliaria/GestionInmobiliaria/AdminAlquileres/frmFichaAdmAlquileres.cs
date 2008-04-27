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

        public override bool AsignarSoloLectura(Control Ctrl)
        {
            if (Ctrl.Name == "bAceptar") return true;

            if (Ctrl.Name == "bCancelar")
            {
                Ctrl.Text = "Cerrar";
                return false;
            }
            return base.AsignarSoloLectura(Ctrl);
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            if (CambioDatosAdmAlquiler())
                switch (GI.Framework.General.GIMsgBox.ShowCancelarPerdidaDatos())
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Yes:
                        bAceptar_Click(null, null);
                        return;
                    case DialogResult.No: break;//Cierro.

                }

            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool CambioDatosAdmAlquiler()
        {
            return false;
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            bool guardado = false;
            if (SoloLectura)
            {
                GI.Framework.General.GIMsgBox.ShowSoloLectura();
                return;
            }
            try
            {
                //Verifico si el cliente esta o no guardado. Si lo esta lo actualizo.
                if (((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).AdmAlquiler.ContratoVigente.IdContrato == 0)
                    guardado = ((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).AdmAlquiler.ContratoVigente.Guardar();
                else
                    guardado = ((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).AdmAlquiler.ContratoVigente.Actualizar();

                if (guardado)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    GI.Framework.General.GIMsgBox.Show("No se han guardado los cambios.", GI.Framework.General.enumTipoMensaje.Error);

                }
            }
            catch (Exception ex)
            {
                GI.Framework.General.GIMsgBox.Show(ex.Message, GI.Framework.General.enumTipoMensaje.Error);

            }
        }
    }
   
}