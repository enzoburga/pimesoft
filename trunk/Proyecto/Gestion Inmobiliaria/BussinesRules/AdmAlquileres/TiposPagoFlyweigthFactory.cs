using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.AdmAlquileres
{
    public class TiposPagoFlyweigthFactory
    {
                private System.Collections.Hashtable hashTiposPago;

        private TiposPagoFlyweigthFactory()
        {
            TiposPago tiposPago = new TiposPago();
            hashTiposPago = new System.Collections.Hashtable();
            tiposPago.RecuperarTodos();
            foreach (TipoPago tp in tiposPago)
                hashTiposPago.Add(tp.IdTipoPago, tp);
        }


        public TipoPago GetTipoPago(int IdTipoPago)
        {
            return (TipoPago)hashTiposPago[IdTipoPago];
        }

        private static TiposPagoFlyweigthFactory instancia;
        public static TiposPagoFlyweigthFactory GetInstancia
        {
            get
            {
                if (instancia == null)
                    instancia = new TiposPagoFlyweigthFactory();
                return instancia;
            }
        }
    }
}
