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
            smtp.AutenticacionSmtp = false;
            smtp.Email = "info@inmobiliaria.com";
            smtp.Host = "localhost";
            smtp.Nombre = "Info";
            smtp.Password = "";
            smtp.Puerto = 25;
            smtp.Ssl = false;
            smtp.UserName = "";

            using (System.Data.IDataReader dr = new DA.SmtpConfigData().RecuperarConfiguracion())
            {
                if (dr.Read())
                {
                    
                    smtp.UserName = dr.GetString(dr.GetOrdinal("UserName")).Trim();
                    smtp.Ssl = dr.GetBoolean(dr.GetOrdinal("SSL"));
                    smtp.Puerto = dr.GetInt32(dr.GetOrdinal("Puerto"));
                    smtp.Password = dr.GetString(dr.GetOrdinal("Password")).Trim();
                    smtp.Nombre = dr.GetString(dr.GetOrdinal("Nombre")).Trim();
                    smtp.Host = dr.GetString(dr.GetOrdinal("Host")).Trim();
                    smtp.Email = dr.GetString(dr.GetOrdinal("Email")).Trim();
                    smtp.AutenticacionSmtp = dr.GetBoolean(dr.GetOrdinal("AutenticacionSmtp"));
                    

                
                
                }
            }


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
            return new DA.SmtpConfigData().GuardarConfiduracion(
                AutenticacionSmtp,
                Email,
                Host,
                Nombre,
                Password,
                Puerto,
                Ssl,
                UserName);
        }

    }
}
