using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class Direccion
    {

        private string calle;
        private int numero;
        private string depto;
        private string piso;
        private string codigoPostal;
        private string calleEntre1;
        private string calleEntre2;

        public string CalleEntre1
        {
            get { return calleEntre1; }
            set { calleEntre1 = value; }
        }
        

        public string CalleEntre2
        {
            get { return calleEntre2; }
            set { calleEntre2 = value; }
        }

        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }
        

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        

        public string Depto
        {
            get { return depto; }
            set { depto = value; }
        }
        

        public string Piso
        {
            get { return piso; }
            set { piso = value; }
        }
        

        public string CodigoPostal
        {
            get { return codigoPostal; }
            set { codigoPostal = value; }
        }
    }
}
