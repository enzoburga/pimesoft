using System;
using System.Collections.Generic;
using System.Text;

namespace GI.DA
{
    public class ValoresRentaData
    {
        public System.Data.IDataReader RecuperarMontosPorContrato(int IdContrato)
        {
            return AccesoDatos.RecuperarDatos(
                "ValoresRenta_RecuperarMontosPorContrato",
                new object[] { IdContrato },
                new string[] { "@IdContrato" });

        }

        public int Guardar(int IdContrato, decimal Importe, int IdMoneda, int MesDesde, int AnioDesde, int MesHasta, int AnioHasta)
        {
            return AccesoDatos.InsertarRegistro(
                "ValorRenta_Guardar",
                new object[] { IdContrato, Importe, IdMoneda, MesDesde, AnioDesde, MesHasta, AnioHasta},
                new string[] { "@IdContrato", "@Importe", "@IdMoneda", "@MesDesde", "@AnioDesde", "@MesHasta", "@AnioHasta" });
        }

        public bool Actualizar(int IdValorRenta, int IdContrato, decimal Importe, int IdMoneda, int MesDesde, int AnioDesde, int MesHasta, int AnioHasta)
        {
            return AccesoDatos.ActualizarRegistro(
                "ValorRenta_Actualizar",
                new object[] { IdValorRenta, IdContrato, Importe, IdMoneda, MesDesde, AnioDesde, MesHasta, AnioHasta },
                new string[] { "@IdValorRenta", "@IdContrato", "@Importe", "@IdMoneda", "@MesDesde", "@AnioDesde", "@MesHasta", "@AnioHasta" });
        }

        public bool Eliminar(int IdValorRenta)
        {
            return AccesoDatos.EliminarRegistro(
                "ValorRenta_Eliminar",
                new object[] { IdValorRenta },
                new string[] { "@IdValorRenta" });
        }
    }
}
