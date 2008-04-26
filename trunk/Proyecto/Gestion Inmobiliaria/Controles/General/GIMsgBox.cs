using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Framework.General
{
    public class GIMsgBox
    {
        public static System.Windows.Forms.DialogResult Show(string mensaje, enumTipoMensaje tipoMsg)
        {
            switch (tipoMsg)
            { 
                case enumTipoMensaje.Advertencia:
                    return System.Windows.Forms.MessageBox.Show(mensaje, "�Advertencia!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation); break;
                case enumTipoMensaje.Error:
                    return System.Windows.Forms.MessageBox.Show(mensaje, "�Error!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error); break;
                case enumTipoMensaje.Informacion:
                    System.Windows.Forms.MessageBox.Show(mensaje, "Informaci�n", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information); break;
                case enumTipoMensaje.Pregunta:
                    return System.Windows.Forms.MessageBox.Show(mensaje, "Preguna", System.Windows.Forms.MessageBoxButtons.YesNoCancel, System.Windows.Forms.MessageBoxIcon.Question); break;
                default: return System.Windows.Forms.DialogResult.Abort;
            }
            return System.Windows.Forms.DialogResult.Abort;
        }
        public static void ShowSoloLectura()
        { 
            System.Windows.Forms.MessageBox.Show("No se puede realizar esta acci�n. La ficha esta en modo solo lectura.", "�Advertencia!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);            
        }

        public static System.Windows.Forms.DialogResult ShowCancelarPerdidaDatos()
        {
            return System.Windows.Forms.MessageBox.Show("�Desea guardar los cambios realizados?", "Pregunta", System.Windows.Forms.MessageBoxButtons.YesNoCancel, System.Windows.Forms.MessageBoxIcon.Question);
        }

    }
}
