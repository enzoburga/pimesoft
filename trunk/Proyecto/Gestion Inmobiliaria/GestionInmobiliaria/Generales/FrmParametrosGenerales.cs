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

            BR.Reportes.ParametrosReportes reps = new GI.BR.Reportes.ParametrosReportes();
            reps.Recuperar();
            pictureBox1.Image = reps.Encabezado;
            pictureBox2.Image = reps.PiePagina;

        
        
        
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


            BR.Reportes.ParametrosReportes reps = new GI.BR.Reportes.ParametrosReportes();
            if (pictureBox1.Image != null)
            {
                reps.Encabezado = new Bitmap( pictureBox1.Image);
            }
            if (pictureBox2.Image != null)
            {
                reps.PiePagina = new Bitmap(pictureBox2.Image);
            }
            reps.Guardar();





            Close();
        }

        private void linkLabelSelectEncabezado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new System.Drawing.Bitmap(openFileDialog1.FileName);
            }
        }

        private void linkLabelSelectPie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new System.Drawing.Bitmap(openFileDialog1.FileName);
            }
        }


    }
}