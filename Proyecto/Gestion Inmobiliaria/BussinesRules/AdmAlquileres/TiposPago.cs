using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.AdmAlquileres
{
    public class TiposPago:List<TipoPago>
    {
        public void RecuperarTodos()
        {
            this.Clear();
            TipoPago tp;
            GI.DA.TiposPagoData tpd = new GI.DA.TiposPagoData();
            using (System.Data.IDataReader dr = tpd.RecuperarTodos())
            {
                while (dr.Read())
                {
                    tp = new TipoPago();
                    tp.fill(dr);
                    this.Add(tp);
                }
            }
        }
    }
}
