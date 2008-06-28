using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Eventos
{

    /// <summary>
    /// Configuracion general de eventos
    /// </summary>
    public class Configuracion
    {

        private Configuracion()
        { 
            
        
        }

        /// <summary>
        /// Recupera la ultima configuracion disponible
        /// </summary>
        public static Configuracion RecuperarUltimaConfiguracion()
        {
            Configuracion conf = new Configuracion();
            try
            {
                
                conf.Activo = bool.Parse(System.Configuration.ConfigurationManager.AppSettings["ActivarGeneracionEventos"].ToString());
                conf.FechaUltimaGeneracion = DateTime.Now.AddMinutes(-1);
                conf.FrecuenciaGeneracion = new TimeSpan(0, int.Parse(System.Configuration.ConfigurationManager.AppSettings["FrecuenciaMinutosGeneracionEventos"].ToString()), 0);

                
            }
            catch
            {
                conf.Activo = false;
                conf.FrecuenciaGeneracion = new TimeSpan(0, 30, 0);
                conf.FechaUltimaGeneracion = DateTime.Now;
            }

            return conf;
        }


        private DateTime fechaUltimaGeneracion;
        private TimeSpan frecuenciaGeneracion;
        private bool activo;



        /// <summary>
        ///
        /// </summary>
        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }


        /// <summary>
        /// Fecha en la que se generaron eventos por ultima vez
        /// </summary>
        public DateTime FechaUltimaGeneracion
        {
            get { return fechaUltimaGeneracion; }
            set { fechaUltimaGeneracion = value; }
        }
        
        /// <summary>
        /// Frecuencia con la que se deben generar los eventos
        /// </summary>
        public TimeSpan FrecuenciaGeneracion
        {
            get { return frecuenciaGeneracion; }
            set { frecuenciaGeneracion = value; }
        }






    }
}
