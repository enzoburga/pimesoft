using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Managers.Ubicaciones
{
    public class MngUbicaciones
    {
        public List<GI.BR.Propiedades.Ubicacion> GetUbicaciones(GI.BR.Propiedades.Ubicaciones.Barrios barrios, GI.BR.Propiedades.Ubicaciones.Localidad localidad, GI.BR.Propiedades.Ubicaciones.Provincia provincia,GI.BR.Propiedades.Ubicaciones.Pais pais)
        {
            System.Collections.Generic.List<GI.BR.Propiedades.Ubicacion> ubicaciones = new System.Collections.Generic.List<GI.BR.Propiedades.Ubicacion>();

            if (barrios.Count == 0)
                ubicaciones.Add(GetUbicacion(null, localidad, provincia, pais));
            else
            {
                foreach (GI.BR.Propiedades.Ubicaciones.Barrio b in barrios)
                {
                    ubicaciones.Add(GetUbicacion(b, localidad, provincia, pais));
                }
            }

            return ubicaciones;
        }

        private GI.BR.Propiedades.Ubicacion GetUbicacion(GI.BR.Propiedades.Ubicaciones.Barrio barrio, GI.BR.Propiedades.Ubicaciones.Localidad loc, GI.BR.Propiedades.Ubicaciones.Provincia prov, GI.BR.Propiedades.Ubicaciones.Pais pais)
        {
            GI.BR.Propiedades.Ubicacion u = new GI.BR.Propiedades.Ubicacion();

            u.Pais = pais;
            u.Localidad = loc;
            u.Provincia = prov;
            u.Barrio = barrio;

            return u;
        }
    }
}
