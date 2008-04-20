using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Managers.Propiedades
{
    public class MngPropiedades
    {



        public GI.BR.Propiedades.Propiedades RecuperarPropiedades(Type Type, GI.BR.Propiedades.TipoPropiedad Tipo,
                    GI.BR.Propiedades.EstadoPropiedad Estado,
                    GI.BR.Propiedades.Ubicacion Ubicacion)
        {


            GI.BR.Propiedades.Propiedades propiedades = new GI.BR.Propiedades.Propiedades();
            propiedades.RecuperarPropiedadesVentasTodas();

            return propiedades;

        
        }


        







    }
}
