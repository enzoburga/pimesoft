using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace GI.BR.Propiedades
{
    public class TiposPropiedadFlyweightFactory
    {

        private Hashtable tiposPropiedad;

        private TiposPropiedadFlyweightFactory()
        {

            tiposPropiedad = new Hashtable();
            TiposPropiedad tipos = new TiposPropiedad();
            tipos.RecuperarTodos();
            foreach (TipoPropiedad tipo in tipos)
            {
                tiposPropiedad.Add(tipo.IdTipoPropiedad, tipo);
            }
        }



        public TipoPropiedad GetTipoPropiedad(int IdTipoPropiedad)
        {
            return (TipoPropiedad)tiposPropiedad[IdTipoPropiedad];
        }

        private static TiposPropiedadFlyweightFactory instancia;
        public static TiposPropiedadFlyweightFactory GetInstancia
        {
            get
            {
                if (instancia == null)
                    instancia = new TiposPropiedadFlyweightFactory();
                return instancia;
            }
        }


    }
}
