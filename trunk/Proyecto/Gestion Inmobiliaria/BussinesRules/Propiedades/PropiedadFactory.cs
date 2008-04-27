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
    }
}
