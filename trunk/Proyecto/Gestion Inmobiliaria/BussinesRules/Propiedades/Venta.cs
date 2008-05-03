using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class Venta : Propiedad
    {



        public override bool Guardar()
        {

            if (!base.Guardar())
                return false;

            return new DA.PropiedadesData().InsertarPropiedadesEnVenta(base.IdPropiedad);



        }

        public override EstadoPropiedad Estado
        {
            get
            {
                return EstadoPropiedadFlyweigthFactory.GetInstancia(typeof(Venta)).GetEstado(base.Estado.IdEstadoPropiedad);
            }
            set
            {
                base.Estado = value;
            }
        }
        
    }
}
