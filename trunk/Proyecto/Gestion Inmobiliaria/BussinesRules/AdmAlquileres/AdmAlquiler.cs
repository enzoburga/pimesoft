using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.AdmAlquileres
{
    public class AdmAlquiler : ICloneable
    {
        private Contrato contratoVigente;
        private Contratos contratos;
        private GI.BR.Propiedades.Alquiler alquiler;

        public Contrato ContratoVigente { get { return contratoVigente; } set { contratoVigente = value; } }

        public Contratos Contratos { get { return contratos; } set { contratos = value; } }

        public GI.BR.Propiedades.Alquiler Alquiler { get { return alquiler; } set { alquiler = value; } }


        #region ICloneable Members

        public object Clone()
        {
            return base.MemberwiseClone();
        }

        #endregion
    }
}
