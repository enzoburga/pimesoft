using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Eventos
{
    public class Eventos : List<Evento>
    {


        public void GenerarEventosPendientes()
        {
            new DA.EventosData().GenerarEventos();

        }


        public void RecuperarEventosPendientes()
        {

            Clear();
            Evento e;
            FactoryEventos factory = new FactoryEventos();

            using (System.Data.IDataReader dr = new DA.EventosData().RecuperarEventosPendientes())
            {
                while (dr.Read())
                {
                    e = factory.GetEvento((EnumTipoEvento)dr.GetInt32(dr.GetOrdinal("IdTipoEvento")));
                    e.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
                    e.Fecha = dr.GetDateTime(dr.GetOrdinal("FechaGeneracion"));
                    e.IdEvento = dr.GetInt32(dr.GetOrdinal("IdEvento"));
                    e.IdRelacion = dr.GetInt32(dr.GetOrdinal("IdRelacion"));
                    if (dr.IsDBNull(dr.GetOrdinal("FechaVencimiento")))
                        e.Vencimiento = null;
                    else
                        e.Vencimiento = dr.GetDateTime(dr.GetOrdinal("FechaVencimiento"));
                    Add(e);

                }
            }



        }

    }
}
