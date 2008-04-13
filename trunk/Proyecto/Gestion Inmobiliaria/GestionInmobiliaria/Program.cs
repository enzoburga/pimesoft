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

            GI.UI.Seguridad.FrmLogIn frmLogIn = new GI.UI.Seguridad.FrmLogIn();
            if (frmLogIn.ShowDialog() == DialogResult.OK)
            {
                GI.Managers.Seguridad.ServicioSeguridad.GetServicio().UsuarioActivo = frmLogIn.Usuario;
                Application.Run(new GI.UI.frmStartUp());
            }

            
        }
    }
}