using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    [Serializable]
    public class MedidasTerreno
    {

        private decimal metros;
        private decimal fondo;
        private decimal frente;

        public decimal Metros
        {
            get { return metros; }
            set { metros = value; }
        }


        public decimal Fondo
        {
            get { return fondo; }
            set { fondo = value; }
        }


        public decimal Frente
        {
            get { return frente; }
            set { frente = value; }
        }

    }
}
