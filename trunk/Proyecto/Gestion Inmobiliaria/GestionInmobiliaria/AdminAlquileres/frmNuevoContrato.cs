using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.AdminAlquileres
{
    public partial class frmNuevoContrato : Form
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

        private bool Validar()
        {
            return true;
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            contrato = (GI.BR.AdmAlquileres.Contrato)contratoClone.Clone();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}