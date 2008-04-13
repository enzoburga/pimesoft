using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Monedas
{
    public class Moneda
    {
        private int idMoneda;

        public int IdMoneda
        {
            get { return idMoneda; }
            set { idMoneda = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string simbolo;

        public string Simbolo
        {
            get { return simbolo; }
            set { simbolo = value; }
        }

        public override string ToString()
        {
            return Simbolo.ToString();
        }

    }
}
