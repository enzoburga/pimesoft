using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Managers.Seguridad
{
    public class ServicioSeguridad
    {
        #region Singleton


        private static ServicioSeguridad servicio;
        public static ServicioSeguridad GetServicio()
        {
            if (servicio == null)
            {
                servicio = new ServicioSeguridad();
            }

            return servicio;
        }

        #endregion



        private GI.BR.Seguridad.Usuario usuarioActivo;

        public GI.BR.Seguridad.Usuario UsuarioActivo
        {
            get { return usuarioActivo; }
            set { usuarioActivo = value; }
        }





    }




}
