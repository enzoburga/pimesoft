using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Monedas
{
    public class MonedasFlyweigthFactory
    {

        private System.Collections.Hashtable hashMonedas;

        public MonedasFlyweigthFactory()
        {
            Monedas monedas = new Monedas();
            hashMonedas = new System.Collections.Hashtable();

            foreach (Moneda m in monedas)
                hashMonedas.Add(m.IdMoneda, m);
        }


        public Moneda GetMoneda(int IdMoneda)
        {
            return (Moneda)hashMonedas[IdMoneda];
        }

    }
}
