using System;
using System.Collections.Generic;
using System.Text;
using GI.Managers.Eventos;

namespace GI.UI
{

    public delegate void NotificarEventosHandler(GI.BR.Eventos.Eventos Eventos);

    public class EventosService
    {

        private static EventosService _Servicio;

        public static EventosService Servicio
        {
            get {
                if (_Servicio == null) _Servicio = new EventosService();
                return EventosService._Servicio; }
        }

        private EventosService()
        {

            configuracion = GI.BR.Eventos.Configuracion.RecuperarUltimaConfiguracion();

            mngEventos = new MngEventos();
            eventos = mngEventos.RecuperarEventosActivos();

            timer = new System.Timers.Timer();
            timer.Interval = configuracion.FrecuenciaGeneracion.TotalMilliseconds;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            timer.Start();

        }





        public event NotificarEventosHandler OnNuevosEventos;

        private frmPopUpEventos frmPopUp = new frmPopUpEventos();
        private System.Timers.Timer timer;
        private GI.BR.Eventos.Configuracion configuracion;
        private GI.BR.Eventos.Eventos eventos;
        private MngEventos mngEventos;



        public GI.BR.Eventos.Eventos Eventos
        {
            get { return eventos; }
            set { eventos = value; }
        }



        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {


            configuracion = GI.BR.Eventos.Configuracion.RecuperarUltimaConfiguracion();
            timer.Interval = configuracion.FrecuenciaGeneracion.TotalMilliseconds;

            if (configuracion.Activo)
            {
                //Evaluamos si debemos salir a generar eventos nuevos
                if (configuracion.FechaUltimaGeneracion.AddTicks(configuracion.FrecuenciaGeneracion.Ticks) <= DateTime.Now)
                {
                    mngEventos.GenerarEventos();
                }
            }

            eventos = mngEventos.RecuperarEventosActivos();
            
            OnNuevosEventos(eventos);


        }




    }
}
