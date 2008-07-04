using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Generales
{
    public partial class FrmParametrosGenerales : Form
    {
        public FrmParametrosGenerales()
        {
            InitializeComponent();

            Inicializar();
        }

        GI.BR.Mail.SmtpConfig smtp = GI.BR.Mail.SmtpConfig.GetSmtp();
        GI.BR.Inmobiliaria Inmobiliaria = GI.BR.Inmobiliaria.GetInmobiliaria();



        private void Inicializar()
        {

            
            textBoxDireccionWeb.Text = Inmobiliaria.Url;
            textBoxFax.Text = Inmobiliaria.Fax;
            textBoxNombreInmobiliaria.Text = Inmobiliaria.Nombre;
            textBoxTelefono.Text = Inmobiliaria.Telefono;
            ctrlDireccion1.Direccion = Inmobiliaria.Direccion;

            textBoxMail.Text = smtp.Email;
            textBoxNombre.Text = smtp.Nombre;
            textBoxPassword.Text = smtp.Password;
            textBoxPort.Text = smtp.Puerto.ToString();
            textBoxSmtpHost.Text = smtp.Host;
            textBoxUsuario.Text = smtp.UserName;

            checkBoxAutenticacion.Checked = smtp.AutenticacionSmtp;
            checkBoxSSL.Checked = smtp.Ssl;
        
        
        
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            int port = 0;
            if (!Int32.TryParse(textBoxPort.Text, out port))
            {
                Framework.General.GIMsgBox.Show("Debe ingresar un valor válido para el perto", GI.Framework.General.enumTipoMensaje.Error);
                return;
            }



            Inmobiliaria.Direccion = ctrlDireccion1.Direccion;
            Inmobiliaria.Fax = textBoxFax.Text;
            Inmobiliaria.Nombre = textBoxNombreInmobiliaria.Text;
            Inmobiliaria.Telefono = textBoxTelefono.Text;
            Inmobiliaria.Url = textBoxDireccionWeb.Text;

            Inmobiliaria.Actualizar();

            smtp.AutenticacionSmtp = checkBoxAutenticacion.Checked;
            smtp.Email = textBoxMail.Text;
            smtp.Host = textBoxSmtpHost.Text;
            smtp.Nombre = textBoxNombre.Text;
            smtp.Password = textBoxPassword.Text;
            smtp.Puerto = port;
            smtp.Ssl = checkBoxSSL.Checked;
            smtp.UserName = textBoxUsuario.Text;

            smtp.Actualizar();



            Close();
        }


    }
}