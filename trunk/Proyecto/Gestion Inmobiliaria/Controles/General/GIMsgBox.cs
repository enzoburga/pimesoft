using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Framework.General
{
    public class GIMsgBox
    {
        public static void Show(string mensaje, enumTipoMensaje tipoMsg)
        {
            switch (tipoMsg)
            { 
                case enumTipoMensaje.Advertencia:
                    System.Windows.Forms.MessageBox.Show(mensaje, "¡Advertencia!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation); break;
                case enumTipoMensaje.Error:
                    System.Windows.Forms.MessageBox.Show(mensaje, "¡Error!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error); break;
                case enumTipoMensaje.Informacion:
                    System.Windows.Forms.MessageBox.Show(mensaje, "Información", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information); break;
                case enumTipoMensaje.Pregunta:
                    System.Windows.Forms.MessageBox.Show(mensaje, "Preguna", System.Windows.Forms.MessageBoxButtons.YesNoCancel, System.Windows.Forms.MessageBoxIcon.Question); break;


            }
        }
    }
}
