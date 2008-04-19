using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GI.DA
{
    public class CategoriasPropiedadData
    {

        public IDataReader RecuperarTiposDePropiedad(int IdCategoria)
        {
            return AccesoDatos.RecuperarDatos(
                "TiposPropiedad_RecuperarPorCategoria",
                new object[] { IdCategoria },
                new string[] { "@IdCategoria" });
        }

        public IDataReader RecuperarCategoriasPropiedad()
        {
            return AccesoDatos.RecuperarDatos(
                "CategoriasPropiedad_RecuperarTodas",
                new object[] { },
                new string[] { });

        }

    }
}
