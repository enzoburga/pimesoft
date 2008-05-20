using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class Llamados : List<Llamado>
    {



        public void Recuperar(Propiedad Propiedad)
        {
            Clear();
            Llamado l;
            using (System.Data.IDataReader dr = new DA.PropiedadesData().RecuperarLlamados(Propiedad.IdPropiedad))
            {
                while (dr.Read())
                {
                    l = new Llamado();

                    l.Comentario = dr.GetString(dr.GetOrdinal("Comentarios"));
                    l.Contacto = dr.GetString(dr.GetOrdinal("Contacto"));
                    l.FechaHora = dr.GetDateTime(dr.GetOrdinal("FechaHora"));
                    l.IdLlamado = dr.GetInt32(dr.GetOrdinal("IdLlamado"));
                    l.IdPropiedad = Propiedad.IdPropiedad;
                    l.Telefono = dr.GetString(dr.GetOrdinal("Telefono"));

                    Add(l);
                
                }
            
            
            }


        
        
        }
    }
}
