using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GI.BR.Propiedades
{
    public class TiposPropiedad : List<TipoPropiedad>
    {


        public void RecuperarTodos()
        {
            Clear();
            TipoPropiedad tipo;
            using (IDataReader dr = new GI.DA.CategoriasPropiedadData().RecuperarTiposDePropiedad())
            {
                while (dr.Read())
                {
                    tipo = new TipoPropiedad();
                    tipo.Descripcion = dr.GetString(dr.GetOrdinal("Nombre"));
                    tipo.IdCategoria = dr.GetInt32(dr.GetOrdinal("IdCategoria"));
                    tipo.IdTipoPropiedad = dr.GetInt32(dr.GetOrdinal("IdTipoPropiedad"));
                    Add(tipo);
                }
            }
        }

        public void RecuperarPorCategoria(CategoriaPropiedad Categoria)
        {
            Clear();
            TipoPropiedad tipo;
            using (IDataReader dr = new GI.DA.CategoriasPropiedadData().RecuperarTiposDePropiedad(Categoria.IdCategoria))
            {
                while (dr.Read())
                {
                    tipo = new TipoPropiedad();
                    tipo.Descripcion = dr.GetString(dr.GetOrdinal("Nombre"));
                    tipo.IdCategoria = Categoria.IdCategoria;
                    tipo.IdTipoPropiedad = dr.GetInt32(dr.GetOrdinal("IdTipoPropiedad"));
                    Add(tipo);
                }
            }
        }
    }
}
