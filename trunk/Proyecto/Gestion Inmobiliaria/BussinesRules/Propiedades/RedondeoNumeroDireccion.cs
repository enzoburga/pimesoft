using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    /// <summary>
    /// 
    /// </summary>
    public class RedondeoNumeroDireccion
    {

        /// <summary>
        /// Aproxima el numero de la altura de una direccion
        /// </summary>
        /// <param name="Numero"></param>
        /// <returns></returns>
        public int AproximarNumeroDireccion(int Numero)
        {
            if (Numero == 0) return Numero;
            int num = 0;

            if (Numero < 100)
                return 100;

            if (Numero >= 100 && Numero < 100)
            {
                num = Numero / 100;
                return num * 100;
            }

            if (Numero >= 100 && Numero < 1000)
            {
                num = Numero / 100;
                return num * 100;
            }

            if (Numero >= 1000)
            {
                num = Numero / 100;
                return num * 100;
            }

           



            return Numero;



        
        }



    }
}
