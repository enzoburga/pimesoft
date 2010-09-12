using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class Tasaciones : List<Tasacion>
    {
        GI.BR.Monedas.MonedasFlyweigthFactory monedasFactory = GI.BR.Monedas.MonedasFlyweigthFactory.GetInstancia;

        public void Recuperar(Propiedad Propiedad)
        {
            Clear();
            Tasacion t;
            using (System.Data.IDataReader dr = new DA.PropiedadesData().RecuperarTasaciones(Propiedad.IdPropiedad))
            {
                while (dr.Read())
                {
                    t = new Tasacion();
                    t.Comentarios = dr.GetString(dr.GetOrdinal("Comentarios"));
                    t.Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha"));
                    t.IdPropiedad = Propiedad.IdPropiedad;
                    t.IdTasacion = dr.GetInt32(dr.GetOrdinal("IdTasacion"));
                    t.ValorPublicacion = new Valor();
                    t.ValorPublicacion.Importe = dr.GetDecimal(dr.GetOrdinal("ImporteValorPublicacion"));
                    t.ValorPublicacion.Moneda = monedasFactory.GetMoneda(dr.GetInt32(dr.GetOrdinal("IdMonedaValorPublicacion")));
                    t.ValorReal = new Valor();
                    t.ValorReal.Moneda = monedasFactory.GetMoneda(dr.GetInt32(dr.GetOrdinal("IdMonedaValorReal")));
                    t.ValorReal.Importe = dr.GetDecimal(dr.GetOrdinal("ImporteValorReal"));

                    Add(t);

                }
            
            }
        
        }


    }
}
