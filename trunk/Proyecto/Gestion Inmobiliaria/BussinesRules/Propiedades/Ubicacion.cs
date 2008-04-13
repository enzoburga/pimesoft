using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class Ubicacion
    {

        public Ubicacion()
        { }

        private Ubicaciones.Pais pais;

        public Ubicaciones.Pais Pais
        {
            get { return pais; }
            set { pais = value; }
        }
        private Ubicaciones.Provincia provincia;

        public Ubicaciones.Provincia Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }
        private Ubicaciones.Localidad localidad;

        public Ubicaciones.Localidad Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }
        private Ubicaciones.Barrio barrio;

        public Ubicaciones.Barrio Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }



    }
}
