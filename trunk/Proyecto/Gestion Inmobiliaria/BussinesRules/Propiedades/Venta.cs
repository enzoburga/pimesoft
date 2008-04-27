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
    }
}
