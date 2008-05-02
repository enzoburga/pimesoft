using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.AdminAlquileres
{
    public partial class frmNuevoContrato : GI.Framework.Seguridad.FrmGISeguridad
    {
        public frmNuevoContrato()
        {
            InitializeComponent();
        }


        private GI.BR.AdmAlquileres.Contrato contratoClone;
        private GI.BR.AdmAlquileres.Contrato contrato;
        public GI.BR.AdmAlquileres.Contrato Contrato
        {
            get { return Contrato; }
            set
            {
                
                contrato = value;
                contratoClone = (GI.BR.AdmAlquileres.Contrato)contrato.Clone();
                this.ctrlContrato1.Contrato = value;
            }
        }

        private GI.BR.AdmAlquileres.Contratos contratosHistoricos;
        public GI.BR.AdmAlquileres.Contratos ContratosHistoricos
        {
            get { return contratosHistoricos; }
            set
            {
                contratosHistoricos = value;
            }
        }

        private string Validar()
        {
            string error = "";

            if (contrato.FechaCancelacion.HasValue)
            {
                if (contrato.FechaInicio >= contrato.FechaCancelacion)
                    return "La Fecha de Inicio debe ser Menor que la de Cancelación.";

                if (contrato.FechaCancelacion <= contrato.FechaVencimiento)
                    return "La Fecha de Cancelación debe ser Menor que la de Vencimiento.";
            }

            if (contrato.FechaInicio >= contrato.FechaVencimiento)
                return "La Fecha de Inicio debe ser Menor que la de Vencimiento.";


            foreach (GI.BR.AdmAlquileres.Contrato c in ContratosHistoricos)
            {
                if (c.IdContrato != contrato.IdContrato)
                {
                    error = VerificarFechas(c, contrato);
                    if (error != "")
                        return error;
                }
            }
            return error;
        }

        private string VerificarFechas(GI.BR.AdmAlquileres.Contrato cExistente, GI.BR.AdmAlquileres.Contrato cNuevo)
        {
            if (cExistente.FechaCancelacion.HasValue)
            {
                if (cNuevo.FechaInicio <= cExistente.FechaCancelacion)
                    return "La Fecha de Inicio debe ser Menor que la de Cancelación.";
            }
            else
            {
                if (cNuevo.FechaInicio <= cExistente.FechaVencimiento)
                    return "La Fecha de Inicio debe ser Menor que la de Vencimiento.";
            }

            return "";
        }



        private void bAceptar_Click(object sender, EventArgs e)
        {
            string error = Validar();
            if (error == "")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            GI.Framework.General.GIMsgBox.Show(error, GI.Framework.General.enumTipoMensaje.Advertencia);
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            contrato = (GI.BR.AdmAlquileres.Contrato)contratoClone.Clone();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}