using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Monedas
{
    public class Monedas : List<Moneda>
    {
        public void RecuperarTodas()
        {
            Moneda m;

            m = new Moneda();
            m.IdMoneda = 1;
            m.Nombre = "Pesos";
            m.Simbolo = "$";
            Add(m);

            m = new Moneda();
            m.IdMoneda = 2;
            m.Nombre = "Dolares";
            m.Simbolo = "USD";
            Add(m);

            m = new Moneda();
            m.IdMoneda = 3;
            m.Nombre = "Euros";
            m.Simbolo = "£";
            Add(m);

        
        }


    }
}
