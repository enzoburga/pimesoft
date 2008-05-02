using System;

namespace SendaPortal.BussinesRules.Transporte
{
	
	public class MngTransporte
	{
		public MngTransporte()
		{
			
		}



		public void EnviarNotificacionDatosUsuario(Usuario Usr, string Password)
		{
			NotificacionEmail noti = new NotificacionEmail();
			noti.NotificarRecuperacionContrasenia(Usr, Password);

		}



        public void EnviarConfirmacionEMailUsuario(ConfirmacionEMail confirmacion)
        {
            NotificacionEmail noti = new NotificacionEmail();
            noti.NotificarCambioEMail(confirmacion);
        }
    }
}
