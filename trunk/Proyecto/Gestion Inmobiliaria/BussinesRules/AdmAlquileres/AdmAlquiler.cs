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

        private Clientes.Propietario contacto;
        private Contrato contratoVigente;
        private Contratos contratos;
        private Propiedades.Alquiler alquiler;

        #endregion

        #region Propiedades

        public Contrato ContratoVigente
        {
            get { return contratoVigente; }
            set { contratoVigente = value; }
        }
        public Contratos Contratos
        {
            get { return contratos; }
            set { contratos = value; }
        }

        public GI.BR.Propiedades.Alquiler Alquiler
        {
            get { return alquiler; }
            set
            {
                alquiler = value;
                this.ContratoVigente.Alquiler = value;
            }

        }



        public Clientes.Propietario Contacto { get { return contacto; } set { contacto = value; } }

        #endregion

        #region Persistencia
        internal void fill(System.Data.IDataReader dr)
        {
            #region Contacto

            if(!dr.IsDBNull(dr.GetOrdinal("IdContacto")))
            {
                this.contacto = new GI.BR.Clientes.Propietario();
                contacto.IdCliente = dr.GetInt32(dr.GetOrdinal("IdContacto"));
            }
            
            
            #endregion

            #region Contrato
            this.ContratoVigente = new Contrato();
            this.ContratoVigente.Deposito = new Valor();
            this.ContratoVigente.Deposito.Importe = dr.GetDecimal(dr.GetOrdinal("MontoDeposito"));
            this.ContratoVigente.Deposito.Moneda = new GI.BR.Monedas.Moneda();
            this.ContratoVigente.Deposito.Moneda.IdMoneda = dr.GetInt32(dr.GetOrdinal("IdMonedaDeposito"));
            this.ContratoVigente.DiaCobro = dr.GetByte(dr.GetOrdinal("DiaVencimientoCuota"));
            
            if (dr.IsDBNull(dr.GetOrdinal("FechaCancelacion")))
                this.ContratoVigente.FechaCancelacion = null;
            else
                this.ContratoVigente.FechaCancelacion = dr.GetDateTime(dr.GetOrdinal("FechaCancelacion"));

            this.ContratoVigente.FechaInicio = dr.GetDateTime(dr.GetOrdinal("FechaInicio"));
            this.ContratoVigente.FechaVencimiento = dr.GetDateTime(dr.GetOrdinal("FechaVencimiento"));

            if (!dr.IsDBNull(dr.GetOrdinal("IdInquilino")))
            {
                this.ContratoVigente.Inquilino = new GI.BR.Clientes.Inquilino();
                this.ContratoVigente.Inquilino.IdCliente = dr.GetInt32(dr.GetOrdinal("IdInquilino"));
            }

            this.ContratoVigente.Monto = new Valor();
            this.ContratoVigente.Monto.Importe = dr.GetDecimal(dr.GetOrdinal("MontoCuota"));
            this.ContratoVigente.Monto.Moneda = new GI.BR.Monedas.Moneda();
            this.ContratoVigente.Monto.Moneda.IdMoneda = dr.GetInt32(dr.GetOrdinal("IdMonedaMonto"));
            this.ContratoVigente.Observaciones = dr.GetString(dr.GetOrdinal("Observaciones"));
            this.ContratoVigente.IdContrato = dr.GetInt32(dr.GetOrdinal("IdContrato"));

            if (!dr.IsDBNull(dr.GetOrdinal("IdContratoAnterior")))
            {
                this.ContratoVigente.ContratoAnterior = new Contrato();
                this.ContratoVigente.ContratoAnterior.IdContrato = dr.GetInt32(dr.GetOrdinal("IdContratoAnterior"));
            }

            #endregion

            #region Alquiler
            this.Alquiler = new GI.BR.Propiedades.Alquiler();
            this.Alquiler.IdPropiedad = dr.GetInt32(dr.GetOrdinal("IdPropiedad"));
            #endregion
        }

        public bool Guardar()
        {
            GI.DA.AdmAlquileresData ad = new GI.DA.AdmAlquileresData();
            return ad.Guardar(this.Alquiler.IdPropiedad, (this.Contacto == null) ? 0 : this.Contacto.IdCliente);
        }

        public bool Actualizar()
        {
            GI.DA.AdmAlquileresData ad = new GI.DA.AdmAlquileresData();
            return ad.Actualizar(this.Alquiler.IdPropiedad, (this.Contacto == null) ? 0 : this.Contacto.IdCliente);
        }
        #endregion

        #region ICloneable Members

        public object Clone()
        {
            return base.MemberwiseClone();
        }

        #endregion
    }
}
