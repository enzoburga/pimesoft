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
            int indexMonedaMonto = 0;
            int cont = 0;
            foreach (GI.BR.Monedas.Moneda M in Monedas)
            {

                if (Contrato != null)
                {
                    if (contrato.Monto.Moneda.IdMoneda == M.IdMoneda)
                        indexMonedaMonto = cont;
                    if (contrato.Deposito.Moneda.IdMoneda == M.IdMoneda)
                        indexMonedaDeposito = cont;
                }
                cbMonedaDepositoContrato.Items.Add(M);

                cont++;
            }
            cbMonedaDepositoContrato.SelectedIndex = indexMonedaDeposito;
            #endregion

            #region Maximos y minimos de Fechas

            dtpFechaCancelacion.MaxDate = dtpFechaVencimiento.Value;
            dtpFechaCancelacion.MinDate = dtpFechaInicio.Value;

            dtpFechaInicio.MaxDate = dtpFechaVencimiento.Value;
            dtpFechaVencimiento.MinDate = dtpFechaInicio.Value;

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


            if (!contrato.FechaCancelacion.HasValue)
            {
                cBoxCancelado.Checked = false;
                dtpFechaCancelacion.Enabled = false;
            }
            else
            {
                cBoxCancelado.Checked = true;
                dtpFechaCancelacion.Value = this.Contrato.FechaCancelacion.Value;
            }

            //Cargo solo si no es un contrato nuevo.
            if (this.Contrato.IdContrato != 0)
            {
                if (this.Contrato.FechaCancelacion.HasValue)
                    dtpFechaCancelacion.Value = Contrato.FechaCancelacion.Value;

                dtpFechaInicio.Value = this.Contrato.FechaInicio;
                dtpFechaVencimiento.Value = this.Contrato.FechaVencimiento;

                cbMonedaDepositoContrato.SelectedItem = this.Contrato.Deposito.Moneda;
            }
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
                lvi.SubItems.Add((System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(vr.MesVigenciaDesde)).ToUpper());
                lvi.SubItems.Add(vr.AnioVigenciaDesde.ToString());
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
            dtpFechaCancelacion.MinDate = dtpFechaInicio.Value;
            dtpFechaVencimiento.MinDate = dtpFechaInicio.Value;
        }

        private void dtpFechaVencimiento_ValueChanged(object sender, EventArgs e)
        {
            this.contrato.FechaVencimiento = dtpFechaVencimiento.Value;
            dtpFechaCancelacion.MaxDate = dtpFechaVencimiento.Value;
            dtpFechaInicio.MaxDate = dtpFechaVencimiento.Value;

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
    }
}