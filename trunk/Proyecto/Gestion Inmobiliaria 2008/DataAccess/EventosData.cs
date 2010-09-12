using System;
using System.Collections.Generic;
using System.Text;

namespace GI.DA
{
    public class EventosData
    {

        public bool SilenciarEvento(int IdEvento)
        {
            return AccesoDatos.ActualizarRegistro("Eventos_SilenciarEvento",
                new object[] { IdEvento }, new string[] { "@IdEvento" });
        }

        public DateTime RecuperarUltimaFechaGeneracion()
        {
            DateTime fecha = new DateTime(1901, 1, 1);
            using (System.Data.IDataReader dr = AccesoDatos.RecuperarDatos("EventosControl_SelectUltimaFechaGeneracion", new object[] { }, new string[] { }))
            {
                if (dr.Read())
                { 
                    if(dr.IsDBNull(0))
                    {
                        fecha = dr.GetDateTime(0);
                    }
                }
            }


            return fecha;
                
        }

        public bool InsertarUltimaFechaGeneracion()
        {
            AccesoDatos.ActualizarRegistro("EventosControl_SetFechaGeneracion",
                new object[] { }, new string[] { });
            return true;
      

        }


        public System.Data.IDataReader RecuperarEventosPendientes()
        {
            return AccesoDatos.RecuperarDatos("Eventos_RecuperarEventosPendientes",
                new object[] { }, new string[] { });
        }


        public bool GenerarEventos()
        {
            AccesoDatos.ActualizarRegistro("Eventos_GenerarEventos", new object[] { }, new string[] { });
            return true;
        
        }



    }
}
