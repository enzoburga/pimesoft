using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class Alquiler : Propiedad
    {



        public override bool Guardar()
        {
            if (!base.Guardar())
                return false;

            return new DA.PropiedadesData().InsertarPropiedadesEnAlquiler(base.IdPropiedad);


        }

        public override EstadoPropiedad Estado
        {
            get
            {
                return EstadoPropiedadFlyweigthFactory.GetInstancia(typeof(Alquiler)).GetEstado(base.Estado.IdEstadoPropiedad);
            }
            set
            {
                base.Estado = value;
            }
        }
    }
}
