using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Generales
{
    public partial class CtrlContrato :  Framework.Seguridad.ControlGISeguridad
    {
        public CtrlContrato()
        {
            InitializeComponent();
        }


        private GI.BR.AdmAlquileres.Contrato contrato;
        public GI.BR.AdmAlquileres.Contrato Contrato
        {
            get { return contrato; }
            set
            {
                contrato = value;
                if (contrato != null)
                {
                    Inicializar();
                    CargarContrato();
                }
            }
        }

        protected void Inicializar()
        {

            valorBindingSource1.Clear();
            contratoBindingSource.Clear();
            valorBindingSource1.Add(Contrato.Deposito);
            contratoBindingSource.Add(Contrato);

            #region Inicializar Combos

            GI.BR.Monedas.Monedas Monedas = new GI.BR.Monedas.Monedas();
            Monedas.RecuperarTodas();
            int indexMonedaDeposito = 0;
            int cont = 0;
            foreach (GI.BR.Monedas.Moneda M in Monedas)
            {

                if (Contrato != null)
                {
                    if (contrato.Deposito.Moneda.IdMoneda == M.IdMoneda)
                        indexMonedaDeposito = cont;
                }
                cbMonedaDepositoContrato.Items.Add(M);

                cont++;
            }
            cbMonedaDepositoContrato.SelectedIndex = indexMonedaDeposito;

            #endregion

            #region Maximos y minimos de Fechas

            //dtpFechaCancelacion.MaxDate = dtpFechaVencimiento.Value;
            //dtpFechaCancelacion.MinDate = dtpFechaInicio.Value;

            //dtpFechaInicio.MaxDate = dtpFechaVencimiento.Value;
            //dtpFechaVencimiento.MinDate = dtpFechaInicio.Value;

            #endregion

            #region Inicializar Rentas

            LlenarListaRentas();

            #endregion

            if (contrato.Inquilino == null)
                LinkInquilino.Text = "Seleccione un Inquilino";
            else
            {
                LinkInquilino.Text = contrato.Inquilino.ToString();
                LinkInquilino.Tag = contrato.Inquilino;

            }


            //if (!contrato.FechaCancelacion.HasValue)
            //{
                cBoxCancelado.Checked = false;
                dtpFechaCancelacion.Enabled = false;
            //}
            //else
            //{
            //    cBoxCancelado.Checked = true;
            //    dtpFechaCancelacion.Value = this.Contrato.FechaCancelacion.Value;
            //}

            //Cargo solo si no es un contrato nuevo.
            if (this.Contrato.IdContrato != 0)
            {
                this.lvMontos.Enabled = true;
                this.llAgregarMonto.Enabled = true;
                this.llModificarMonto.Enabled = true;
                this.llEliminarMonto.Enabled = true;

                if (contrato.FechaCancelacion.HasValue)
                {                    
                    cBoxCancelado.Checked = true;
                    dtpFechaCancelacion.Enabled = true;
                    dtpFechaCancelacion.Value = this.Contrato.FechaCancelacion.Value;
                }  

                cbMonedaDepositoContrato.SelectedItem = this.Contrato.Deposito.Moneda;
            }
            else
            {
                this.lvMontos.Enabled = false;
                this.llAgregarMonto.Enabled = false;
                this.llModificarMonto.Enabled = false;
                this.llEliminarMonto.Enabled = false;
            }


            dtpFechaInicio.Value = this.Contrato.FechaInicio;
            dtpFechaVencimiento.Value = this.Contrato.FechaVencimiento;

           
        }

        public override bool AsignarSoloLectura(Control Ctrl)
        {

            if (Ctrl.Name == "LinkInquilino" && Ctrl.Text != "Seleccione un Inquilino")
                return false;

            return base.AsignarSoloLectura(Ctrl);
        }

        private void LlenarListaRentas()
        {
            lvMontos.Items.Clear();
            lvMontos.BeginUpdate();
            ListViewItem lvi;
            foreach (GI.BR.AdmAlquileres.ValorRenta vr in this.contrato.ValoresRenta)
            {
                lvi = new ListViewItem();
                lvi.Text = vr.Monto.ToString();
                lvi.SubItems.Add((System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(vr.MesVigenciaDesde)).ToUpper() + " - "+ vr.AnioVigenciaDesde.ToString());
                lvi.SubItems.Add((System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(vr.MesVigenciaHasta)).ToUpper() + " - " +vr.AnioVigenciaHasta.ToString());
                lvi.Tag = vr;
                lvMontos.Items.Add(lvi);
            }

            lvMontos.EndUpdate();
        }



        protected void CargarContrato()
        {
            this.Contrato.FechaVencimiento = dtpFechaVencimiento.Value;
            this.Contrato.FechaInicio = dtpFechaInicio.Value;
            if (cBoxCancelado.Checked)
                this.Contrato.FechaCancelacion = dtpFechaCancelacion.Value;
            this.Contrato.Deposito.Moneda = (GI.BR.Monedas.Moneda)cbMonedaDepositoContrato.SelectedItem;
        }





        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            this.contrato.FechaInicio = dtpFechaInicio.Value;
            //dtpFechaCancelacion.MinDate = dtpFechaInicio.Value;
            //dtpFechaVencimiento.MinDate = dtpFechaInicio.Value;
        }

        private void dtpFechaVencimiento_ValueChanged(object sender, EventArgs e)
        {
            this.contrato.FechaVencimiento = dtpFechaVencimiento.Value;
            //dtpFechaCancelacion.MaxDate = dtpFechaVencimiento.Value;
            //dtpFechaInicio.MaxDate = dtpFechaVencimiento.Value;
        }

        private string Validar()
        {
            int Deposito;
            int DiaVtoCuota;

            if (!int.TryParse(tbDepositoContrato.Text, out Deposito))
                return "El monto debe ser un campo numérico.";
            if (Deposito < 0)
                return "El monto debe ser mayor a 0 (cero).";

            if (!int.TryParse(tbDiaVto.Text, out DiaVtoCuota))
                return "El dia de vencimiento debe ser un campo numérico.";
            if (DiaVtoCuota < 0 && DiaVtoCuota > 31)
                return "El dia de vencimiento debe ser mayor a 0 (cero) y menor a 31.";

            return "";
        }

        private void cBoxCancelado_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxCancelado.Checked)
                this.Contrato.FechaCancelacion = dtpFechaCancelacion.Value;
            else
                this.Contrato.FechaCancelacion = null;

            this.dtpFechaCancelacion.Enabled = cBoxCancelado.Checked;
        }

        private void LinkInquilino_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LinkInquilino.Text == "Seleccione un Inquilino")
            {
                Framework.frmSeleccionador frmSeleccionador = new GI.Framework.frmSeleccionador(new Clientes.SeleccionadorPropietarios(typeof(GI.BR.Clientes.Inquilino)));
                if (frmSeleccionador.ShowDialog() == DialogResult.OK)
                {
                    LinkInquilino.Tag = (GI.BR.Clientes.Inquilino)frmSeleccionador.ObjetoSeleccionado;
                    LinkInquilino.Text = frmSeleccionador.ObjetoSeleccionado.ToString();
                    this.contrato.Inquilino = (GI.BR.Clientes.Inquilino)frmSeleccionador.ObjetoSeleccionado;
                }

            }
            else
            {
                if (LinkInquilino.Tag != null)
                {
                    Clientes.frmFichaCliente frm = new GI.UI.Clientes.frmFichaCliente();
                    frm.SoloLectura = SoloLectura;
                    frm.Cliente = (GI.BR.Clientes.Cliente)LinkInquilino.Tag;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LinkInquilino.Tag = (GI.BR.Clientes.Inquilino)frm.Cliente;
                        LinkInquilino.Text = frm.Cliente.ToString();
                    }
                }
            }
        }

        private void lvMontos_DoubleClick(object sender, EventArgs e)
        {
            if (lvMontos.SelectedItems.Count != 1)
            {
                return;
            }
            GI.UI.AdminAlquileres.frmNuevaRenta frm = new GI.UI.AdminAlquileres.frmNuevaRenta();
            frm.ValorRenta = (GI.BR.AdmAlquileres.ValorRenta)lvMontos.SelectedItems[0].Tag;
            frm.SoloLectura = true;
            frm.ShowDialog();
        }

        private void llEliminarMonto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lvMontos.SelectedItems.Count != 1)
            {
                GI.Framework.General.GIMsgBox.Show("Debe seleccionar un monto.", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }

            if (!ValidarRentaConPagos((GI.BR.AdmAlquileres.ValorRenta)lvMontos.SelectedItems[0].Tag))
            {
                GI.Framework.General.GIMsgBox.Show("No se puede eliminar el monto, ya tiene pagos realizados.", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }

            if (GI.Framework.General.GIMsgBox.ShowConfirmarEliminacion() == DialogResult.Yes)
            {
                if (((GI.BR.AdmAlquileres.ValorRenta)lvMontos.SelectedItems[0].Tag).Eliminar())
                {
                    this.contrato.ValoresRenta.Remove((GI.BR.AdmAlquileres.ValorRenta)lvMontos.SelectedItems[0].Tag);
                    LlenarListaRentas();
                }

            }        
        }

        private bool ValidarRentaConPagos(GI.BR.AdmAlquileres.ValorRenta vr)
        {
            GI.BR.AdmAlquileres.Pagos pagos = new GI.BR.AdmAlquileres.Pagos();
            pagos.RecuperarPorContrato(contrato);

            foreach (GI.BR.AdmAlquileres.Pago p in pagos)
            {
                if (vr.FechaPerteneceARango(p.MesCancelado, p.AnioPagado))
                    return false;
            }

            return true;
        }

        private void llModificarMonto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lvMontos.SelectedItems.Count != 1)
            {
                GI.Framework.General.GIMsgBox.Show("Debe seleccionar un monto.", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }

            if (!ValidarRentaConPagos((GI.BR.AdmAlquileres.ValorRenta)lvMontos.SelectedItems[0].Tag))
            {
                GI.Framework.General.GIMsgBox.Show("No se puede modificar el monto, ya tiene pagos realizados.", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }

            GI.UI.AdminAlquileres.frmNuevaRenta frm = new GI.UI.AdminAlquileres.frmNuevaRenta();
            frm.ValorRenta = (GI.BR.AdmAlquileres.ValorRenta)lvMontos.SelectedItems[0].Tag;
            frm.Contrato = contrato;

            if (frm.ShowDialog() == DialogResult.OK)
            {

                frm.ValorRenta.Actualizar();
                LlenarListaRentas();
            }
            else
                lvMontos.SelectedItems[0].Tag = frm.ValorRenta;

            
        }

        private bool ValidarSuperposicionRentas(GI.BR.AdmAlquileres.ValorRenta valorRenta)
        {
            foreach (GI.BR.AdmAlquileres.ValorRenta vr in contrato.ValoresRenta)
            { 
                if(valorRenta.IdValorRenta != vr.IdValorRenta)
                    if(vr.FechaPerteneceARango(valorRenta.MesVigenciaDesde,valorRenta.AnioVigenciaDesde) || vr.FechaPerteneceARango(valorRenta.MesVigenciaHasta,valorRenta.AnioVigenciaHasta))
                        return false;
            }
            return true;
        }

        private void llAgregarMonto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (contrato.IdContrato == 0)
            {
                GI.Framework.General.GIMsgBox.Show("Debe guardar el contrato antes de agregar Pagos.",GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }
            GI.UI.AdminAlquileres.frmNuevaRenta frm = new GI.UI.AdminAlquileres.frmNuevaRenta();
            GI.BR.AdmAlquileres.ValorRenta valorRenta = new GI.BR.AdmAlquileres.ValorRenta();
            valorRenta.Monto = new GI.BR.Valor();
            valorRenta.Monto.Moneda  = new GI.BR.Monedas.Moneda();

            frm.ValorRenta = valorRenta;

            frm.Contrato = contrato;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                if(frm.ValorRenta.Guardar(contrato))
                    contrato.ValoresRenta.Add(frm.ValorRenta);
            }

            LlenarListaRentas();
        }      
    }
}