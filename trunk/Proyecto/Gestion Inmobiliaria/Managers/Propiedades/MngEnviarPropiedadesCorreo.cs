using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace GI.Managers.Propiedades
{
    public delegate void EnvioCorreoFinalizado(string Mensaje, bool Error);

    public enum FormatoEnvio
    {
        Pdf, Word

    }

    public class MngEnviarPropiedadesCorreo
    {

        public MngEnviarPropiedadesCorreo(System.Collections.Hashtable hash, FormatoEnvio formatoEnvio, List<string> EmailTo, string Message, GI.BR.Propiedades.Galeria.GaleriaFotos Galeria)
        {
            hashPropiedades = hash;
            formato = formatoEnvio;
            emailTo = EmailTo;
            message = Message;
            galeria = Galeria;
        }

        public event EnvioCorreoFinalizado onEnvioFinalizado;

        private GI.BR.Propiedades.Galeria.GaleriaFotos galeria;
        
        private string body;
        private GI.BR.Mail.SmtpConfig smtp = GI.BR.Mail.SmtpConfig.GetSmtp();
        private System.Collections.Hashtable  hashPropiedades;
        private FormatoEnvio formato;
        private List<string> emailTo;
        private string message;

        private SmtpClient smtpClient;

        public void Cancelar()
        {
            if (smtpClient != null)
                smtpClient.SendAsyncCancel();
        }

        public void EnviarPropiedad()
        {
    

            try
            {

                GI.BR.Inmobiliaria inm = GI.BR.Inmobiliaria.GetInmobiliaria();

                //Si no uso el contructor no agrega bien el sender.
                //Uso la primera dir de To, y la saco, luego agrego las demas.
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(smtp.Email, smtp.Nombre);
                mail.Body = message;
                //mail.Sender = new MailAddress(smtp.Email);
                mail.Subject = "Propiedad ofrecida por " + inm.Nombre;
             

                
                foreach (string s in emailTo)
                {
                    mail.Bcc.Add(s);
                    
                }

                System.IO.Stream streamRpt;
                foreach (string key in hashPropiedades.Keys)
                {
                    streamRpt = (System.IO.Stream)hashPropiedades[key];

                    string name = key;
                    name += formato == FormatoEnvio.Pdf ? ".pdf" : ".doc";
                    Attachment attach = new Attachment(streamRpt, name);
                    attach.ContentType = new System.Net.Mime.ContentType();
                    attach.ContentType.Name = key;

                    attach.TransferEncoding = System.Net.Mime.TransferEncoding.Base64;

                    mail.Attachments.Add(attach);
                }


                
                if (galeria!=null)
                {
                    foreach (GI.BR.Propiedades.Galeria.Foto f in galeria)
                    {
                        mail.Attachments.Add(ArmarAttachsFotos(f));
                    }
                }
                
     
                smtpClient = new SmtpClient(smtp.Host, smtp.Puerto);
                if (smtp.AutenticacionSmtp)
                    smtpClient.Credentials = new System.Net.NetworkCredential(smtp.UserName, smtp.Password);

                smtpClient.EnableSsl = smtp.Ssl;
                smtpClient.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                smtpClient.SendCompleted += new SendCompletedEventHandler(smtpClient_SendCompleted);
                smtpClient.SendAsync(mail, "mensaje 1");


                
            
            }
            catch(Exception ex)
            {
                if (onEnvioFinalizado != null)
                    onEnvioFinalizado(ex.Message, true);
            }

       
        }



        private Attachment ArmarAttachsFotos(GI.BR.Propiedades.Galeria.Foto Foto)
        {
            Attachment a;
            System.IO.MemoryStream ms;

            
            ms = new System.IO.MemoryStream();
          
            Foto.Imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            a = new Attachment(ms, Foto.Descripcion);
            a.ContentType = new System.Net.Mime.ContentType("image/jpeg");
            a.TransferEncoding = System.Net.Mime.TransferEncoding.Base64;

            return a;
        
        
        }


        public void smtpClient_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (onEnvioFinalizado == null)
                return;

            String token = (string)e.UserState;

            if (e.Cancelled)
            {
                onEnvioFinalizado("Operación cancelada", false);
            }
            if (e.Error != null)
            {
                onEnvioFinalizado(e.Error.ToString(), true);
            }
            else
            {
                onEnvioFinalizado("Mensaje enviado", false);
            }
        }



    }
}
