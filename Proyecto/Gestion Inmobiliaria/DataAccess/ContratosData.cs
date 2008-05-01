using System;
using System.Collections.Generic;
using System.Text;

namespace GI.DA
{
    public class ContratosData
    {
        public int GuardarConrato(int IdInquilino, int IdPropiedad, DateTime FechaInicio, DateTime FechaVencimiento, decimal MontoCuota, int IdMonedaMonto, decimal MontoDeposito, int IdMonedaDeposito, int DiaVencimientoCuota, int IdContratoAnterior, Nullable<DateTime> FechaCancelacion, string Observaciones, bool vigente)
        {
            object Inquilino = IdInquilino;
            object contratoAnterior = IdContratoAnterior;
            object fechaCanc = FechaCancelacion;

            if (IdInquilino == 0)
                Inquilino = System.DBNull.Value;

            if (IdContratoAnterior == 0)
                contratoAnterior = System.DBNull.Value;

            if (FechaCancelacion == null)
                fechaCanc = System.DBNull.Value;

            return AccesoDatos.InsertarRegistro(
                "Contrato_Guardar",
                new object[] { Inquilino, IdPropiedad, FechaInicio, FechaVencimiento, MontoCuota, IdMonedaMonto, MontoDeposito, IdMonedaDeposito, DiaVencimientoCuota, contratoAnterior, fechaCanc, Observaciones, vigente},
                new string[] { "@IdInquilino", "@IdPropiedad", "@FechaInicio", "@FechaVencimiento", "@MontoCuota", "@IdMonedaMonto", "@MontoDeposito", "@IdMonedaDeposito", "@DiaVencimientoCuota", "@IdContratoAnterior", "@FechaCancelacion", "@Observaciones" , "@Vigente"});
        }

        public bool ActualizarContrato(int IdContrato, int IdInquilino, int IdPropiedad, DateTime FechaInicio, DateTime FechaVencimiento, decimal MontoCuota, int IdMonedaMonto, decimal MontoDeposito, int IdMonedaDeposito, int DiaVencimientoCuota, int IdContratoAnterior, Nullable<DateTime> FechaCancelacion, string Observaciones, bool vigente)
        {
            object Inquilino = IdInquilino;
            object contratoAnterior = IdContratoAnterior;
            object fechaCanc = FechaCancelacion;

            if (IdInquilino == 0)
                Inquilino = System.DBNull.Value;

            if (IdContratoAnterior == 0)
                contratoAnterior = System.DBNull.Value;

            if (FechaCancelacion == null)
                fechaCanc = System.DBNull.Value;

            return AccesoDatos.ActualizarRegistro(
                "Contrato_Actualizar",
                new object[] { IdContrato, Inquilino, IdPropiedad, FechaInicio, FechaVencimiento, MontoCuota, IdMonedaMonto, MontoDeposito, IdMonedaDeposito, DiaVencimientoCuota, contratoAnterior, fechaCanc, Observaciones, vigente },
                new string[] { "@IdContrato", "@IdInquilino", "@IdPropiedad", "@FechaInicio", "@FechaVencimiento", "@MontoCuota", "@IdMonedaMonto", "@MontoDeposito", "@IdMonedaDeposito", "@DiaVencimientoCuota", "@IdContratoAnterior", "@FechaCancelacion", "@Observaciones", "@Vigente" });
        }

        public System.Data.IDataReader RecuperarPorAdmAlquiler(int IdAdmAlquiler)
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
