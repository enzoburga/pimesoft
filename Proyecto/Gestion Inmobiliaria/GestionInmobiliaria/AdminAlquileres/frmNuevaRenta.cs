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
        private GI.BR.AdmAlquileres.ValoresRenta valores;

        public GI.BR.AdmAlquileres.ValoresRenta Valores
        {
            get { return valores; }
            set { valores = value; }
        }

        public frmNuevaRenta()
        {
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            string error = Validar();
            if (error != "")
            {
                GI.Framework.General.GIMsgBox.Show(error, GI.Framework.General.enumTipoMensaje.Advertencia);
                return;            
            }

            ValorRenta.AnioVigenciaDesde = int.Parse(tbAnioDesde.Text);
            ValorRenta.AnioVigenciaHasta = int.Parse(tbAnioHasta.Text);
            ValorRenta.MesVigenciaDesde = cbMesDesde.SelectedIndex + 1;
            ValorRenta.MesVigenciaHasta = cbMesHasta.SelectedIndex + 1;
            ValorRenta.Monto.Importe = int.Parse(tbMonto.Text);
            ValorRenta.Monto.Moneda = (GI.BR.Monedas.Moneda)cbMoneda.SelectedItem;

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

        private string Validar()
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
        
            return "";

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.ValorRenta = (GI.BR.AdmAlquileres.ValorRenta)valorRentaClone.Clone();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}