using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades.Formularios
{
    public partial class FrmEnviarFichasMail : Form
    {

        private GI.BR.Propiedades.Propiedades propiedades;

        public FrmEnviarFichasMail()
        {
            InitializeComponent();



        }


        public FrmEnviarFichasMail(GI.BR.Propiedades.Propiedades Propiedades)
            : this()
        {
            propiedades = Propiedades;
            lPropiedadesCodigo.Text = "";
            foreach (GI.BR.Propiedades.Propiedad p in Propiedades)
            {
                lPropiedadesCodigo.Text += p.Codigo.ToString() + " ";
            }
        }

        private void bConfigurarCorreo_Click(object sender, EventArgs e)
        {
            UI.Generales.FrmSmtpConfig frm = new GI.UI.Generales.FrmSmtpConfig();
            frm.ShowDialog();

        }





    }
}