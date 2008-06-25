using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    [Serializable]
    public class Direccion
    {


        public Direccion()
        {
            calle = "";
            numero = 0;
            depto = "";
            codigoPostal = "";
            calleEntre1 = "";
            calleEntre2 = "";
            piso = "";
        }

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


        public string ToStringReporte()
        {
            RedondeoNumeroDireccion redondeo = new RedondeoNumeroDireccion();

            string sCalle;
            string sNumero;

            sCalle = calle;
            sNumero = redondeo.AproximarNumeroDireccion(Numero).ToString();

            if (sCalle == "")
                sCalle = "Sin Calle";
            if (sNumero == "0")
                sNumero = "Sin Número";

            return sCalle + " - " + sNumero;

        }

        public override string ToString()
        {
            string sCalle;
            string sNumero;

            sCalle = calle;
            sNumero = numero.ToString();

            if (sCalle == "")
                sCalle = "Sin Calle";
            if (sNumero == "0")
                sNumero = "Sin Número";

            string dir = sCalle + " - " + sNumero;

            if (Piso != "")
                dir += " " + Piso;


            if (depto != "")
                dir += " " + depto;


            return dir;
        }
    }
}
