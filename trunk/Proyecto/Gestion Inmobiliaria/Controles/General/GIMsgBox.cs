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
        public static void ShowSoloLectura()
        { 
            System.Windows.Forms.MessageBox.Show("No se puede realizar esta acción. La ficha esta en modo solo lectura.", "¡Advertencia!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation); break;            
        }

        public static void ShowCancelarPerdidaDatos()
        {
            System.Windows.Forms.MessageBox.Show("Si cancela en este momento se perderán los datos no guardados, ¿Desea guardar los datos?", "Pregunta", System.Windows.Forms.MessageBoxButtons.YesNoCancel, System.Windows.Forms.MessageBoxIcon.Question); break;
        }

    }
}
