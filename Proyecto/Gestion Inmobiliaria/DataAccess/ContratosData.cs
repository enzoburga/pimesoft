using System;
using System.Collections.Generic;
using System.Text;

namespace GI.DA
{
    public class ContratosData
    {
        public int GuardarConrato(int IdInquilino, int IdPropiedad, DateTime FechaInicio, DateTime FechaVencimiento, decimal MontoCuota, int IdMonedaMonto, decimal MontoDeposito, int IdMonedaDeposito, int DiaVencimientoCuota, int IdContratoAnterior, Nullable<DateTime> FechaCancelacion, string Observaciones)
        {
            return AccesoDatos.InsertarRegistro(
                "Contrato_Guardar",
                new object[] { IdInquilino, IdPropiedad, FechaInicio, FechaVencimiento, MontoCuota, IdMonedaMonto, MontoDeposito, IdMonedaDeposito, DiaVencimientoCuota, IdContratoAnterior, FechaCancelacion, Observaciones },
                new string[] { "@IdInquilino", "@IdPropiedad", "@FechaInicio", "@FechaVencimiento", "@MontoCuota", "@IdMonedaMonto", "@MontoDeposito", "@IdMonedaDeposito", "@DiaVencimientoCuota", "@IdContratoAnterior", "@FechaCancelacion", "@Observaciones" });
        }

                public bool ActualizarContrato(int IdContrato, int IdInquilino,int IdPropiedad,DateTime FechaInicio,DateTime FechaVencimiento,decimal MontoCuota,int IdMonedaMonto,decimal MontoDeposito,int IdMonedaDeposito,int DiaVencimientoCuota,int IdContratoAnterior,Nullable<DateTime> FechaCancelacion,string Observaciones)
        {
            return AccesoDatos.ActualizarRegistro(
                "Contrato_Actualizar",
                new object[] { IdContrato, IdInquilino, IdPropiedad, FechaInicio, FechaVencimiento, MontoCuota, IdMonedaMonto, MontoDeposito, IdMonedaDeposito, DiaVencimientoCuota, IdContratoAnterior, FechaCancelacion, Observaciones },
                new string[] { "@IdContrato", "@IdInquilino", "@IdPropiedad", "@FechaInicio", "@FechaVencimiento", "@MontoCuota", "@IdMonedaMonto", "@MontoDeposito", "@IdMonedaDeposito", "@DiaVencimientoCuota", "@IdContratoAnterior", "@FechaCancelacion", "@Observaciones" });
        }
    }
}
