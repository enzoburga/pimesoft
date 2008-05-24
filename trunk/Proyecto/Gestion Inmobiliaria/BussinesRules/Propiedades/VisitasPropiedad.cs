using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class VisitasPropiedad : List<VisitaPropiedad>
    {
        public VisitasPropiedad() { }


        public void RecuperarVisitasParaEvento()
        { 
        
        }

        public void Recuperar(Propiedad Propiedad)
        {
            Clear();
            VisitaPropiedad visita;
            TiemposAlarmaFactory tiempo = new TiemposAlarmaFactory();
            using (System.Data.IDataReader dr = new DA.PropiedadesData().RecuperarVisitas(Propiedad.IdPropiedad))
            {
                while (dr.Read())
                {
                    visita = new VisitaPropiedad();
                    visita.ConAlarma = dr.GetBoolean(dr.GetOrdinal("ConAlarma"));
                    visita.Detalles = dr.GetString(dr.GetOrdinal("Comentario"));
                    visita.FechaHora = dr.GetDateTime(dr.GetOrdinal("FechaHora"));
                    visita.IdPropiedad = Propiedad.IdPropiedad;
                    visita.IdVisita = dr.GetInt32(dr.GetOrdinal("IdVisita"));
                    visita.Realizada = dr.GetBoolean(dr.GetOrdinal("Realizada"));
                    visita.TelefonoContacto = dr.GetString(dr.GetOrdinal("Telefono"));
                    visita.TiempoAlarma = tiempo.Recuperar(dr.GetInt64(dr.GetOrdinal("TimpoAlarma")));
                    visita.Visita = dr.GetString(dr.GetOrdinal("Visita"));

                    Add(visita);

                
                }
            
            }
        
        }




    }
}
