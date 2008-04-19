using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class MedidaPropiedad
    {

        private decimal metrosCubiertos;

        protected decimal MetrosCubiertos
        {
            get { return metrosCubiertos; }
            set { metrosCubiertos = value; }
        }
        private decimal metrosSemicubiertos;

        protected decimal MetrosSemicubiertos
        {
            get { return metrosSemicubiertos; }
            set { metrosSemicubiertos = value; }
        }
        private decimal metrosLibres;

        protected decimal MetrosLibres
        {
            get { return metrosLibres; }
            set { metrosLibres = value; }
        }

    }
}
