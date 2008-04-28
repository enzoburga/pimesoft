using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.AdmAlquileres
{
    public class AdmAlquiler : ICloneable
    {
        public AdmAlquiler()
        {
        }

        #region Miembros Privados


        private Clientes.Cliente contacto;
        private Contrato contratoVigente;
        private Contratos contratos;
        #endregion

        #region Propiedades

        public Contrato ContratoVigente { get { return contratoVigente; } set { contratoVigente = value; } }

        public Contratos Contratos { get { return contratos; } set { contratos = value; } }

        public GI.BR.Propiedades.Alquiler Alquiler { get { return contratoVigente.Alquiler; } set { contratoVigente.Alquiler = value; } }


        #endregion

        internal void fill(System.Data.IDataReader dr)
        {
            this.ContratoVigente = new Contrato();
            this.ContratoVigente.Deposito = new Valor();
            this.ContratoVigente.Deposito.Importe = dr.GetDecimal(dr.GetOrdinal("MontoDeposito"));
            this.ContratoVigente.Deposito.Moneda = new GI.BR.Monedas.Moneda();
            this.ContratoVigente.Deposito.Moneda.IdMoneda = dr.GetInt32(dr.GetOrdinal("IdMonedaDeposito"));
            this.ContratoVigente.DiaCobro = dr.GetInt32(dr.GetOrdinal("DiaVencimientoCuota"));
            if(dr.IsDBNull(dr.GetOrdinal("FechaCancelacion")))
                this.ContratoVigente.FechaCancelacion = null;
            else
                this.ContratoVigente.FechaCancelacion = dr.GetDateTime(dr.GetOrdinal("FechaCancelacion"));
            this.ContratoVigente.FechaInicio = dr.GetDateTime(dr.GetOrdinal("FechaInicio"));
            this.ContratoVigente.FechaVencimiento = dr.GetDateTime(dr.GetOrdinal("FechaVencimiento"));
            this.ContratoVigente.Inquilino = new GI.BR.Clientes.Inquilino();
            this.ContratoVigente.Inquilino.IdCliente = dr.GetInt32(dr.GetOrdinal("IdInquilino"));
            this.ContratoVigente.Monto = new Valor();
            this.ContratoVigente.Monto.Importe = dr.GetDecimal(dr.GetOrdinal("MontoCuota"));
            this.ContratoVigente.Monto.Moneda = new GI.BR.Monedas.Moneda();
            this.ContratoVigente.Monto.Moneda.IdMoneda = dr.GetInt32(dr.GetOrdinal("IdMonedaMonto"));
            this.ContratoVigente.Observaciones = dr.GetString(dr.GetOrdinal("Observaciones"));
            this.ContratoVigente.IdContrato = dr.GetInt32(dr.GetOrdinal("IdContrato"));
            this.ContratoVigente.ContratoAnterior = new Contrato();
            this.ContratoVigente.ContratoAnterior.IdContrato = dr.GetInt32(dr.GetOrdinal("IdContratoAnterior")); 

            this.Alquiler = new GI.BR.Propiedades.Alquiler();
            this.Alquiler.IdPropiedad = dr.GetInt32(dr.GetOrdinal("IdPropiedad"));            
        }

        #region ICloneable Members

        public object Clone()
        {
            return base.MemberwiseClone();
        }

        #endregion
    }
}
