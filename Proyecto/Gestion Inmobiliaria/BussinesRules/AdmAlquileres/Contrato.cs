using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.AdmAlquileres
{
    public class Contrato : ICloneable
    {
        #region Miembros Privados
        private int idContrato;
        private GI.BR.Clientes.Inquilino inquilino;
        private DateTime fechaInicio;
        private DateTime fechaVencimiento;
        private Nullable<DateTime> fechaCancelacion;
        //private GI.BR.Valor monto;
        private GI.BR.Valor deposito; 
        private int diaCobro;
        private string observaciones;
        private Contrato contratoAnterior;
        private GI.BR.Propiedades.Alquiler alquiler;
        private bool vigente;
        private ValoresRenta valoresRenta = null;

        public ValoresRenta ValoresRenta
        {
            get
            {
                if (valoresRenta == null)
                {
                    valoresRenta = new ValoresRenta();
                    valoresRenta.RecuperarMontosPorContrato(this);
                }
                return valoresRenta;
            }
            set
            {
                valoresRenta = value;
            }
        }
        #endregion

        #region Propiedades Publicas

        public int IdContrato { get { return idContrato; } set { idContrato = value; } }

        public GI.BR.Clientes.Inquilino Inquilino
        {
            get { return inquilino; }
            set { inquilino = value; }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        public GI.BR.Valor Deposito
        {
            get { return deposito; }
            set { deposito = value; }
        }

        public DateTime FechaVencimiento { get { return fechaVencimiento; } set { fechaVencimiento = value; } }

        public Nullable<DateTime> FechaCancelacion { get { return fechaCancelacion; } set { fechaCancelacion = value; } }

        //public GI.BR.Valor Monto
        //{
        //    get
        //    {
        //        return monto;
        //    }
        //    set
        //    {
        //        monto = value;
        //    }
        //}

        public GI.BR.Valor GetMonto(int Mes, int Anio)
        { 
            bool esMenorHasta = false;
            bool esMayorDesde = false;
            foreach(GI.BR.AdmAlquileres.ValorRenta vr in this.ValoresRenta )
            {
                if(vr.FechaPerteneceARango(Mes,Anio))
                    return vr.Monto;
            }

            return null;
        }

        public string Observaciones { get { return observaciones; } set { observaciones = value; } }

        public int DiaCobro { get { return diaCobro; } set { diaCobro = value; } }

        public Contrato ContratoAnterior { get { return contratoAnterior; } set { contratoAnterior = value; } }

        public GI.BR.Propiedades.Alquiler Alquiler { get { return alquiler; } set { alquiler = value; } }

        public bool Vigente { get { return vigente; } set { vigente = value; } }

        #endregion

        public bool Guardar()
        {
            GI.DA.ContratosData cd = new GI.DA.ContratosData();
            this.IdContrato = cd.GuardarConrato((Inquilino == null) ? 0:Inquilino.IdCliente, Alquiler.IdPropiedad, FechaInicio, FechaVencimiento, Deposito.Importe, Deposito.Moneda.IdMoneda, DiaCobro, (ContratoAnterior == null) ? 0 : ContratoAnterior.IdContrato, FechaCancelacion, Observaciones,vigente);
            return IdContrato > 0;
        }

        public bool Actualizar()
        {
            GI.DA.ContratosData cd = new GI.DA.ContratosData();
            return cd.ActualizarContrato(IdContrato, (Inquilino == null) ? 0 : Inquilino.IdCliente, Alquiler.IdPropiedad, FechaInicio, FechaVencimiento, Deposito.Importe, Deposito.Moneda.IdMoneda, DiaCobro, (ContratoAnterior == null) ? 0 : ContratoAnterior.IdContrato, FechaCancelacion, Observaciones,vigente);            
        }

        public void fill(System.Data.IDataReader dr)
        {
            this.Deposito = new Valor();
            this.Deposito.Importe = dr.GetDecimal(dr.GetOrdinal("MontoDeposito"));
            this.Deposito.Moneda = new GI.BR.Monedas.Moneda();
            this.Deposito.Moneda = Monedas.MonedasFlyweigthFactory.GetInstancia.GetMoneda(dr.GetInt32(dr.GetOrdinal("IdMonedaDeposito")));
            this.DiaCobro = dr.GetByte(dr.GetOrdinal("DiaVencimientoCuota"));

            if (dr.IsDBNull(dr.GetOrdinal("FechaCancelacion")))
                this.FechaCancelacion = null;
            else
                this.FechaCancelacion = dr.GetDateTime(dr.GetOrdinal("FechaCancelacion"));

            this.FechaInicio = dr.GetDateTime(dr.GetOrdinal("FechaInicio"));
            this.FechaVencimiento = dr.GetDateTime(dr.GetOrdinal("FechaVencimiento"));

            if (!dr.IsDBNull(dr.GetOrdinal("IdInquilino")))
            {
                this.Inquilino = new GI.BR.Clientes.Inquilino();
                this.Inquilino.IdCliente = dr.GetInt32(dr.GetOrdinal("IdInquilino"));
            }

            this.Observaciones = dr.GetString(dr.GetOrdinal("Observaciones"));
            this.IdContrato = dr.GetInt32(dr.GetOrdinal("IdContrato"));
            this.vigente = dr.GetBoolean(dr.GetOrdinal("Vigente"));
        }

        #region ICloneable Members

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion
    }
}
