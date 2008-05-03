using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.AdmAlquileres
{
    public class ValoresRenta: List<ValorRenta>
    {
        public void RecuperarMontosPorContrato(GI.BR.AdmAlquileres.Contrato contrato)
        {
            //ValorRenta vr = new ValorRenta();
            //vr.Monto = new Valor();
            //vr.Monto.Importe = 1000;
            //vr.Monto.Moneda = Monedas.MonedasFlyweigthFactory.GetInstancia.GetMoneda(1);
            //vr.MesVigenciaHasta = 8;
            //vr.MesVigenciaDesde = 1;
            //vr.AnioVigenciaDesde = 2008;
            //vr.AnioVigenciaHasta = 2009;

            //ValorRenta vr2 = new ValorRenta();
            //vr2.Monto = new Valor();
            //vr2.Monto.Importe = 23000;
            //vr2.Monto.Moneda = Monedas.MonedasFlyweigthFactory.GetInstancia.GetMoneda(1);
            //vr2.MesVigenciaHasta = 7;
            //vr2.MesVigenciaDesde = 9;
            //vr2.AnioVigenciaDesde = 2009;
            //vr2.AnioVigenciaHasta = 2010;

            //this.Add(vr);
            //this.Add(vr2);


            this.Clear();
            ValorRenta vr;
            using (System.Data.IDataReader dr = new GI.DA.ValoresRentaData().RecuperarMontosPorContrato(contrato.IdContrato))
            {
                while (dr.Read())
                {
                    vr = new ValorRenta();
                    vr.fill(dr);
                    this.Add(vr);
                }
            }
        }
    }
}
