using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR
{
    public class Valor : ICloneable
    {


        public Valor() { }


        private Monedas.Moneda moneda;
        private decimal importe;

        public Monedas.Moneda Moneda
        {
            get { return moneda; }
            set { moneda = value; }
        }


        public decimal Importe
        {
            get { return importe; }
            set { importe = value; }
        }

        public override string ToString()
        {
            return importe.ToString() + " " + moneda.ToString();
        }


        #region ICloneable Members

        public object Clone()
        {
            return base.MemberwiseClone();
        }

        #endregion

    }
}
