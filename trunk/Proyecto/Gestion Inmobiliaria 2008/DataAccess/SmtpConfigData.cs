using System;
using System.Collections.Generic;
using System.Text;

namespace GI.DA
{
    public class SmtpConfigData
    {


        public System.Data.IDataReader RecuperarConfiguracion()
        {
            return AccesoDatos.RecuperarDatos("SMTP_RecuperarConfiguracion", new object[] { }, new string[] { });
        }

        public bool GuardarConfiduracion(bool AutSmtp, string Email, string Host, string Nombre, string Password, int Puerto, bool SSL, string UserName)
        {

            return AccesoDatos.ActualizarRegistro(
                "SMTP_GuardarParametros",
                new object[] { AutSmtp, Email, Host, Nombre, Password, Puerto, SSL, UserName },
                new string[] { "@AutenticacionSmtp", "@Email", "@Host", "@Nombre", "@Password", "@Puerto", "@SSL", "@UserName" });
        }
    }
}
