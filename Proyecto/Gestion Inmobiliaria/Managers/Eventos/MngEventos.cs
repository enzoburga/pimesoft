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
        
        
        }



        /// <summary>
        /// Recupera coleccion de eventos vigentes
        /// </summary>
        /// <returns></returns>
        public GI.BR.Eventos.Eventos RecuperarEventosActivos()
        {
            GI.BR.Eventos.Eventos eventos = new GI.BR.Eventos.Eventos();

            GI.BR.Eventos.EventoPagoAlquiler e = new GI.BR.Eventos.EventoPagoAlquiler();
            e.Descripcion = "Pago de Alquiler Propiedad P00123 se encuentra vencido";
            e.Fecha = DateTime.Now;
            e.IdEvento = 1;
            e.Vencimiento = DateTime.Now.AddDays(-1);

            eventos.Add(e);

            return eventos;
        }


    }
}
