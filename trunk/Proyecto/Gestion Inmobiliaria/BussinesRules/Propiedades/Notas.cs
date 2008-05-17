using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class Notas : List<Nota>
    {


        public void Recuperar(Propiedad Propiedad)
        {
            Clear();

            Nota n;
            using (System.Data.IDataReader dr = new DA.PropiedadesData().RecuperarNotasPropiedad(Propiedad.IdPropiedad))
            {
                while (dr.Read())
                {
                    n = new Nota();
                    n.Comentario = dr.GetString(dr.GetOrdinal("Nota"));
                    n.IdNota = dr.GetInt32(dr.GetOrdinal("IdNota"));
                    n.Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha"));

                    Add(n);
                }
            }
        
        }

    }
}
