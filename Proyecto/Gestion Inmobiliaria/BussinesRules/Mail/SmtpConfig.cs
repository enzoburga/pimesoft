using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Mail
{
    public class SmtpConfig
    {



        private SmtpConfig()
        { }

        public static SmtpConfig GetSmtp()
        {
            SmtpConfig smtp = new SmtpConfig();
            smtp.AutenticacionSmtp = true;
            smtp.Email = "edavidis@nalejandria.com";
            smtp.Host = "smtp.nalejandria.com";
            smtp.Nombre = "Emilio Davidis";
            smtp.Password = "0774";
            smtp.Puerto = 25;
            smtp.Ssl = false;
            smtp.UserName = "edavidis@nalejandria.com";

            return smtp;
        }



        private string host;
        private string userName;
        private string password;
        private bool autenticacionSmtp;
        private string nombre;
        private string email;
        private int puerto;
        private bool ssl;



        public int Puerto
        {
            get { return puerto; }
            set { puerto = value; }
        }
        

        public bool Ssl
        {
            get { return ssl; }
            set { ssl = value; }
        }


        public string Host
        {
            get { return host; }
            set { host = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool AutenticacionSmtp
        {
            get { return autenticacionSmtp; }
            set { autenticacionSmtp = value; }
        }

        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }



        public bool Actualizar()
        {
            return false;
        }

    }
}
