using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.AdminAlquileres
{
    public partial class frmNuevoPago : Form
    {
        public frmNuevoPago()
        {
            InitializeComponent();
        }

        private GI.BR.AdmAlquileres.Pago pagoClone;
        private GI.BR.AdmAlquileres.Pago pago;
        private GI.BR.AdmAlquileres.Pagos pagos;
        private GI.BR.AdmAlquileres.Contrato contrato;

        public GI.BR.AdmAlquileres.Pago Pago
        {
            get { return pago; }
            set
            {
                pago = value;
                pagoClone = (GI.BR.AdmAlquileres.Pago)pago.Clone();
                Inicializar();
                CargarPago();
            }
        }

        private void CargarPago()
        {
            if (pago.IdPago != 0)
            {
                this.cbAnio.SelectedIndex = GetIndexAnio( pago.AnioPagado);
                this.cbMeses.SelectedIndex = pago.MesCancelado - 1;
            }
        }

        public GI.BR.AdmAlquileres.Contrato Contrato { get { return contrato; } set { contrato = value; } }
        public GI.BR.AdmAlquileres.Pagos Pagos { set { pagos = value; } }


        private void bAceptar_Click(object sender, EventArgs e)
        {
            string error = Validar();
            if (error != "")
            {
                GI.Framework.General.GIMsgBox.Show(error, GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }

            pago.Anulado = false;
            pago.FechaPago = dtpFechaPago.Value;
            pago.FechaAlta = DateTime.Today;
            pago.IdContrato = Contrato.IdContrato;

            if(pagoClone.IdPago == 0)
                pago.Importe = contrato.GetMonto(cbMeses.SelectedIndex + 1, int.Parse(cbAnio.SelectedItem.ToString()));

            pago.MesCancelado = cbMeses.SelectedIndex+1;
            pago.AnioPagado = int.Parse(cbAnio.SelectedItem.ToString());

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private string Validar()
        {
            if (contrato.GetMonto(cbMeses.SelectedIndex + 1, int.Parse(cbAnio.SelectedItem.ToString())) == null)
                return "No hay una renta definida para el mes y el año seleccionados.";

            int anio;

            //Valido que no sea de un mes repetido.
            foreach (GI.BR.AdmAlquileres.Pago p in pagos)
            {
                if (p.IdPago != pago.IdPago)
                {
                    if (p.MesCancelado == cbMeses.SelectedIndex + 1 && p.AnioPagado == int.Parse(cbAnio.SelectedItem.ToString()))
                        return "Ya hay un pago generado para el mes " + (System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(p.MesCancelado)).ToUpper() + " de " + cbAnio.SelectedItem.ToString();
                }
            }

            return "";
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            pago = (GI.BR.AdmAlquileres.Pago)pagoClone.Clone();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Inicializar()
        {
            for (int i = contrato.FechaInicio.Year; i <= contrato.FechaVencimiento.Year; i++)
            {
                cbAnio.Items.Add(i);
            }

            cbAnio.SelectedIndex = 0;

            cbMeses.Items.Add("Enero");
            cbMeses.Items.Add("Febrero");
            cbMeses.Items.Add("Marzo");
            cbMeses.Items.Add("Abril");
            cbMeses.Items.Add("Mayo");
            cbMeses.Items.Add("Junio");
            cbMeses.Items.Add("Julio");
            cbMeses.Items.Add("Agosto");
            cbMeses.Items.Add("Septiembre");
            cbMeses.Items.Add("Octubre");
            cbMeses.Items.Add("Noviembre");
            cbMeses.Items.Add("Diciembre");

            cbMeses.SelectedIndex = DateTime.Today.Month-1;           
        }

        private void cbMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetImporte();
        }

        private int GetIndexAnio(int anio)
        {
            for (int i = 0; i < cbAnio.Items.Count; i++)
            {
                if (cbAnio.Items[i].ToString() == anio.ToString())
                    return i;
            }

            throw new Exception("No se encuentra el anio a seleccionar en el combo.");
        }

        private void SetImporte()
        {
            GI.BR.Valor monto = contrato.GetMonto(cbMeses.SelectedIndex + 1, int.Parse(cbAnio.SelectedItem.ToString()));
            if (monto == null)
                lImporte.Text = "--------";
            else
                lImporte.Text = monto.ToString();
        }

        private void cbAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetImporte();
        }
    }
}