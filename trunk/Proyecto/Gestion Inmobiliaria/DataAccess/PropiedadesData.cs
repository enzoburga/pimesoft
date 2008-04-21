using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace GI.DA
{
    public class PropiedadesData
    {
        public IDataReader RecuperarPropiedadesVentasTodas()
        {
            return AccesoDatos.RecuperarDatos(
                "PropiedadesVentas_RecuperarTodas",
                new object[] { },
                new string[] { });
        }

        public IDataReader RecuperarEstadoPropiedad(string ClasePropiedad)
        {
            return AccesoDatos.RecuperarDatos(
                "EstadosPropiedad_RecuperarPorClase",
                new object[] { ClasePropiedad },
                new string[] { "@Clase" });
        }

        public IDataReader RecuperarMedidasAmbientesPorPropiedad(int IdPropiedad)
        { 
            return AccesoDatos.RecuperarDatos(
                "MedidasAmbientes_RecuperarPorPropiedad",
                new object[] { IdPropiedad },
                new string[] { "@IdPropiedad" });
        }






    }
}
