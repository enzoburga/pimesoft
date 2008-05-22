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

        private GI.BR.Propiedades.Propiedad propiedad;
        System.IO.Stream stream;
        GI.Managers.Propiedades.MngEnviarPropiedadesCorreo mngPropMail;


        public FrmEnviarFichasMail()
        {
            InitializeComponent();



        }


        public FrmEnviarFichasMail(GI.BR.Propiedades.Propiedad Propiedad)
            : this()
        {
            propiedad = Propiedad;
            lPropiedadesCodigo.Text = Propiedad.Codigo;

        }

        private void bConfigurarCorreo_Click(object sender, EventArgs e)
        {
            UI.Generales.FrmSmtpConfig frm = new GI.UI.Generales.FrmSmtpConfig();
            frm.Inicializar();
            frm.ShowDialog();

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
            Close();
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            if (bEnviar.Text == "Cancelar")
            {
                if (mngPropMail != null)
                    mngPropMail.Cancelar();
            }
            if (textBoxEmailTo.Text == "")
            {
                Framework.General.GIMsgBox.Show("Debe ingresar una dirección de correo", GI.Framework.General.enumTipoMensaje.Advertencia);
                textBoxEmailTo.Focus();
                return;
            }

            if (textBoxMessage.Text == "")
            {
                Framework.General.GIMsgBox.Show("Debe ingresar un mensaje", GI.Framework.General.enumTipoMensaje.Advertencia);
                textBoxMessage.Focus();
                return;
            }
            bEnviar.Enabled = false;
            bEnviar.Text = "Cancelar";
            
            toolStripStatusLabelEstado.Text = "Enviando correo...";

            GI.Reportes.Clases.Propiedades.ReporteFichaPropiedad ficha = new GI.Reportes.Clases.Propiedades.ReporteFichaPropiedad(propiedad);

            //CrystalDecisions.Shared.ExportFormatType formato = radioButtonPdf.Checked ? CrystalDecisions.Shared.ExportFormatType.PortableDocFormat: CrystalDecisions.Shared.ExportFormatType.WordForWindows;
            //stream = ficha.GetStreamReporte(formato);

            string body = ficha.GetReporteHtml();

 
            mngPropMail = new GI.Managers.Propiedades.MngEnviarPropiedadesCorreo(
            propiedad,
            body,
            textBoxEmailTo.Text,
            textBoxMessage.Text);

            //System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(mngPropMail.EnviarPropiedad));
            //thread.IsBackground = true;

            mngPropMail.onEnvioFinalizado += new GI.Managers.Propiedades.EnvioCorreoFinalizado(mngPropMail_onEnvioFinalizado);
            bEnviar.Enabled = true;

            mngPropMail.EnviarPropiedad();
            //thread.Start();



        }

        private void mngPropMail_onEnvioFinalizado(GI.BR.Propiedades.Propiedad p, string Mensaje, bool Error)
        {
            //toolStripStatusLabelEstado.Text = Mensaje;

            if (Error)
                Framework.General.GIMsgBox.Show(Mensaje, GI.Framework.General.enumTipoMensaje.Error);

            else
            {
                toolStripStatusLabelEstado.Text = "Correo Enviado!";
                Framework.General.GIMsgBox.Show(Mensaje, GI.Framework.General.enumTipoMensaje.Informacion);
                
            }

            if (stream != null)
            {
                stream.Close();
                stream.Dispose();
            }

            try
            {
                bEnviar.Text = "Enviar";
            }
            catch { }
        }





    }
}