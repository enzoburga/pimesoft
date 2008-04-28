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
                    return System.Windows.Forms.MessageBox.Show(mensaje, "¡Advertencia!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation); 
                case enumTipoMensaje.Error:
                    return System.Windows.Forms.MessageBox.Show(mensaje, "¡Error!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error); 
                case enumTipoMensaje.Informacion:
                    return System.Windows.Forms.MessageBox.Show(mensaje, "Información", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information); 
                case enumTipoMensaje.Pregunta:
                    return System.Windows.Forms.MessageBox.Show(mensaje, "Preguna", System.Windows.Forms.MessageBoxButtons.YesNoCancel, System.Windows.Forms.MessageBoxIcon.Question); 
                default: return System.Windows.Forms.DialogResult.Abort;
            }
        }
        public static void ShowSoloLectura()
        { 
            System.Windows.Forms.MessageBox.Show("No se puede realizar esta acción. La ficha esta en modo solo lectura.", "¡Advertencia!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);            
        }

        public static System.Windows.Forms.DialogResult ShowCancelarPerdidaDatos()
        {
            return System.Windows.Forms.MessageBox.Show("¿Desea guardar los cambios realizados?", "Pregunta", System.Windows.Forms.MessageBoxButtons.YesNoCancel, System.Windows.Forms.MessageBoxIcon.Question);
        }

        public static System.Windows.Forms.DialogResult ShowNoSeEncontraronDatos()
        {
            return System.Windows.Forms.MessageBox.Show("No se han encontrado resultados coincidentes con el criterio.", "¡Advertencia!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);            
        }
    }
}
