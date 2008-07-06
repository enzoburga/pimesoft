using System;
using System.Collections.Generic;
using System.Text;

namespace GI.DA
{
    public class ParametrosReportesData
    {


        public System.Data.IDataReader RecuperarParametrosReporte()
        {
            return AccesoDatos.RecuperarDatos("Reportes_RecuperarParametros", new object[] { }, new string[] { });
        }

        public bool GuardarParametrosReporte(byte[] Encabezado, byte[] PiePagina)
        {
            return AccesoDatos.ActualizarRegistro(
                "Reportes_GuardarParametros",
                new object[] { Encabezado, PiePagina },
                new string[] { "@Encabezado", "@PiePagina" });
        }



    }
}
