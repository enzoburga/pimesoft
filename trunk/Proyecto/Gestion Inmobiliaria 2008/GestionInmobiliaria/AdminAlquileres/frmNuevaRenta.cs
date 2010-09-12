using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.AdminAlquileres
{
    public partial class frmNuevaRenta : GI.Framework.Seguridad.FrmGISeguridad
    {
        private GI.BR.AdmAlquileres.ValorRenta valorRenta;
        private GI.BR.AdmAlquileres.ValorRenta valorRentaClone;

        private GI.BR.AdmAlquileres.Contrato contrato;

        public GI.BR.AdmAlquileres.Contrato Contrato
        {
            get { return contrato; }
            set { contrato = value; }
        }

        public GI.BR.AdmAlquileres.ValorRenta ValorRenta
        {
            get { return valorRenta; }
            set
            {
                valorRenta = value;
                Inicializar();
            }
        }

        private void Inicializar()
        {
            #region Inicializar Combo Moneda


            #region Inicializar Combos            

            #region Monedas
            int cont = 0;
            int indexMonedaMonto = 0;

            foreach (GI.BR.Monedas.Moneda M in GI.BR.Monedas.MonedasFlyweigthFactory.GetInstancia.GetMonedas)
            {


                if (ValorRenta.Monto.Moneda.IdMoneda == M.IdMoneda)
                    indexMonedaMonto = cont;

                cbMoneda.Items.Add(M);

                cont++;
            }
            cbMoneda.SelectedIndex = indexMonedaMonto; 
            #endregion

            #region Meses
            cbMesDesde.Items.Add("Enero");
            cbMesDesde.Items.Add("Febrero");
            cbMesDesde.Items.Add("Marzo");
            cbMesDesde.Items.Add("Abril");
            cbMesDesde.Items.Add("Mayo");
            cbMesDesde.Items.Add("Junio");
            cbMesDesde.Items.Add("Julio");
            cbMesDesde.Items.Add("Agosto");
            cbMesDesde.Items.Add("Septiembre");
            cbMesDesde.Items.Add("Octubre");
            cbMesDesde.Items.Add("Noviembre");
            cbMesDesde.Items.Add("Diciembre");

            cbMesHasta.Items.Add("Enero");
            cbMesHasta.Items.Add("Febrero");
            cbMesHasta.Items.Add("Marzo");
            cbMesHasta.Items.Add("Abril");
            cbMesHasta.Items.Add("Mayo");
            cbMesHasta.Items.Add("Junio");
            cbMesHasta.Items.Add("Julio");
            cbMesHasta.Items.Add("Agosto");
            cbMesHasta.Items.Add("Septiembre");
            cbMesHasta.Items.Add("Octubre");
            cbMesHasta.Items.Add("Noviembre");
            cbMesHasta.Items.Add("Diciembre");
            #endregion

            #endregion

            #endregion

            valorRentaClone = (GI.BR.AdmAlquileres.ValorRenta)ValorRenta.Clone();

            if (ValorRenta.IdValorRenta != 0)
            {
                tbMonto.Text = ValorRenta.Monto.Importe.ToString();
                tbAnioDesde.Text = ValorRenta.AnioVigenciaDesde.ToString();
                tbAnioHasta.Text = ValorRenta.AnioVigenciaHasta.ToString();
                cbMesDesde.SelectedIndex = ValorRenta.MesVigenciaDesde - 1;
                cbMesHasta.SelectedIndex = ValorRenta.MesVigenciaHasta - 1;
            }
            else
            {
                
                tbAnioDesde.Text = DateTime.Today.Year.ToString();
                tbAnioHasta.Text = DateTime.Today.Year.ToString();
                cbMesDesde.SelectedIndex = DateTime.Today.Month - 1;
                cbMesHasta.SelectedIndex = DateTime.Today.Month - 1;
            }
        }

        public frmNuevaRenta()
        {
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            string error = CargarRenta();
            if (error != "")
            {
                GI.Framework.General.GIMsgBox.Show(error, GI.Framework.General.enumTipoMensaje.Advertencia);
                return;            
            }



            this.DialogResult = DialogResult.OK;
            this.Close();
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

        private string CargarRenta()
        {
            int AnioDesde;
            int AnioHasta;
            int monto;

            if (!int.TryParse(tbAnioDesde.Text, out AnioDesde))
                return "El año desde debe ser un campo numérico.";

            if (!int.TryParse(tbAnioHasta.Text, out AnioHasta))
                return "El año hasta debe ser un campo numérico.";

            if (AnioDesde == AnioHasta)
            {
                if (cbMesDesde.SelectedIndex > cbMesHasta.SelectedIndex)
                    return "La fecha Desde debe ser menor a la fecha Hasta";
            }
            else
            {
                if (AnioDesde > AnioHasta)
                    return "La fecha Desde debe ser menor a la fecha Hasta";
            }

            if (!int.TryParse(tbMonto.Text, out monto))
                return "El monto debe ser un campo numérico.";
            if (monto < 0)
                return "El monto debe ser mayor a 0 (cero).";

            ValorRenta.AnioVigenciaDesde = int.Parse(tbAnioDesde.Text);
            ValorRenta.AnioVigenciaHasta = int.Parse(tbAnioHasta.Text);
            ValorRenta.MesVigenciaDesde = cbMesDesde.SelectedIndex + 1;
            ValorRenta.MesVigenciaHasta = cbMesHasta.SelectedIndex + 1;
            ValorRenta.Monto.Importe = int.Parse(tbMonto.Text);
            ValorRenta.Monto.Moneda = (GI.BR.Monedas.Moneda)cbMoneda.SelectedItem;

            if (!FechaPerteneceARango(valorRenta.MesVigenciaDesde, valorRenta.AnioVigenciaDesde) || !FechaPerteneceARango(valorRenta.MesVigenciaHasta, valorRenta.AnioVigenciaHasta))
                return "El rango de fechas del monto debe esta contenido en el rango de fechas del contrato.";

            if (!ValidarSuperposicionRentas(ValorRenta))
            {
                return "No se puede modificar el monto, se superpone con otros ya creados.";
            }
        
            return "";

        }

        public bool FechaPerteneceARango(int MesRenta, int AnioRenta)
        {
            bool esMenorHasta = false;
            bool esMayorDesde = false;

            if (AnioRenta == contrato.FechaInicio.Year)
            {
                if (MesRenta >= contrato.FechaInicio.Month)
                    esMayorDesde = true;
            }
            else
                esMayorDesde = (AnioRenta > contrato.FechaInicio.Year);

            if (AnioRenta == contrato.FechaVencimiento.Year)
            {
                if (MesRenta <= contrato.FechaVencimiento.Month)
                    esMenorHasta = true;
            }
            else
                esMenorHasta = (AnioRenta < contrato.FechaVencimiento.Year);

            return esMenorHasta && esMayorDesde;
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

        private bool ValidarSuperposicionRentas(GI.BR.AdmAlquileres.ValorRenta valorRenta)
        {
            foreach (GI.BR.AdmAlquileres.ValorRenta vr in contrato.ValoresRenta)
            {
                if (valorRenta.IdValorRenta != vr.IdValorRenta)
                    if (vr.FechaPerteneceARango(valorRenta.MesVigenciaDesde, valorRenta.AnioVigenciaDesde) || vr.FechaPerteneceARango(valorRenta.MesVigenciaHasta, valorRenta.AnioVigenciaHasta))
                        return false;
            }
            return true;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.ValorRenta = (GI.BR.AdmAlquileres.ValorRenta)valorRentaClone.Clone();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}