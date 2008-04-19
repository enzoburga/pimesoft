using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GI.BR.Propiedades
{
    public class CategoriasPropiedad : List<CategoriaPropiedad>
    {



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
