using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace GI.BR.Propiedades
{
    public class TiposPropiedadFlyweightFactory
    {

        private Hashtable tiposPropiedad;
        private TiposPropiedad tiposPropiedadCollection;

        private TiposPropiedadFlyweightFactory()
        {

            tiposPropiedad = new Hashtable();
            tiposPropiedadCollection = new TiposPropiedad();
            tiposPropiedadCollection.RecuperarTodos();
            foreach (TipoPropiedad tipo in tiposPropiedadCollection)
            {
                tiposPropiedad.Add(tipo.IdTipoPropiedad, tipo);
            }
        }



        public TipoPropiedad GetTipoPropiedad(int IdTipoPropiedad)
        {
            return (TipoPropiedad)tiposPropiedad[IdTipoPropiedad];
        }

        public TiposPropiedad GetTipoPropiedadPorCategoria(int idCategoria)
        {
            TiposPropiedad tipos = new TiposPropiedad();
            foreach (int key in tiposPropiedad.Keys)
            {
                if (idCategoria == ((TipoPropiedad)tiposPropiedad[key]).IdCategoria)
                    tipos.Add((TipoPropiedad)tiposPropiedad[key]);
            }
            return tipos;
        }

        public TiposPropiedad GetTiposPropiedad
        {
            get 
            {
                return tiposPropiedadCollection;
            }
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
