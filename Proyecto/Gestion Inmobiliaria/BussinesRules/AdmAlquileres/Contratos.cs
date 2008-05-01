using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.AdmAlquileres
{
    public class Contratos : List<Contrato>
    {
        public void RecuperarPorAdmAlquiler(AdmAlquiler admAlquiler)
        {
            Monedas.MonedasFlyweigthFactory mff = GI.BR.Monedas.MonedasFlyweigthFactory.GetInstancia;
            Contrato c;
            using (System.Data.IDataReader dr = new GI.DA.ContratosData().RecuperarPorAdmAlquiler(admAlquiler.Alquiler.IdPropiedad))
            {
                while (dr.Read())
                {
                    c = new Contrato();
                    c.fill(dr);
                    this.Add(c);
                }
            }

            foreach (Contrato cont in this)
            {
                cont.Monto.Moneda = mff.GetMoneda(cont.Monto.Moneda.IdMoneda);
                cont.Deposito.Moneda = mff.GetMoneda(cont.Deposito.Moneda.IdMoneda);
            }
        }
    }
}
