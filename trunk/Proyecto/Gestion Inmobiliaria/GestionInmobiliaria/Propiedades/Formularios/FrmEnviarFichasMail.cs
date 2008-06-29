using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades.Formularios
{
    public delegate void EnvioFinalizadoHandler(string mensaje, bool error);
    public partial class FrmEnviarFichasMail : Form
    {

        private GI.BR.Propiedades.Propiedades propiedades;
        System.IO.Stream stream;
        GI.Managers.Propiedades.MngEnviarPropiedadesCorreo mngPropMail;
        public event EnvioFinalizadoHandler OnEnvioFinalizado;

        public FrmEnviarFichasMail()
        {
            InitializeComponent();
          
        }


        public FrmEnviarFichasMail(GI.BR.Propiedades.Propiedades Prop)
            : this()
        {
            propiedades = Prop;
            foreach (GI.BR.Propiedades.Propiedad p in Prop)
            {
                tbPropiedades.Text += p.Codigo+"; ";
            }
        }

        public FrmEnviarFichasMail(GI.BR.Propiedades.Propiedades Prop, GI.BR.Clientes.Clientes clientes): this(Prop)
        {
            AgregarClientes(clientes);
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
            if (getEmails().Count == 0)
            {
                Framework.General.GIMsgBox.Show("Debe ingresar una dirección de correo", GI.Framework.General.enumTipoMensaje.Advertencia);
                textBoxEmailTo.Focus();
                return;
            }

            if (!ValidarMails())
            {
                Framework.General.GIMsgBox.Show("Se encontraron direcciones de mail inválidas, corrijalas y vuelva a intentar el envio.", GI.Framework.General.enumTipoMensaje.Advertencia);
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
            GI.Reportes.Clases.Propiedades.ReporteFichaPropiedad ficha;

            System.Collections.Hashtable hashPropiedades = new System.Collections.Hashtable();
            CrystalDecisions.Shared.ExportFormatType formatoCrystal = radioButtonPdf.Checked ? CrystalDecisions.Shared.ExportFormatType.PortableDocFormat: CrystalDecisions.Shared.ExportFormatType.WordForWindows;

            foreach (GI.BR.Propiedades.Propiedad p in this.propiedades)
            {
                ficha = new GI.Reportes.Clases.Propiedades.ReporteFichaPropiedad(p);

                hashPropiedades.Add(p.Codigo, ficha.GetStreamReporte(formatoCrystal));
            }
            

            
            //stream = ficha.GetStreamReporte(formato);

            //string body = ficha.GetReporteHtml();


            GI.Managers.Propiedades.FormatoEnvio formatoAtachments = radioButtonPdf.Checked ? GI.Managers.Propiedades.FormatoEnvio.Pdf : GI.Managers.Propiedades.FormatoEnvio.Word;
            mngPropMail = new GI.Managers.Propiedades.MngEnviarPropiedadesCorreo(
            hashPropiedades,
            formatoAtachments,
            getEmails(),
            textBoxMessage.Text);

            

            //mngPropMail = new GI.Managers.Propiedades.MngEnviarPropiedadesCorreo(
            //propiedad,
            //body,
            //textBoxEmailTo.Text,
            //textBoxMessage.Text);

            //System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(mngPropMail.EnviarPropiedad));
            //thread.IsBackground = true;

            mngPropMail.onEnvioFinalizado += new GI.Managers.Propiedades.EnvioCorreoFinalizado(mngPropMail_onEnvioFinalizado);
            bEnviar.Enabled = true;

            mngPropMail.EnviarPropiedad();
            //thread.Start();



        }

        private bool ValidarMails()
        {            
            foreach (string s in getEmails())
            {
                if (!ValidarEmail(s))
                    return false;
            }
            return true;
        }

        public static bool ValidarEmail(string email)
        {
            // string que contiene caracteres válidos dentro de un e-mail
            string caracteresvalidos = "abcdefghijklmnopqrstuvwxyz1234567890_-.@";
            if (email.Length < 6) return (false);
            // Se valida sobre e-mail en minúsculas y sin espacios antes y después
            email = email.ToLower().Trim();
            // Verifica todos los caracteres
            for (int i = 0; i < email.Length; i++)
                // ¿Es un caracter no-válido?
                if (caracteresvalidos.IndexOf(email[i]) < 0) return (false);
            // Cantidad de @
            if (email.IndexOf('@') < 0) return (false); // No había @
            if (email.IndexOf('@') != email.LastIndexOf('@'))
                return (false); // Hay más de 1 @
            // Cantidad de . a la derecha de @.
            // Se busca un . sólo en el substring a la derecha del @
            if (email.Substring(email.IndexOf('@'),
            email.Length - email.IndexOf('@') - 1).IndexOf('.') < 0)
                return (false);
            // Que el @ no sea el primer símbolo
            if (email.IndexOf('@') == 0) return (false);
            return true;
        }

        private void mngPropMail_onEnvioFinalizado(string Mensaje, bool Error)
        {
            //toolStripStatusLabelEstado.Text = Mensaje;


            if (Error)
            {
                Framework.General.GIMsgBox.Show(Mensaje, GI.Framework.General.enumTipoMensaje.Error);
                
            }
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

            if (OnEnvioFinalizado != null)
                OnEnvioFinalizado(Mensaje, Error);

            //cERRAMOS EL FRM
            Close();
        }

        private void bAgregarContacto_Click(object sender, EventArgs e)
        {
            Framework.frmSeleccionador frm = new GI.Framework.frmSeleccionador(new Clientes.SeleccionadorPropietarios(null));
            frm.MultiSeleccion = true;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                GI.BR.Clientes.Clientes clientes = new GI.BR.Clientes.Clientes();
                foreach(GI.BR.Clientes.Cliente c in frm.ObjetosSeleccionados)
                {
                    clientes.Add(c);
                }

                AgregarClientes(clientes);            
            }

        }

        private void AgregarClientes(GI.BR.Clientes.Clientes clientes)
        {
            string textoAAgregar = "";
            
            if(textBoxEmailTo.Text.Length != 0)
                if (textBoxEmailTo.Text[textBoxEmailTo.Text.Length-1] != ';')
                    textBoxEmailTo.Text += " ;";

            foreach (GI.BR.Clientes.Cliente c in clientes)
            {
                if (c.Email.ToString() != "")
                {
                    
                    textoAAgregar = c.ToString() + " (" + c.Email.ToString() + ");";
                }
                else
                {
                    
                    textoAAgregar = c.ToString() + " ( SIN EMAIL );";
                }

                if (textBoxEmailTo.Text.Length != 0)
                    textoAAgregar = "  " + textoAAgregar;
                textBoxEmailTo.Text += textoAAgregar;
            }           
        }

        private List<string> getEmails()
        {
            string[] split = textBoxEmailTo.Text.Split(new char[] { ';' },StringSplitOptions.RemoveEmptyEntries);
            List<string> emails = new List<string>();
            string email = "";
            foreach (string s in split)
            {
                email = GetStringBetween(s, "(", ")");
                if (email == "" || email == null)
                    email = s;

                emails.Add(email);
            }

            

            return emails;

        }

        private string GetStringBetween(string stream, string from, string to)
        {
            try
            {
                string subField = string.Empty;
                subField = RightOf(stream, from);
                subField = LeftOf(subField, to);
                return subField;
            }
            catch (Exception ex)
            {
                //ErrorTool.ProcessError(ex);
                return null;
            }
        }

        /// <summary>
        /// Will return the text to the LEFT of indicated substring
        /// </summary>
        /// <param name="stream">
        /// string from which to cull a portion of text
        /// </param>
        /// <param name="stringToStopAt">
        /// string that indicates what char or string to stop at
        /// </param>
        /// <returns>
        /// The string to the left of point x (stringToStopAt)
        /// </returns>
        private string LeftOf(string stream, string stringToStopAt)
        {
            try
            {
                if (stringToStopAt == null || stringToStopAt == string.Empty)
                    return stream;

                int stringLength = stream.Length;
                int findLength = stringToStopAt.Length;

                stringToStopAt = stringToStopAt.ToLower();
                string temp = stream.ToLower();
                int i = temp.IndexOf(stringToStopAt);

                if ((i <= -1) && (stringToStopAt != temp.Substring(0, findLength))
                    || (i == -1))
                    return stream;

                string result = stream.Substring(0, i);
                return result;
            }
            catch (Exception ex)
            {
                //ErrorTool.ProcessError(ex);
                return null;
            }
        }

        /// <summary>
        /// Will return the text to the RIGHT of whatever substring you indicate
        /// </summary>
        /// <param name="stream">
        /// string from which to cull a portion of text
        /// </param>
        /// <param name="stringToStartAfter">
        /// string that indicates what char or string to start after
        /// </param>
        /// <returns>
        /// The string to the right of point x (stringToStartAfter)
        /// </returns>
        private string RightOf(string stream, string stringToStartAfter)
        {
            try
            {
                if (stringToStartAfter == null || stringToStartAfter == string.Empty)
                    return stream;
                stringToStartAfter = stringToStartAfter.ToLower();
                string temp = stream.ToLower();
                int findLength = stringToStartAfter.Length;
                int i = temp.IndexOf(stringToStartAfter);
                if ((i <= -1) && (stringToStartAfter != temp.Substring(0, findLength))
                    || (i == -1))
                    return stream;

                string result =
                    stream.Substring(i + findLength, stream.Length - (i + findLength));
                return result;
            }
            catch (Exception ex)
            {
                //ErrorTool.ProcessError(ex);
                return null;
            }
        }

        private void bAgregarPropiedad_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxEmailTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                return;
        } 





    }
}