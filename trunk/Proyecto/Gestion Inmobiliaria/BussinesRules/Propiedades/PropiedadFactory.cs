using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class PropiedadFactory
    {


        public Propiedad CrearClasePropiedad(Type Tipo)
        {
            if (Tipo.ToString() == "GI.BR.Propiedades.Venta")
                return new Venta();

            else if (Tipo.ToString() == "GI.BR.Propiedades.Alquiler")
                return new Alquiler();

            return null;
        }

        public Propiedad GetPropiedad(int idPropiedad)
        {
            Propiedad propiedad = new Alquiler();
            propiedad.RecuperarPorId(idPropiedad);
            if (propiedad.IdPropiedad == 0)
            {
                propiedad = new Venta();
                propiedad.RecuperarPorId(idPropiedad);
                if (propiedad.IdPropiedad == 0)
                    return null;
            }

            return propiedad;
        }
    }
}
