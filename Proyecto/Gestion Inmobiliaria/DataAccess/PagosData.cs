using System;
using System.Collections.Generic;
using System.Text;

namespace GI.DA
{
    public class PagosData
    {
        public System.Data.IDataReader RecuperarPorContrato(int IdContrato)
        {
            return AccesoDatos.RecuperarDatos(
                "Pagos_RecuperarPorContrato",
                new object[] {IdContrato },
                new string[] {"@IdContrato" });
        }

        public bool Actualizar(int IdPago, bool Anulado, DateTime FechaPago, int IdContrato, decimal Importe, int IdMoneda, int MesCancelado, DateTime FechaAlta)
        {
            return AccesoDatos.ActualizarRegistro(
                "Pago_Actualizar",
                new object[] { IdPago, Anulado, FechaPago, IdContrato, Importe, IdMoneda, MesCancelado ,FechaAlta},
                new string[] { "@IdPago", "@Anulado", "@FechaPago", "@IdContrato", "@Importe", "@IdMoneda", "@MesCancelado", "@FechaAlta" });
        }

        public int Guardar(bool Anulado, DateTime FechaPago, int IdContrato, decimal Importe, int IdMoneda, int MesCancelado, DateTime FechaAlta)
        {
            return AccesoDatos.InsertarRegistro(
                "Pago_Guardar",
                new object[] { Anulado,FechaPago,IdContrato,Importe,IdMoneda,MesCancelado,FechaAlta},
                new string[] { "@Anulado", "@FechaPago", "@IdContrato", "@Importe", "@IdMoneda", "@MesCancelado", "@FechaAlta" });
        }

        public bool Anular(int IdPago)
        {
            return AccesoDatos.ActualizarRegistro(
                "Pago_Anular",
                new object[] { IdPago},
                new string[] { "@IdPago"});

        }
    }
}
