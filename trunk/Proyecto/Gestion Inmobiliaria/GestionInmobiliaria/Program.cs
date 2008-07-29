using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GI.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Seteo si la version es de prueba o comun.
            Framework.Seguridad.MngSeguridadDemo.GetInstancia.VersionDemo = false;

            //Si es de prueba muestro mensaje.
            if (Framework.Seguridad.MngSeguridadDemo.GetInstancia.VersionDemo)
            {
                FrmAvisoDemo frmDemo = new FrmAvisoDemo();
                frmDemo.ShowDialog();
            }

            GI.UI.Seguridad.FrmLogIn frmLogIn = new GI.UI.Seguridad.FrmLogIn();
            if (frmLogIn.ShowDialog() == DialogResult.OK)
            {
                GI.Managers.Seguridad.ServicioSeguridad.GetServicio().UsuarioActivo = frmLogIn.Usuario;
                Application.Run(new GI.UI.frmStartUp());
            }

            
        }
    }
}