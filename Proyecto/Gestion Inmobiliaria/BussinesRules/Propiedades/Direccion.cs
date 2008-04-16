using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class Direccion
    {

        private string calle;

        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private string depto;

        public string Depto
        {
            get { return depto; }
            set { depto = value; }
        }
        private string piso;

        public string Piso
        {
            get { return piso; }
            set { piso = value; }
        }
        private string codigoPostal;

        public string CodigoPostal
        {
            get { return codigoPostal; }
            set { codigoPostal = value; }
        }
    }
}
