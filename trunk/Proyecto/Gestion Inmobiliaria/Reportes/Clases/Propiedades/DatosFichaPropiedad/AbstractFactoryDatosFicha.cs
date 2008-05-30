using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Reportes.Clases.Propiedades
{
    internal class AbstractFactoryDatosFicha
    {


        internal DatosFichaPropiedad GetDatosFichaPropiedad(GI.BR.Propiedades.TipoPropiedad Tipo)
        {
            DatosFichaPropiedad datos = null;

            switch (Tipo.IdTipoPropiedad)
            {
                case 1: datos = new DatosFichaPropiedadDeptos(); break;

                case 2:
                case 3:
                case 4:
                case 5:
                case 6: datos = new DatosFichaPropiedadGenerico(); break;

                case 7:
                case 8:
                case 9:
                case 10: datos = new DatosFichaPropiedadGenerico(); break;


                default: datos = new DatosFichaPropiedadGenerico(); break;

            }

            return datos;
        
        }



    }
}
