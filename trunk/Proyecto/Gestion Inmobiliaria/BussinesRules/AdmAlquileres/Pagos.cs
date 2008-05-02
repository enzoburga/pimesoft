using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.AdmAlquileres
{
    public class Pagos:List<Pago>
    {
        public void RecuperarPorContrato(Contrato contrato)
        {
            GI.BR.Monedas.MonedasFlyweigthFactory mff = GI.BR.Monedas.MonedasFlyweigthFactory.GetInstancia;

            //GI.DA.PagosData pd = new GI.DA.PagosData();
            //Pago p;
            //using(System.Data.IDataReader dr = pd.RecuperarPorContrato(contrato.IdContrato))
            //{
            //    while(dr.Read())
            //    {
            //        p = new Pago();
            //        p.fill(dr);
            //        this.Add(p);
            //    }
            //}

            //foreach (Pago pago in this)
            //{
            //    pago.Importe.Moneda = mff.GetMoneda(pago.Importe.Moneda.IdMoneda);
            //}
        }

        
    }
}
