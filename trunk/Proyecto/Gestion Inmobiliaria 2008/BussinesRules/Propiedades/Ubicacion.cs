using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    [Serializable]
    public class Ubicacion
    {

        public Ubicacion()
        { }

        private Ubicaciones.Pais pais;
        private Ubicaciones.Provincia provincia;
        private Ubicaciones.Localidad localidad;
        private Ubicaciones.Barrio barrio;

        public Ubicaciones.Pais Pais
        {
            get { return pais; }
            set { pais = value; }
        }
        

        public Ubicaciones.Provincia Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }
        

        public Ubicaciones.Localidad Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }
        

        public Ubicaciones.Barrio Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }



    }
}
