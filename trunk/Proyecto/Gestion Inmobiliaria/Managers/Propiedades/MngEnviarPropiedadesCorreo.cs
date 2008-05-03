using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Managers.Propiedades
{
    public delegate void EnvioCorreoFinalizado(GI.BR.Propiedades.Propiedad p, string Mensaje, bool Error);

    public class MngEnviarPropiedadesCorreo
    {

        public event EnvioCorreoFinalizado onEnvioFinalizado;


        public void EnviarPropiedad(GI.BR.Propiedades.Propiedad Propiedad, System.IO.Stream StreamRpt)
        {


            try
            { 
                // Envia el correo
                


            
            }
            catch(Exception ex)
            {
                if (onEnvioFinalizado != null)
                    onEnvioFinalizado(Propiedad, ex.Message, true);
            }

       
        }



    }
}
