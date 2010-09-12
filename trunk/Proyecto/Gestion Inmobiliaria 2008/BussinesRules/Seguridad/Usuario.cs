using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Seguridad
{
    public class Usuario
    {

        private Usuario() { }

        private Usuario(int IdUsuario, string UserName, string Passwd)
            : this()
        {
            this.UserName = UserName;
            this.Password = Password;
            this.IdUsuario = IdUsuario;
        }

        public static Usuario GetUsuario(string UserName, string Password)
        {
            Usuario usr = new Usuario(1, UserName, Password);
            return usr;
            
        }



        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }




    }
}
