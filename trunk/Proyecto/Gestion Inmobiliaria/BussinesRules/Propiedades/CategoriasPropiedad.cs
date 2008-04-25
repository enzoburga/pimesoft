using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GI.BR.Propiedades
{
    public class CategoriasPropiedad : List<CategoriaPropiedad>
    {

        public CategoriaPropiedad GetByIdCategoria(int IdCategoria)
        {
            foreach (CategoriaPropiedad categoria in this)
            {
                if (categoria.IdCategoria == IdCategoria)
                    return categoria;
            }

            return null;
        }

        public void RecuperarTodas()
        {
            Clear();
            CategoriaPropiedad categoria;
            using (IDataReader dr = new DA.CategoriasPropiedadData().RecuperarCategoriasPropiedad())
            {
                while (dr.Read())
                {
                    categoria = new CategoriaPropiedad();
                    categoria.IdCategoria = dr.GetInt32(dr.GetOrdinal("IdCategoria"));
                    categoria.Nombre = dr.GetString(dr.GetOrdinal("Nombre"));
                    Add(categoria);
                }
            }
            


        }
    }
}
