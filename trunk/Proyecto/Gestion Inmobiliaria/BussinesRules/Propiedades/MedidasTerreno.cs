using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class MedidasTerreno
    {

        private decimal metros;
        private decimal fondo;
        private decimal frente;

        protected decimal Metros
        {
            get { return metros; }
            set { metros = value; }
        }
        

        protected decimal Fondo
        {
            get { return fondo; }
            set { fondo = value; }
        }
        

        protected decimal Frente
        {
            get { return frente; }
            set { frente = value; }
        }

    }
}
