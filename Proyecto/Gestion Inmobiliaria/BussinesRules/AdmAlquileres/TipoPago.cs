using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.AdmAlquileres
{
    public class TipoPago
    {
        private int idTipoPago;
        private string descripcion;

        #region Miembros Publicos

        public int IdTipoPago { get { return idTipoPago; } set { idTipoPago = value; } }

        public string Descripcion { get { return descripcion; } set { descripcion = value; } }

        #endregion

        internal void fill(System.Data.IDataReader dr)
        {
            this.IdTipoPago = dr.GetInt32(dr.GetOrdinal("IdTipoPago"));
            this.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
        }


    }
}
