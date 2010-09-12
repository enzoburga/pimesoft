using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.AdminAlquileres
{
    public partial class CtrlContrato : UserControl
    {
        public CtrlContrato()
        {
            InitializeComponent();
        }

        protected void Inicializar()
        {
            valorBindingSource.Add(Contrato.Monto);
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

                if (AdmAlquiler.ContratoVigente != null)
                {
                    if (contrato.Monto.Moneda.IdMoneda == M.IdMoneda)
                        indexMonedaMonto = cont;
                    if (contrato.Deposito.Moneda.IdMoneda == M.IdMoneda)
                        indexMonedaDeposito = cont;
                }
                cbMonedaDepositoContrato.Items.Add(M);
                cbMonedaMontoContrato.Items.Add(M);

                cont++;
            }
            cbMonedaDepositoContrato.SelectedIndex = indexMonedaDeposito;
            cbMonedaMontoContrato.SelectedIndex = indexMonedaMonto;
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
                dtpFechaCancelacion.Value = this.AdmAlquiler.ContratoVigente.FechaCancelacion.Value;
            }

            //Cargo solo si no es un contrato nuevo.
            if (this.AdmAlquiler.ContratoVigente.IdContrato != 0)
            {
                if (this.AdmAlquiler.ContratoVigente.FechaCancelacion.HasValue)


                dtpFechaInicio.Value = this.AdmAlquiler.ContratoVigente.FechaInicio;
                dtpFechaVencimiento.Value = this.AdmAlquiler.ContratoVigente.FechaVencimiento;

                cbMonedaDepositoContrato.SelectedItem = this.AdmAlquiler.ContratoVigente.Deposito.Moneda;
                cbMonedaMontoContrato.SelectedItem = this.AdmAlquiler.ContratoVigente.Monto.Moneda;
            }
        }



        protected void CargarContrato()
        {
            this.Contrato.FechaVencimiento = dtpFechaVencimiento.Value;
            this.Contrato.FechaInicio = dtpFechaInicio.Value;
            if (cBoxCancelado.Checked)
                this.Contrato.FechaCancelacion = dtpFechaCancelacion.Value;
            this.Contrato.Deposito.Moneda = (GI.BR.Monedas.Moneda)cbMonedaDepositoContrato.SelectedItem;
            this.Contrato.Monto.Moneda = (GI.BR.Monedas.Moneda)cbMonedaMontoContrato.SelectedItem;
        }

        private GI.BR.AdmAlquileres.Contrato contrato;
        public GI.BR.AdmAlquileres.Contrato Contrato
        {
            get { return contrato; }
            set
            {
                contrato = value; 
                Inicializar();
                CargarAlquiler();
            }
        }



        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            this.contrato.FechaInicio = dtpFechaInicio.Value;
        }

        private void dtpFechaVencimiento_ValueChanged(object sender, EventArgs e)
        {
            this.contrato.FechaVencimiento = dtpFechaVencimiento.Value;
        }

        private void cBoxCancelado_CheckedChanged(object sender, EventArgs e)
        {
            if (SoloLectura) return;
            this.dtpFechaCancelacion.Enabled = cBoxCancelado.Checked;
        }        
    }
}