using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Monedas
{
    public class MonedasFlyweigthFactory
    {

        private System.Collections.Hashtable hashMonedas;
        Monedas monedas;
        private MonedasFlyweigthFactory()
        {
            monedas = new Monedas();
            hashMonedas = new System.Collections.Hashtable();
            monedas.RecuperarTodas();
            foreach (Moneda m in monedas)
                hashMonedas.Add(m.IdMoneda, m);
        }


        public Moneda GetMoneda(int IdMoneda)
        {
            return (Moneda)hashMonedas[IdMoneda];
        }

        public Monedas GetMonedas
        {
            get
            {
                return monedas;
            }
        }

        private static MonedasFlyweigthFactory instancia;
        public static MonedasFlyweigthFactory GetInstancia
        {
            get
            {
                if (instancia == null)
                    instancia = new MonedasFlyweigthFactory();
                return instancia;
            }
        }

    }
}
