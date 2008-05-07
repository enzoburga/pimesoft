using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace GI.Managers.Propiedades
{
    public delegate void EnvioCorreoFinalizado(GI.BR.Propiedades.Propiedad p, string Mensaje, bool Error);



    public class MngEnviarPropiedadesCorreo
    {

        public MngEnviarPropiedadesCorreo(GI.BR.Propiedades.Propiedad Propiedad, string Body, string EmailTo, string Message)
        {
            p = Propiedad;
           
            emailTo = EmailTo;
            message = Message;
            
            body = Body;
        }

        public event EnvioCorreoFinalizado onEnvioFinalizado;

        private string body;
        private GI.BR.Mail.SmtpConfig smtp = GI.BR.Mail.SmtpConfig.GetSmtp();
        private GI.BR.Propiedades.Propiedad p;
        private string emailTo;
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


                MailMessage mail = new MailMessage(smtp.Email,emailTo, "Ficha de Propiedad " + p.Codigo,message);
                mail.IsBodyHtml = true;

                mail.Body = body;
              



                System.Drawing.Bitmap foto = p.GaleriaFotos.GetFotoFachada.Imagen;
                System.IO.MemoryStream stream = new System.IO.MemoryStream();
                foto.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(stream);
                streamWriter.Flush();
                // this is quite important
                stream.Position = 0;

                Attachment attach = new Attachment(stream, "image/jpeg");
                attach.ContentDisposition.FileName = p.Codigo + ".jpg";
                attach.ContentType = new System.Net.Mime.ContentType();
                attach.ContentType.Name = p.Codigo + ".jpg";
                attach.TransferEncoding = System.Net.Mime.TransferEncoding.Base64;
                mail.Attachments.Add(attach);





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
                    onEnvioFinalizado(p, ex.Message, true);
            }

       
        }

        public void smtpClient_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (onEnvioFinalizado == null)
                return;

            String token = (string)e.UserState;

            if (e.Cancelled)
            {
                onEnvioFinalizado(p, "Operación cancelada", false);
            }
            if (e.Error != null)
            {
                onEnvioFinalizado(p, e.Error.ToString(), true);
            }
            else
            {
                onEnvioFinalizado(p, "Mensaje enviado", false);
            }
        }



    }
}
