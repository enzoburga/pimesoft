using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Framework.Seguridad
{
    public class MngTiempo
    {
        private WorldTimeWebService.WorldTimeWebService wtws;        
        private Nullable<DateTime> fechaHoy = null;

        private static MngTiempo instancia;
        public static MngTiempo GetInstancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new MngTiempo();
                    
                }
                return instancia;
            }
        }

        public DateTime GetFechaHoy()
        {
            if (!fechaHoy.HasValue)
            {
                wtws = new GI.Framework.WorldTimeWebService.WorldTimeWebService();
                WorldTimeWebService.TimeZoneInfo tzi = wtws.GetTimeZoneInfo("(GMT-03:00) Buenos Aires, Georgetown");
                fechaHoy = new DateTime(tzi.CurrentTimeTicks);
            }
            return fechaHoy.Value;

        }
    }
}
