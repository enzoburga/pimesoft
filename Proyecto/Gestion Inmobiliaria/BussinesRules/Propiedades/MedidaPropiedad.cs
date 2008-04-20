using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class MedidaPropiedad
    {

        private decimal metrosCubiertos;
        private decimal metrosSemicubiertos;
        private decimal metrosLibres;

        protected decimal MetrosCubiertos
        {
            get { return metrosCubiertos; }
            set { metrosCubiertos = value; }
        }
        

        protected decimal MetrosSemicubiertos
        {
            get { return metrosSemicubiertos; }
            set { metrosSemicubiertos = value; }
        }
        

        protected decimal MetrosLibres
        {
            get { return metrosLibres; }
            set { metrosLibres = value; }
        }

    }
}
