using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class CategoriasPropiedad : List<CategoriaPropiedad>
    {



        public void RecuperarTodas()
        {
            Clear();

            CategoriaPropiedad categoria = new CategoriaPropiedad();
            TipoPropiedad tipo = new TipoPropiedad();

            categoria = new CategoriaPropiedad();
            categoria.IdCategoria = 1;
            categoria.Nombre = "Vivienda";
            categoria.TiposPropiedad = new TiposPropiedad();
            tipo = new TipoPropiedad();
            //departamento, PH frente, PH interno, PH fondo, PH planta baja, PH planta alta, casa, chalet, duplex, triplex, terreno, quinta
            tipo.Descripcion = "Casa";
            tipo.IdTipoPropiedad = 1;
            tipo.IdCategoria = categoria.IdCategoria;
            categoria.TiposPropiedad.Add(tipo);
            tipo.Descripcion = "Casa";
            tipo.IdTipoPropiedad = 2;
            tipo.IdCategoria = categoria.IdCategoria;
            categoria.TiposPropiedad.Add(tipo);
            tipo.Descripcion = "Casa";
            tipo.IdTipoPropiedad = 3;
            tipo.IdCategoria = categoria.IdCategoria;
            categoria.TiposPropiedad.Add(tipo);
            tipo.Descripcion = "Casa";
            tipo.IdTipoPropiedad = 4;
            tipo.IdCategoria = categoria.IdCategoria;
            categoria.TiposPropiedad.Add(tipo);
            tipo.Descripcion = "Casa";
            tipo.IdTipoPropiedad = 5;
            tipo.IdCategoria = categoria.IdCategoria;
            categoria.TiposPropiedad.Add(tipo);
            tipo.Descripcion = "Casa";
            tipo.IdTipoPropiedad = 1;
            tipo.IdCategoria = categoria.IdCategoria;
            categoria.TiposPropiedad.Add(tipo);
            tipo.Descripcion = "Casa";
            tipo.IdTipoPropiedad = 1;
            tipo.IdCategoria = categoria.IdCategoria;
            categoria.TiposPropiedad.Add(tipo);
            tipo.Descripcion = "Casa";
            tipo.IdTipoPropiedad = 1;
            tipo.IdCategoria = categoria.IdCategoria;
            categoria.TiposPropiedad.Add(tipo);
            tipo.Descripcion = "Casa";
            tipo.IdTipoPropiedad = 1;
            tipo.IdCategoria = categoria.IdCategoria;
            categoria.TiposPropiedad.Add(tipo);
            tipo.Descripcion = "Casa";
            tipo.IdTipoPropiedad = 1;
            tipo.IdCategoria = categoria.IdCategoria;
            categoria.TiposPropiedad.Add(tipo);
            tipo.Descripcion = "Casa";
            tipo.IdTipoPropiedad = 1;
            tipo.IdCategoria = categoria.IdCategoria;
            categoria.TiposPropiedad.Add(tipo);

            Add(categoria);

        }
    }
}
