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
            return new SmtpConfig();
        }



        private string userName;
        private string password;
        private bool autenticacionSmtp;
        private string nombre;
        private string email;

        private string host;

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
