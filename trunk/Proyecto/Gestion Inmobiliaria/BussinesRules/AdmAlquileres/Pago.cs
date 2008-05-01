using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.AdmAlquileres
{
    public class Pago:ICloneable 
    {
        #region Miembros Privados
        private int idPago;
        private int idContrato;
        private Valor importe;
        private bool anulado;
        private DateTime fechaPago;
        private DateTime fechaAlta;
        private int mesCancelado;
        #endregion

        #region Miembros Publicos

        public int IdPago { get { return idPago; } set { idPago = value; } }

        public int IdContrato { get { return idContrato; } set { idContrato = value; } }

        public Valor Importe { get { return importe; } set { importe = value; } }

        public bool Anulado { get { return anulado; } set { anulado = value; } }

        public DateTime FechaPago { get { return fechaPago; } set { fechaPago = value; } }

        public int MesCancelado { get { return mesCancelado; } set { mesCancelado = value; } }

        public DateTime FechaAlta { get { return fechaAlta; } set { fechaAlta = value; } }

        #endregion

        internal virtual void fill(System.Data.IDataReader dr)
        {
            this.IdPago = dr.GetInt32(dr.GetOrdinal("IdPago"));
            this.IdContrato = dr.GetInt32(dr.GetOrdinal("IdContrato"));
            this.Importe = new Valor();
            this.Importe.Moneda = new GI.BR.Monedas.Moneda();
            this.Importe.Importe = dr.GetDecimal(dr.GetOrdinal("Importe"));
            this.Importe.Moneda.IdMoneda = dr.GetInt32(dr.GetOrdinal("IdMoneda"));
            this.Anulado = dr.GetBoolean(dr.GetOrdinal("Anulado"));
            this.FechaPago = dr.GetDateTime(dr.GetOrdinal("FechaPago"));
            this.FechaAlta = dr.GetDateTime(dr.GetOrdinal("FechaAlta"));
            this.mesCancelado = dr.GetInt32(dr.GetOrdinal("MesCancelado"));
        }

        public bool Guardar()
        {
            GI.DA.PagosData pd = new GI.DA.PagosData();
            this.IdPago = pd.Guardar(false, this.FechaPago, this.IdContrato, this.Importe.Importe, this.Importe.Moneda.IdMoneda, this.MesCancelado, this.FechaAlta);
            return IdPago > 0;
        }

        public bool Actualizar()
        {
            GI.DA.PagosData pd = new GI.DA.PagosData();
            return pd.Actualizar(this.IdPago, false, this.FechaPago, this.IdContrato, this.Importe.Importe, this.Importe.Moneda.IdMoneda, this.MesCancelado, this.FechaAlta);

        }

        #region ICloneable Members

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion

        public bool Anular()
        {
            GI.DA.PagosData pd = new GI.DA.PagosData();
            return pd.Anular(this.IdPago);

        }
    }
}
