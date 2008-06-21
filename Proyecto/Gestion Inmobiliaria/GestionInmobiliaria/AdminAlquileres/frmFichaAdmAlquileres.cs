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


                InicializarTabs();

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

            admAlquiler = (GI.BR.AdmAlquileres.AdmAlquiler)admAlquilerClone.Clone();
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
            if (AdmAlquiler.Alquiler == null)
            {
                GI.Framework.General.GIMsgBox.Show("Debe seleccionar una Propiedad en Alquiler.", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }

            try
            {


                //Verifico si la adm de alquiler esta o no guardado. Si lo esta lo actualizo.
                //Busco la administracion en el primer Tab.
                if (nuevoAdmAlquiler)
                {
                    if (ExisteAdmAlquiler(AdmAlquiler))
                    {
                        GI.Framework.General.GIMsgBox.Show("Ya Existe una administración de alquiler para la propieadad seleccionada.", GI.Framework.General.enumTipoMensaje.Advertencia);
                        return;
                    }

                    if ((guardado = ((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).AdmAlquiler.Guardar()))
                    {
                        nuevoAdmAlquiler = false;
                        //Guardo el contrato vigente.                        
                        if (!(guardado = AdmAlquiler.ContratoVigente.Guardar()))
                        {
                            AdmAlquiler.Eliminar();
                        }
                    }
                }
                else
                {


                    if ((guardado = ((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).AdmAlquiler.Actualizar()))
                    {
                        //Actualizo el contrato vigente.
                        if (AdmAlquiler.ContratoVigente.IdContrato == 0)
                            guardado = AdmAlquiler.ContratoVigente.Guardar();
                        else
                            guardado = AdmAlquiler.ContratoVigente.Actualizar();
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




        private void nuevoContratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SoloLectura)
            {
                GI.Framework.General.GIMsgBox.ShowSoloLectura();
                return;
            }
            if (AdmAlquiler.Alquiler == null)
            {
                GI.Framework.General.GIMsgBox.Show("Debe seleccionar una Propiedad en Alquiler.", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }

            GI.BR.AdmAlquileres.Contrato nuevoContrato = new GI.BR.AdmAlquileres.Contrato();
            nuevoContrato.Deposito = new GI.BR.Valor();
            nuevoContrato.Deposito.Moneda = new GI.BR.Monedas.Moneda();
            nuevoContrato.Vigente = true;

            nuevoContrato.Observaciones = "";
            if (admAlquiler.ContratoVigente.FechaCancelacion.HasValue)
            {
                nuevoContrato.FechaInicio = admAlquiler.ContratoVigente.FechaCancelacion.Value.AddDays(1);
                nuevoContrato.FechaVencimiento = admAlquiler.ContratoVigente.FechaCancelacion.Value.AddDays(1);
            }
            else
            {
                nuevoContrato.FechaInicio = admAlquiler.ContratoVigente.FechaVencimiento.AddDays(1);
                nuevoContrato.FechaVencimiento = admAlquiler.ContratoVigente.FechaVencimiento.AddDays(1);
            }


            frmNuevoContrato frmNuevoContrato = new frmNuevoContrato();
            frmNuevoContrato.Contrato = nuevoContrato;
            frmNuevoContrato.ContratosHistoricos = AdmAlquiler.Contratos;

            if (frmNuevoContrato.ShowDialog() == DialogResult.OK)
            {
                nuevoContrato.Alquiler = AdmAlquiler.Alquiler;
                nuevoContrato.ContratoAnterior = this.AdmAlquiler.ContratoVigente;

                if (nuevoContrato.Guardar())
                {
                    this.AdmAlquiler.ContratoVigente.Vigente = false;
                    //this.AdmAlquiler.ContratoVigente.ContratoAnterior = nuevoContrato;
                    this.AdmAlquiler.ContratoVigente.Actualizar();
                    this.AdmAlquiler.ContratoVigente = nuevoContrato;

                    InicializarTabs();

                    
                }
                else
                {
                    GI.Framework.General.GIMsgBox.Show("No se han guardado los cambios.", GI.Framework.General.enumTipoMensaje.Error);

                }

                
            }
        }

        private void InicializarTabs()
        {
            foreach (System.Windows.Forms.TabPage Page in this.tabControl.TabPages)
            {
                if (Page.Controls.Count != 1) continue;
                if (Page.Controls[0] is TabContenidoAdmAlquiler)
                    ((TabContenidoAdmAlquiler)Page.Controls[0]).AdmAlquiler = AdmAlquiler;
            }
        }

        private void ingresarUnPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SoloLectura)
            {
                GI.Framework.General.GIMsgBox.ShowSoloLectura();
                return;
            }

            this.tabControl.SelectedIndex = 1;
            ((TabPagos)this.tabControl.TabPages[1].Controls[0]).IngresarNuevoPago();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bCancelar_Click(sender, e);
        }

        private void renovarContratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SoloLectura)
            {
                GI.Framework.General.GIMsgBox.ShowSoloLectura();
                return;
            }
            if (AdmAlquiler.Alquiler == null)
            {
                GI.Framework.General.GIMsgBox.Show("Debe seleccionar una Propiedad en Alquiler.", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }

            GI.BR.AdmAlquileres.Contrato nuevoContrato = new GI.BR.AdmAlquileres.Contrato();
            nuevoContrato.Deposito = AdmAlquiler.ContratoVigente.Deposito;
            nuevoContrato.DiaCobro = AdmAlquiler.ContratoVigente.DiaCobro;
            nuevoContrato.Inquilino = admAlquiler.ContratoVigente.Inquilino;

            if (admAlquiler.ContratoVigente.FechaCancelacion.HasValue)
            {
                nuevoContrato.FechaInicio = admAlquiler.ContratoVigente.FechaCancelacion.Value.AddDays(1);
                nuevoContrato.FechaVencimiento = admAlquiler.ContratoVigente.FechaCancelacion.Value.AddDays(1);
            }
            else
            {
                nuevoContrato.FechaInicio = admAlquiler.ContratoVigente.FechaVencimiento.AddDays(1);
                nuevoContrato.FechaVencimiento = admAlquiler.ContratoVigente.FechaVencimiento.AddDays(1);
            }

            nuevoContrato.Vigente = true;
            nuevoContrato.Observaciones = "";

            frmNuevoContrato frmNuevoContrato = new frmNuevoContrato();
            frmNuevoContrato.Contrato = nuevoContrato;
            frmNuevoContrato.ContratosHistoricos = AdmAlquiler.Contratos;

            if (frmNuevoContrato.ShowDialog() == DialogResult.OK)
            {
                nuevoContrato.Alquiler = AdmAlquiler.Alquiler;
                if (nuevoContrato.Guardar())
                {
                    this.AdmAlquiler.ContratoVigente.Vigente = false;
                    this.AdmAlquiler.ContratoVigente.ContratoAnterior = nuevoContrato;
                    this.AdmAlquiler.ContratoVigente.Actualizar();
                    this.AdmAlquiler.ContratoVigente = nuevoContrato;

                    InicializarTabs();


                }
                else
                {
                    GI.Framework.General.GIMsgBox.Show("No se han guardado los cambios.", GI.Framework.General.enumTipoMensaje.Error);

                }


            }
        }

        private bool ExisteAdmAlquiler(GI.BR.AdmAlquileres.AdmAlquiler AdmAlquiler)
        { 
            GI.BR.AdmAlquileres.AdmAlquileres admAlq = new GI.BR.AdmAlquileres.AdmAlquileres();
            admAlq.RecuperarAdmAlquileresTodos();

            foreach (GI.BR.AdmAlquileres.AdmAlquiler a in admAlq)
            {
                if (a.Alquiler.IdPropiedad == AdmAlquiler.Alquiler.IdPropiedad)
                    return true;
            }

            return false;

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool guardado = false;


            if (SoloLectura)
            {
                GI.Framework.General.GIMsgBox.ShowSoloLectura();
                return;
            }
            if (AdmAlquiler.Alquiler == null)
            {
                GI.Framework.General.GIMsgBox.Show("Debe seleccionar una Propiedad en Alquiler.", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }



            try
            {

                //Verifico si la adm de alquiler esta o no guardado. Si lo esta lo actualizo.
                //Busco la administracion en el primer Tab.
                if (nuevoAdmAlquiler)
                {
                    if (ExisteAdmAlquiler(AdmAlquiler))
                    {
                        GI.Framework.General.GIMsgBox.Show("Ya Existe una administración de alquiler para la propieadad seleccionada.", GI.Framework.General.enumTipoMensaje.Advertencia);
                        return;
                    }

                    if ((guardado = ((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).AdmAlquiler.Guardar()))
                    {
                        nuevoAdmAlquiler = false;
                        //Guardo el contrato vigente.
                        if (!(guardado = AdmAlquiler.ContratoVigente.Guardar()))
                        {
                            AdmAlquiler.Eliminar();
                            nuevoAdmAlquiler = false;
                        }

                    }
                }
                else
                {
                    if ((guardado = ((TabDatosPrincipales)tabControl.TabPages[0].Controls[0]).AdmAlquiler.Actualizar()))
                    {
                        //Actualizo el contrato vigente.
                        if (AdmAlquiler.ContratoVigente.IdContrato == 0)
                            guardado = AdmAlquiler.ContratoVigente.Guardar();
                        else
                            guardado = AdmAlquiler.ContratoVigente.Actualizar();
                    }
                }

                if (guardado)
                {
                    InicializarTabs();
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

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GI.Reportes.Clases.AdmAlquileres.ReporteFichaAdmAlquiler repFicha = new GI.Reportes.Clases.AdmAlquileres.ReporteFichaAdmAlquiler("Ficha de Administración de Alquiler", admAlquiler);
            GI.Reportes.Visor.FrmVisorReporte frm = new GI.Reportes.Visor.FrmVisorReporte(repFicha);
            frm.Show();
        }

        private void toolStripButtonImprimir_Click(object sender, EventArgs e)
        {
            imprimirToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButtonRealizarPago_Click(object sender, EventArgs e)
        {
            ingresarUnPagoToolStripMenuItem_Click(sender, e);
        }
    }
   
}