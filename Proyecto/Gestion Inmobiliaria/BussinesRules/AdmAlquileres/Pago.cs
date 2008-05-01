using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.AdmAlquileres
{
    public class Pago
    {
        #region Miembros Privados
        private int idPago;
        private int idContrato;
        private Valor importe;
        private bool anulado;
        private TipoPago tipoPago; 
        #endregion

        #region Miembros Publicos

        public int IdPago { get { return idPago; } set { idPago = value; } }

        public int IdContrato { get { return idContrato; } set { idContrato = value; } }

        public Valor Importe { get { return importe; } set { importe = value; } }

        public bool Anulado { get { return anulado; } set { anulado = value; } }

        public TipoPago TipoPago { get { return tipoPago; } set { tipoPago = value; } }
        
        #endregion

        internal void fill(System.Data.IDataReader dr)
        {
            this.IdPago = dr.GetInt32(dr.GetOrdinal("IdPago"));
            this.IdContrato = dr.GetInt32(dr.GetOrdinal("IdContrato"));
            this.Importe = new Valor();
            this.Importe.Moneda = new GI.BR.Monedas.Moneda();
            this.Importe.Importe = dr.GetDecimal(dr.GetOrdinal("Importe"));
            this.Importe.Moneda.IdMoneda = dr.GetInt32(dr.GetOrdinal("IdMoneda"));
            this.TipoPago = new TipoPago();
            this.TipoPago.IdTipoPago = dr.GetInt32(dr.GetOrdinal("IdTipoPago"));
            this.Anulado = dr.GetBoolean(dr.GetOrdinal("Anulado"));
        }
    }
}
