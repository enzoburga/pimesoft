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
        private int idAdmAlquiler;

        private Contrato contratoVigente;
        private Contratos contratos;
        private GI.BR.Propiedades.Alquiler alquiler; 
        #endregion

        #region Propiedades
        public int IdAdmAlquiler
        {
            get { return idAdmAlquiler; }
            set { idAdmAlquiler = value; }
        }
        public Contrato ContratoVigente { get { return contratoVigente; } set { contratoVigente = value; } }

        public Contratos Contratos { get { return contratos; } set { contratos = value; } }

        public GI.BR.Propiedades.Alquiler Alquiler { get { return alquiler; } set { alquiler = value; } }


        #endregion

        internal void fill(System.Data.IDataReader dr)
        { 
            this.idAdmAlquiler = dr.GetInt32(dr.GetOrdinal("IdAdmAlquiler"));
        }

        #region ICloneable Members

        public object Clone()
        {
            return base.MemberwiseClone();
        }

        #endregion
    }
}
