using System;
using System.Configuration;

namespace SendaPortal.BussinesRules.Transporte
{
	/// <summary>
	/// Descripción BussinesRuleseve de NotificacionEmail.
	/// </summary>
	public class NotificacionEmail
	{
		public NotificacionEmail()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

        private string mailFrom = System.Configuration.ConfigurationManager.AppSettings["MailAdmin"];
        private string smtp = System.Configuration.ConfigurationManager.AppSettings["Smtp"];
        private string smtpUserName = System.Configuration.ConfigurationManager.AppSettings["SmtpUserName"];
        private string smtpPassword = System.Configuration.ConfigurationManager.AppSettings["SmtpPwd"];
        
        //private string mailFrom = "sendaportal@educaria.com";//ConfigurationSettings.AppSettings["MailAdmin"];
        //private string smtp = "smtp.educaria.com";//ConfigurationSettings.AppSettings["Smtp"];
        //private string smtpUserName = "sendaportal@educaria.com";//ConfigurationSettings.AppSettings["SmtpUserName"];
        //private string smtpPassword = "senda.portalchile";//ConfigurationSettings.AppSettings["SmtpPwd"];


		
		public void NotificarRecuperacionContrasenia(Usuario Usr, string Password)
		{
			try
			{

                System.Net.Mail.MailMessage mm = new System.Net.Mail.MailMessage();
				mm.From = new System.Net.Mail.MailAddress(mailFrom);
				mm.To.Add(Usr.Email);
				mm.Subject = "CAMBIO DE CONTRASEÑA DE SENDA PORTAL";
                mm.Body = Usr.Nombres+" "+Usr.ApellidoMaterno+" "+Usr.ApellidoPaterno + ",\r La contraseña de acceso a Senda Portal se generó con éxito. \r\rUsuario: " + Usr.Rut + " \r Contraseña: " + Password;

				
				mm.IsBodyHtml = true;
				mm.BodyEncoding = System.Text.Encoding.Default;

                System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient(smtp, 25);

                smtpClient.Credentials = new System.Net.NetworkCredential(smtpUserName,smtpPassword);

                smtpClient.EnableSsl = false;
                smtpClient.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                smtpClient.Send(mm);
			}
			catch(Exception ex)
			{
				throw new Exception(ex.InnerException.Message,ex);

			}
			

		}


        internal void NotificarCambioEMail(SendaPortal.BussinesRules.ConfirmacionEMail confirmacion)
        {
            try
            {
                string dominioPrincipal = System.Configuration.ConfigurationManager.AppSettings["DominioPrincipal"];
                System.Net.Mail.MailMessage mm = new System.Net.Mail.MailMessage();
                mm.From = new System.Net.Mail.MailAddress(mailFrom);
                mm.To.Add(confirmacion.Email);
                mm.Subject = "CONFIRMACIÓN DE CAMBIO DE EMAIL DE SENDA PORTAL";
                mm.Body = @"<html><body><span style=""font-size: 10pt; font-family: Verdana"">" + confirmacion.Usuario.Nombres + "<br /><br /> Usted ha solicitado el cambio de su dirección de correo electrónico de Senda Portal. Para confirmar el cambio debe hacer click en el siguiente link:<br /><br /></span><a href=\"http://" + dominioPrincipal + "/MiSendaPortal/ConfirmacionCambioEMail.aspx?Hash=" + confirmacion.Hash + " \"><span style=\"font-size: 10pt; font-family: Verdana\">Confirmar cambio de E-Mail</span></a><span style=\"font-size: 10pt; font-family: Verdana\"></span></body></html>";


                mm.IsBodyHtml = true;
                mm.BodyEncoding = System.Text.Encoding.Default;

                System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient(smtp, 25);

                smtpClient.Credentials = new System.Net.NetworkCredential(smtpUserName, smtpPassword);

                smtpClient.EnableSsl = false;
                smtpClient.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                smtpClient.Send(mm);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message, ex);

            }
        }
    }
}
