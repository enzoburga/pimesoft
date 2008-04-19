using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class MedidasTerreno
    {

        private decimal metros;

        protected decimal Metros
        {
            get { return metros; }
            set { metros = value; }
        }
        private decimal fondo;

        protected decimal Fondo
        {
            get { return fondo; }
            set { fondo = value; }
        }
        private decimal frente;

        protected decimal Frente
        {
            get { return frente; }
            set { frente = value; }
        }

    }
}
