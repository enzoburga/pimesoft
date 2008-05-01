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
                pago.Importe = Contrato.Monto;

            pago.MesCancelado = cbMeses.SelectedIndex+1;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private string Validar()
        {
            //Valido que no sea de un mes repetido.
            foreach (GI.BR.AdmAlquileres.Pago p in pagos)
            {
                if (p.IdPago != pago.IdPago)
                {
                    if (p.MesCancelado == cbMeses.SelectedIndex + 1)
                        return "Ya hay un pago generado para el mes: " + (System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(p.MesCancelado)).ToUpper();
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

        private void frmNuevoPago_Load(object sender, EventArgs e)
        {
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

            cbMeses.SelectedIndex = 0;

            lImporte.Text = contrato.Monto.ToString();
        }
    }
}