using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Managers.Eventos
{
    public class MngEventos
    {
        
        /// <summary>
        /// Revisa y genera eventos pendientes
        /// </summary>
        public void GenerarEventos()
        {
            GI.BR.Eventos.Eventos eventos = new GI.BR.Eventos.Eventos();
            eventos.GenerarEventosPendientes();

            
        }


        



        /// <summary>
        /// Recupera coleccion de eventos vigentes
        /// </summary>
        /// <returns></returns>
        public GI.BR.Eventos.Eventos RecuperarEventosActivos()
        {
            GI.BR.Eventos.Eventos eventos = new GI.BR.Eventos.Eventos();

            //eventos.RecuperarEventosPendientes();

            return eventos;
        }


    }
}
