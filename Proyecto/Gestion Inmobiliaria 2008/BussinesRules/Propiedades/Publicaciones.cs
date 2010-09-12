using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class Publicaciones : List<Publicacion>
    {
        Monedas.MonedasFlyweigthFactory monedasFactory = GI.BR.Monedas.MonedasFlyweigthFactory.GetInstancia;

        public void Recuperar(Propiedad Propiedad)
        {
            Clear();
            Publicacion p;
            using (System.Data.IDataReader dr = new DA.PropiedadesData().RecuperarPublicaciones(Propiedad.IdPropiedad))
            {
                while (dr.Read())
                {
                    p = new Publicacion();
                    p.Detalles = dr.GetString(dr.GetOrdinal("Detalles"));
                    p.Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha"));
                    p.IdPropiedad = Propiedad.IdPropiedad;
                    p.IdPublicacion = dr.GetInt32(dr.GetOrdinal("IdPublicacion"));
                    p.Medio = dr.GetString(dr.GetOrdinal("Medio"));
                    p.ValorPublicacion = new Valor();
                    p.ValorPublicacion.Importe = dr.GetDecimal(dr.GetOrdinal("Importe"));
                    p.ValorPublicacion.Moneda = monedasFactory.GetMoneda(dr.GetInt32(dr.GetOrdinal("IdMoneda")));

                    Add(p);
                }
            
            }
        }

    }
}
