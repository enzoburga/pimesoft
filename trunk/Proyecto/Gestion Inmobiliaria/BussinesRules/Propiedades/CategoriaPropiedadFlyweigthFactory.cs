using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace GI.BR.Propiedades
{
    public class CategoriaPropiedadFlyweigthFactory
    {
        private Hashtable hashCategoria;
        private CategoriasPropiedad categoriasCollection;

        private CategoriaPropiedadFlyweigthFactory()
        {

            hashCategoria = new Hashtable();
            categoriasCollection = new CategoriasPropiedad();
            categoriasCollection.RecuperarTodas();
            foreach (CategoriaPropiedad cate in categoriasCollection)
            {
                hashCategoria.Add(cate.IdCategoria, cate);
            }
        }


        public CategoriaPropiedad GetCategoria(int IdCategoria)
        {
            return (CategoriaPropiedad)hashCategoria[IdCategoria];
        }

        public CategoriasPropiedad GetCategorias
        {
            get 
            {
                return categoriasCollection;
            }
        }

        private static CategoriaPropiedadFlyweigthFactory instancia;
        public static CategoriaPropiedadFlyweigthFactory GetInstancia
        {
            get
            {
                if (instancia == null)
                    instancia = new CategoriaPropiedadFlyweigthFactory();
                return instancia;
            }
        }

    }
}
