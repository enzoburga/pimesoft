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
        private bool nuevoAdmAlquiler = false;


        public GI.BR.AdmAlquileres.AdmAlquiler AdmAlquiler
        {
            get { return admAlquiler; }
            set
            {

                admAlquiler = value;
                admAlquilerClone = (GI.BR.AdmAlquileres.AdmAlquiler)admAlquiler.Clone();

                if (admAlquiler.Alquiler == null)
                    nuevoAdmAlquiler = true;


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
                        DialogResult = DialogResult.OK;
                        this.Close();
                        break;
                    case DialogResult.No:
                        admAlquiler = (GI.BR.AdmAlquileres.AdmAlquiler)admAlquilerClone.Clone();
                        DialogResult = DialogResult.Cancel;
                        Close();
                        break;//Cierro.
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
                if (nuevoAdmAlquiler)
                {
                    //Verifico si la adm de alquiler esta o no guardado. Si lo esta lo actualizo.
                    //Busco la administracion en el primer Tab.
                    if (nuevoAdmAlquiler)
                    {
                        if ((guardado = ((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).AdmAlquiler.Guardar()))
                        {
                            nuevoAdmAlquiler = false;
                            //Guardo el contrato vigente.
                            guardado = AdmAlquiler.ContratoVigente.Guardar();
                        }
                    }
                    else
                    {
                        if ((guardado = ((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).AdmAlquiler.Actualizar()))
                        {
                            //Actualizo el contrato vigente.
                            guardado = AdmAlquiler.ContratoVigente.Actualizar();
                        }
                    }
                }

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