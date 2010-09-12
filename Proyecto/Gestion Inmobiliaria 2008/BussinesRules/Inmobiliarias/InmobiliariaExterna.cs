using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR
{
    public class InmobiliariaExterna : Inmobiliaria
    {

        public InmobiliariaExterna()
        { 
            
        }




        public bool Crear()
        {
            IdInmobiliaria = new DA.InmobiliariasData().CrearInmobiliariaExterna(
                Nombre,
                Telefono,
                PersonaResponsable);

            return IdInmobiliaria > 0;
        }

        public override bool Actualizar()
        {
            return new DA.InmobiliariasData().ActualizarInmobiliariaExterna(IdInmobiliaria, Nombre, Telefono, PersonaResponsable);

        }
    }
}
