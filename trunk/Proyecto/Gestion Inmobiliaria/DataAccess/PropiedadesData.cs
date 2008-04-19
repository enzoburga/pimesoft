using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GI.DA
{
    public class PropiedadesData
    {


        public IDataReader RecuperarEstadoPropiedad(string ClasePropiedad)
        {
            return AccesoDatos.RecuperarDatos(
                "EstadosPropiedad_RecuperarPorClase",
                new object[] { ClasePropiedad },
                new string[] { "@Clase" });
        }

    }
}
